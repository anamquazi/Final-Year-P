#pragma checksum "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd25f35ea81c650a9490cfdb8c04354062222ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evaluations_Delete), @"mvc.1.0.view", @"/Views/Evaluations/Delete.cshtml")]
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
#line 1 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\_ViewImports.cshtml"
using Perfomans;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\_ViewImports.cshtml"
using Perfomans.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bd25f35ea81c650a9490cfdb8c04354062222ec", @"/Views/Evaluations/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9040d319330686114fb437e0bf9041a8738d7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Evaluations_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Perfomans.Models.Evaluations>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
  
    ViewData["Title"] = "Delete evaluation -";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Are you sure about that?</h3>\n<table class=\"table_main\">\n    <caption>Delete Evaluation</caption>\n    <tr>\n        <th>\n            ");
#nullable restore
#line 12 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 15 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n    </tr>\n    <tr>\n        <th>\n            ");
#nullable restore
#line 20 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Assessor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 23 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Assessor.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n    </tr>\n    <tr>\n        <th>\n            Employee\n        </th>\n        <th>\n            ");
#nullable restore
#line 31 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n    </tr>\n    <tr>\n        <th>\n            ");
#nullable restore
#line 36 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Parameter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 39 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Parameter.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n    </tr>\n    <tr>\n        <th>\n            ");
#nullable restore
#line 44 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 47 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n    </tr>\n</table>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bd25f35ea81c650a9490cfdb8c04354062222ec8209", async() => {
                WriteLiteral("\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7bd25f35ea81c650a9490cfdb8c04354062222ec8471", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 53 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Evaluations\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n      <input type=\"submit\" value=\"Delete\" class=\"btn_danger\" /> \n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bd25f35ea81c650a9490cfdb8c04354062222ec11443", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Perfomans.Models.Evaluations> Html { get; private set; }
    }
}
#pragma warning restore 1591
