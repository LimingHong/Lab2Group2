#pragma checksum "C:\Users\812217\source\repos\CPRG214Lab2.AssetTracking\CPRG214Lab2.AssetTracking.App\Views\Assets\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b7d2795b4c38a429e815fe7b10cea4daee79858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assets_Search), @"mvc.1.0.view", @"/Views/Assets/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Assets/Search.cshtml", typeof(AspNetCore.Views_Assets_Search))]
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
#line 1 "C:\Users\812217\source\repos\CPRG214Lab2.AssetTracking\CPRG214Lab2.AssetTracking.App\Views\_ViewImports.cshtml"
using CPRG214Lab2.AssetTracking.App;

#line default
#line hidden
#line 2 "C:\Users\812217\source\repos\CPRG214Lab2.AssetTracking\CPRG214Lab2.AssetTracking.App\Views\_ViewImports.cshtml"
using CPRG214Lab2.AssetTracking.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b7d2795b4c38a429e815fe7b10cea4daee79858", @"/Views/Assets/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e647ced401be92721b2210f4355873ecba9aa46f", @"/Views/_ViewImports.cshtml")]
    public class Views_Assets_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("uxAssetTypes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\812217\source\repos\CPRG214Lab2.AssetTracking\CPRG214Lab2.AssetTracking.App\Views\Assets\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(44, 95, true);
            WriteLiteral("\r\n<h2>Search Assets by Asset Type</h2>\r\n\r\n\r\n<div>\r\n    <label>Select Assets Type:</label>\r\n    ");
            EndContext();
            BeginContext(139, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "887093acdb9f4aee8e20b6bec2e72a48", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 11 "C:\Users\812217\source\repos\CPRG214Lab2.AssetTracking\CPRG214Lab2.AssetTracking.App\Views\Assets\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.AssetTypes;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(206, 42, true);
            WriteLiteral("\r\n</div>\r\n<div id=\"uxFilteredAsset\">\r\n    ");
            EndContext();
            BeginContext(249, 45, false);
#line 14 "C:\Users\812217\source\repos\CPRG214Lab2.AssetTracking\CPRG214Lab2.AssetTracking.App\Views\Assets\Search.cshtml"
Write(await Component.InvokeAsync("AssetByType", 0));

#line default
#line hidden
            EndContext();
            BeginContext(294, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(321, 888, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            //When property type selection changes, we get the selected value
            //to use in the asynchronous ajax call
            $(""#uxAssetTypes"").change(function () {
                var assetTypeId = $(""#uxAssetTypes"").val();

                //AJAX call is a GET to the controller method that calls the
                //view component--the id comes from the property type selection.
                //The done method handles the callback asynchronously.
                $.ajax({
                    method: 'GET',
                    url: '/Assets/GetAssetsByType',
                    data: { id: assetTypeId }
                }).done(function (result, statusText, xhdr) {
                    $(""#uxFilteredAsset"").html(result);
                    });
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(1212, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
