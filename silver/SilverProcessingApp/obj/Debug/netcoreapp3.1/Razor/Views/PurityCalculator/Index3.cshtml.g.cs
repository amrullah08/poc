#pragma checksum "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\Index3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "720fef095369b4461bd901b8e847336950eea327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurityCalculator_Index3), @"mvc.1.0.view", @"/Views/PurityCalculator/Index3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"720fef095369b4461bd901b8e847336950eea327", @"/Views/PurityCalculator/Index3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe31ebef2a72da546f7b5de2966d35f55f981db1", @"/Views/_ViewImports.cshtml")]
    public class Views_PurityCalculator_Index3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Export Data</h1>\r\n</div>\r\n<div class=\"jumbotron\">\r\n    <div class=\"lead\">\r\n        <div class=\"table-responsive col-md-12\" id=\"divajaxCall\">\r\n");
#nullable restore
#line 7 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\Index3.cshtml"
             using (Html.BeginForm("ExporDataToFile", "PurityCalculator", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-3"">
                        <label>
                            <input checked=""checked"" id=""ExportExcel"" name=""Export""
                                   type=""radio"" value=""Excel"" />
                            <i class=""far fa-file-excel"">  Export To Excel</i>
                        </label>
                    </div>

                    <div class=""col-md-3"">
                        <label>
                            <input id=""ExportPdf"" name=""Export"" type=""radio""
                                   value=""Pdf"" />
                            <i class=""far fa-file-pdf"">  Export To Pdf</i>
                        </label>
                    </div>
                    <div class=""col-md-3"">
                        <label>
                            <input id=""ExportToWord"" name=""Export"" type=""radio""
                                   value=""Word"" />
                            <i class=""far fa-file-word"">  Expor");
            WriteLiteral("t To Word</i>\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-12"" style=""text-align:center; padding : 5px 5px 5px 5px"">
                        <button id=""btnExportData"" type=""submit"" value=""ExportData"" name=""action"">
                            <i class=""fas fa-file-download""> Export Data </i>
                        </button>
                    </div>
                </div>
                <div class=""row"" style=""text-align:center; padding : 5px 5px 5px 5px""></div>
                <div class=""divfooter"">
                </div>
");
#nullable restore
#line 44 "C:\Users\Mahesh\Documents\GitHub\poc\silver\SilverProcessingApp\Views\PurityCalculator\Index3.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<script src=\"https://kit.fontawesome.com/00267cf40d.js\" crossorigin=\"anonymous\"></script>");
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
