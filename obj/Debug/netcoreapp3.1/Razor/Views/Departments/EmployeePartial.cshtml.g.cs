#pragma checksum "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03307eae6f19c3fd9a37584153b56c7e69e68fa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_EmployeePartial), @"mvc.1.0.view", @"/Views/Departments/EmployeePartial.cshtml")]
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
#line 2 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
using Perfomans.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03307eae6f19c3fd9a37584153b56c7e69e68fa4", @"/Views/Departments/EmployeePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9040d319330686114fb437e0bf9041a8738d7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_EmployeePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Perfomans.Models.Departments>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
  
    ViewData["Title"] = "Employees -";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div style=\"margin-top:1.5em\" class=\"container\">\n    <div class=\"row\">\n        <div class=\"col\">\n");
            WriteLiteral("        </div>\n        <div class=\"col\">\n\n");
            WriteLiteral(@"        </div>
        <div class=""col"">
        </div>
    </div>
</div>

<table class=""table_main"">
    <caption>Employees</caption>
    <thead>
        <tr>
            <th>Name</th>
            <th>Surname</th>
            <th>Perfomances</th>
            <th>Progress</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 44 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
         foreach (User user in Model.User)
        {
            if (user.DepartmentId == Model.Id)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 50 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                   Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 53 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                   Write(user.SourName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 56 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                         foreach (DepartmentParameters deparameters in Model.DepartmentParameters)

                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                             foreach (Evaluations evaluations in ViewBag.Evaluations)
                            {
                                if ((deparameters.ParameterId == evaluations.ParameterId) & (evaluations.UserId == user.Id))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                               Write(evaluations.Parameter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>-</span> ");
#nullable restore
#line 63 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                                                                          Write(evaluations.Mark);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                                                                                                

                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <br />\n");
#nullable restore
#line 68 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td>\n");
#nullable restore
#line 71 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                         if (@user.progress == -1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>Progress down</label>\n");
#nullable restore
#line 74 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                         if (@user.progress == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>Average</label>\n");
#nullable restore
#line 78 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                         if (@user.progress == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>Progress up</label>\n");
#nullable restore
#line 82 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n\n                </tr>\n");
#nullable restore
#line 86 "C:\Users\AnamQ\Downloads\Workers_performance_analisys-master\Perfomans\Views\Departments\EmployeePartial.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>");
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
