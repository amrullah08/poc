#pragma checksum "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1f8bbf892a3c81df78555f076772faa5666b1d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BuyingRawSilver_Update), @"mvc.1.0.view", @"/Views/BuyingRawSilver/Update.cshtml")]
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
#line 1 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\_ViewImports.cshtml"
using SilverProcessingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\_ViewImports.cshtml"
using SilverProcessingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f8bbf892a3c81df78555f076772faa5666b1d1", @"/Views/BuyingRawSilver/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe31ebef2a72da546f7b5de2966d35f55f981db1", @"/Views/_ViewImports.cshtml")]
    public class Views_BuyingRawSilver_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:moccasin;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1f8bbf892a3c81df78555f076772faa5666b1d14000", async() => {
                WriteLiteral("\r\n    <h3>Product Info</h3>\r\n    <table cellpadding=\"2\" cellspacing=\"2\" border=\"1\">\r\n        <tr>\r\n        <tr>\r\n            <td>Mass</td>\r\n            <td>");
#nullable restore
#line 7 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.Mass);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>RawSilverQuantity</td>\r\n            <td>");
#nullable restore
#line 11 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.RawSilverQuantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>NoSilverUnits</td>\r\n            <td>");
#nullable restore
#line 15 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.NoSilverUnits);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>GramsPerUnit</td>\r\n            <td>");
#nullable restore
#line 19 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.GramsPerUnit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>SilverValue</td>\r\n            <td>");
#nullable restore
#line 23 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.SilverValue);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>GST</td>\r\n            <td>");
#nullable restore
#line 27 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.GST);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>TotalAmount</td>\r\n            <td>");
#nullable restore
#line 31 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.TotalAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>SupplierName</td>\r\n            <td>");
#nullable restore
#line 35 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.SupplierName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>SupplierPhoneNo</td>\r\n            <td>");
#nullable restore
#line 39 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.SupplierPhoneNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>DateofPurchase</td>\r\n            <td>");
#nullable restore
#line 43 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.DateofPurchase);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>PC Name</td>\r\n            <td>");
#nullable restore
#line 47 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.PCNAME);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>IP Address</td>\r\n            <td>");
#nullable restore
#line 51 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
           Write(ViewBag.BuyingRawSilver.IPADDRESS);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>Photo(s)</td>\r\n            <td>\r\n");
#nullable restore
#line 57 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
                 foreach (var photo in ViewBag.BuyingRawSilver.Photos)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1f8bbf892a3c81df78555f076772faa5666b1d19111", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1782, "~/images/", 1782, 9, true);
#nullable restore
#line 59 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
AddHtmlAttributeValue("", 1791, photo, 1791, 6, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 60 "F:\Devops\BehaviouralAssessment\src\poc2\SilverProcessingApp\Views\BuyingRawSilver\Update.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </td>\r\n        </tr>\r\n    </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
