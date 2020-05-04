using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UpCycling.Models.AgendaController;
using UpCycling.Service.Interface;

namespace UpCycling.Controllers
{
    public class AgendaController : Controller
    {
        public AgendaController(IEventServices eventServices, IUserService userService, ILiaison liaison)
        {
            EventServices = eventServices ?? throw new ArgumentNullException(nameof(eventServices));
            UserService = userService ?? throw new ArgumentNullException(nameof(userService));
            Liaison = liaison ?? throw new ArgumentNullException(nameof(liaison));
        }

        public IEventServices EventServices { get; }
        public IUserService UserService { get; }
        public ILiaison Liaison { get; }

        public IActionResult Index()
        {
            ListLiaisonViewModel allEvent = new ListLiaisonViewModel();
            allEvent.ListeEvent = EventServices.GetAllEvents().Select(w => new ShowEventVueModel {

                Id = w.Id,
                Nom = w.Nom,
                Date = w.Date,
            });
            return View(allEvent);
        }

        public IActionResult InfoEvent(int idEvent)
        {
            var currentEvent = EventServices.GetEvent(idEvent);
            var curEvent = new ShowEventVueModel
            {
                Nom = currentEvent.Nom,
                Date = currentEvent.Date,
                Description = currentEvent.Description,
                Prix = currentEvent.Prix,
                Id = currentEvent.Id,
            };
            return View(curEvent);
        }

        public IActionResult ReservationToEvent(int idEvent)
        {
            var newResa = new ReserveEventViewModel
            {
                IdEvent = idEvent,
                IdUser = UserService.GetUserByMail(User.Identity.Name).Id,
                NomEvent = EventServices.GetEvent(idEvent).Nom,
                PlacLibre = EventServices.GetEvent(idEvent).Place - Liaison.GetAllLiaison().Where(w => w.EventId == idEvent).Count(),
            };
            return View(newResa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReservationToEvent(ReserveEventViewModel reserveEvent)
        {
            var place = EventServices.GetEvent(reserveEvent.IdEvent).Place - Liaison.GetAllLiaison().Where(w => w.EventId == reserveEvent.IdEvent).Count();

            if (place - reserveEvent.PlacePrise > 0)
            {
                for (int i = 0; i < reserveEvent.PlacePrise; i++)
                {
                    Liaison.CreateLiaison(reserveEvent.IdEvent, reserveEvent.IdUser);
                }
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("File", "Il n'y pas assez de place disponible");
            reserveEvent.NomEvent = EventServices.GetEvent(reserveEvent.IdEvent).Nom;
            return View(reserveEvent);
        }
    }
}