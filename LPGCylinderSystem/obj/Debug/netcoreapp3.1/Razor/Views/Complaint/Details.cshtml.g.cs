#pragma checksum "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd55453508d49175c49b4db2a8d4e8f108a454cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Complaint_Details), @"mvc.1.0.view", @"/Views/Complaint/Details.cshtml")]
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
#nullable restore
#line 1 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\_ViewImports.cshtml"
using LPGCylinderSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\_ViewImports.cshtml"
using LPGCylinderSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd55453508d49175c49b4db2a8d4e8f108a454cd", @"/Views/Complaint/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62efaadd6ea989c58047208d60664bfac5ab79be", @"/Views/_ViewImports.cshtml")]
    public class Views_Complaint_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LPGCylinderSystem.Models.Complaint>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/assets/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/assets/css/font-awesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/assets/css/templatemo-softy-pinko.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd55453508d49175c49b4db2a8d4e8f108a454cd6273", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd55453508d49175c49b4db2a8d4e8f108a454cd7471", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dd55453508d49175c49b4db2a8d4e8f108a454cd8667", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<div style=\"background-color: #F2F2FE \">\n");
#nullable restore
#line 10 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
     if (ViewBag.Error == "Error")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>No Complaints yet!!!!</h1> ");
#nullable restore
#line 12 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
                               }
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
                <br />
                                <br />
                                                <br />
                                                                <br />
                                                                                <br />
");
            WriteLiteral("                                                                                                <h1 style=\"padding-left:200px\">Details</h1>\n");
#nullable restore
#line 25 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
                                                                                                                 foreach (var item in Model)
                                                                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                                                <div>
                                                                                                    <h4 style=""padding-left:200px"">Your Complaints</h4>
                                                                                                    <hr />
                                                                                                    <dl class=""row"" style=""padding-left:200px"">
                                                                                                        <dt class=""col-sm-2"">
                                                                                                            item.Complaint_Id

                                                                                                        </dt>
                                                                                                        <dd class=""col-sm-10"">
                             ");
            WriteLiteral("                                                                               ");
#nullable restore
#line 36 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
                                                                                                       Write(item.Complaint_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                        </dd>
                                                                                                        <dt class=""col-sm-2"">
                                                                                                            item.Category
                                                                                                        </dt>
                                                                                                        <dd class=""col-sm-10"">
                                                                                                            ");
#nullable restore
#line 42 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
                                                                                                       Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                        </dd>
                                                                                                        <dt class=""col-sm-2"">
                                                                                                            item.Description
                                                                                                        </dt>
                                                                                                        <dd class=""col-sm-10"">
                                                                                                            ");
#nullable restore
#line 48 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
                                                                                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                        </dd>
                                                                                                        <dt class=""col-sm-2"">
                                                                                                            item.Status
                                                                                                        </dt>
                                                                                                        <dd class=""col-sm-10"">
                                                                                                            ");
#nullable restore
#line 54 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
                                                                                                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                        </dd>
                                                                                                        <dt class=""col-sm-2"">
                                                                                                            item.Remark
                                                                                                        </dt>
                                                                                                        <dd class=""col-sm-10"">
                                                                                                            ");
#nullable restore
#line 60 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
                                                                                                       Write(item.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                                        </dd>
                                                                                                    </dl>
                                                                                                </div>
                                                                                                                                        <div style=""padding-left:200px;margin-top:20px;margin-bottom:20px"">
                                                                                                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd55453508d49175c49b4db2a8d4e8f108a454cd17433", async() => {
                WriteLiteral("Go To Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                                                                                                        </div>\n");
#nullable restore
#line 67 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
                                                                                                                                                           }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "H:\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Details.cshtml"
                                                                                                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LPGCylinderSystem.Models.Complaint>> Html { get; private set; }
    }
}
#pragma warning restore 1591
