#pragma checksum "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b8d8249be01dfdc4f81f376c2e7bf4ee4fa3b3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateEvent), @"mvc.1.0.view", @"/Views/Admin/CreateEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CreateEvent.cshtml", typeof(AspNetCore.Views_Admin_CreateEvent))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\adubuis\source\repos\UpCycling\Views\_ViewImports.cshtml"
using UpCycling;

#line default
#line hidden
#line 2 "C:\Users\adubuis\source\repos\UpCycling\Views\_ViewImports.cshtml"
using UpCycling.Models;

#line default
#line hidden
#line 3 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
using UpCycling.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b8d8249be01dfdc4f81f376c2e7bf4ee4fa3b3e", @"/Views/Admin/CreateEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47aa23a30764c932c4627ea5e5559a580c4ca8d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CreateEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UpCycling.Models.AdminController.CreateEventViewModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 36, true);
            WriteLiteral("<h2>Créer un Administrateur</h2>\r\n\r\n");
            EndContext();
#line 6 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
 using (Html.BeginForm(nameof(AdminController.CreateEvent), "Admin", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(277, 23, false);
#line 8 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(302, 27, true);
            WriteLiteral("    <label> Nom :</label>\r\n");
            EndContext();
            BeginContext(334, 31, false);
#line 10 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
Write(Html.TextBoxFor(m => Model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(367, 35, true);
            WriteLiteral("    <label> Description :</label>\r\n");
            EndContext();
            BeginContext(409, 33, false);
#line 13 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
Write(Html.TextAreaFor(m => Model.Desc));

#line default
#line hidden
            EndContext();
            BeginContext(444, 28, true);
            WriteLiteral("    <label> Prix :</label>\r\n");
            EndContext();
            BeginContext(479, 32, false);
#line 16 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
Write(Html.TextBoxFor(m => Model.Prix));

#line default
#line hidden
            EndContext();
            BeginContext(513, 28, true);
            WriteLiteral("    <label> Date :</label>\r\n");
            EndContext();
            BeginContext(543, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(547, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e841effece84498caaed50c60ee92ee9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 19 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Date);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(569, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(573, 28, true);
            WriteLiteral("    <label> Lieu :</label>\r\n");
            EndContext();
            BeginContext(608, 32, false);
#line 23 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
Write(Html.TextBoxFor(m => Model.Lieu));

#line default
#line hidden
            EndContext();
            BeginContext(642, 29, true);
            WriteLiteral("    <label> Place :</label>\r\n");
            EndContext();
            BeginContext(678, 33, false);
#line 26 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
Write(Html.TextBoxFor(m => Model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(715, 149, true);
            WriteLiteral("    <div class=\"\">\r\n        <input type=\"submit\" class=\"btn btn-default rounded bg-dark text-white mt-2\" value=\"Rennomer le dossier\" />\r\n    </div>\r\n");
            EndContext();
#line 31 "C:\Users\adubuis\source\repos\UpCycling\Views\Admin\CreateEvent.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpCycling.Models.AdminController.CreateEventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
