#pragma checksum "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1491a396bbfc7a0052643700c268c4aa8bc949b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_GroupsPartial), @"mvc.1.0.view", @"/Views/Departments/GroupsPartial.cshtml")]
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
#line 2 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
using Perfomans.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1491a396bbfc7a0052643700c268c4aa8bc949b", @"/Views/Departments/GroupsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9040d319330686114fb437e0bf9041a8738d7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_GroupsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Perfomans.Models.Departments>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
  
    ViewData["Title"] = "Groups";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table_main\">\n    <caption>Groups</caption>\n    <thead>\n        <tr>\n            <th>Group</th>\n            <th>Parameter</th>\n            <th>Actions</th>\n            <th>Option</th>\n        </tr>\n    </thead>\n    <tbody>\n\n");
#nullable restore
#line 20 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
         foreach (Groups groups in Model.Groups)
        {
            if (groups.DepartmentId == Model.Id)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 26 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                   Write(groups.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 29 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                         foreach (ParametersGroup parametersGroup in ViewBag.ParametersGroups)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                             if (parametersGroup.GroupId == groups.id)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                           Write(parametersGroup.Parameters.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>-</span>\n");
#nullable restore
#line 34 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                           Write(parametersGroup.Mark);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                                                     

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <br />\n");
#nullable restore
#line 38 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td>\n                        <div class=\"btn_edit\">\n                            ");
#nullable restore
#line 42 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", "Groups", new { id = groups.id, DepId = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"btn_danger\">\n                            ");
#nullable restore
#line 45 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", "Groups", new { id = groups.id, DepId = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 49 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                   Write(Html.ActionLink("Show", "GroupsEmployee", "Departments", new { GroupId = groups.id, DepId = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </td>\n                </tr>\n");
#nullable restore
#line 53 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n    <tfoot class=\"full-width\">\n        <tr>\n            <th colspan=\"4\">\n                <div class=\"ui right floated small\">\n");
#nullable restore
#line 61 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                     using (Html.BeginForm("Create", "Groups", FormMethod.Get))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"hidden\" Id=\"DepId\" name=\"DepId\"");
            BeginWriteAttribute("value", " value=\"", 2043, "\"", 2060, 1);
#nullable restore
#line 63 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
WriteAttributeValue("", 2051, Model.Id, 2051, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <button type=\"submit\" class=\"btn_create\">Create New</button>\n                        <div class=\"btn\">\n                            ");
#nullable restore
#line 66 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                       Write(Html.ActionLink("Export to Excel", "Excel", "Groups", new { DepId = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 68 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\GroupsPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </th>\n        </tr>\n    </tfoot>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Perfomans.Models.Departments> Html { get; private set; }
    }
}
#pragma warning restore 1591
