#pragma checksum "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4760abc5c0e0900dfe3ff9b539ccf042a5c126c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurityCalculator_List), @"mvc.1.0.view", @"/Views/PurityCalculator/List.cshtml")]
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
#line 1 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\_ViewImports.cshtml"
using SilverProcessingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\_ViewImports.cshtml"
using SilverProcessingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4760abc5c0e0900dfe3ff9b539ccf042a5c126c3", @"/Views/PurityCalculator/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe31ebef2a72da546f7b5de2966d35f55f981db1", @"/Views/_ViewImports.cshtml")]
    public class Views_PurityCalculator_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SilverProcessingApp.Models.ScrapSilverPurityCalculatorJobDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4760abc5c0e0900dfe3ff9b539ccf042a5c126c33818", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantityinGms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayNameFor(model => model.PercentageTomakepure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayNameFor(model => model.PureSilver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpectedfinalPurity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalPurity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayNameFor(model => model.FinalValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantityinGms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.PercentageTomakepure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.PureSilver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpectedfinalPurity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalPurity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.FinalValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SilverProcessingApp.Models.ScrapSilverPurityCalculatorJobDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
