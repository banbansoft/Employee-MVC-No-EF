#pragma checksum "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\AddEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6409df81efdb32484d8d8bef5386a830d0910de1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_AddEmployees), @"mvc.1.0.view", @"/Views/Employees/AddEmployees.cshtml")]
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
#line 1 "D:\Outsource\WebEmployee\WebEmployee\Views\_ViewImports.cshtml"
using WebEmployee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Outsource\WebEmployee\WebEmployee\Views\_ViewImports.cshtml"
using WebEmployee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6409df81efdb32484d8d8bef5386a830d0910de1", @"/Views/Employees/AddEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96d00b1b53294b9a00e427e264fab62932dc9dea", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_AddEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employees>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\AddEmployees.cshtml"
 using (Html.BeginForm("SaveEmployees", "Employees"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table-condensed\">\r\n    <tr>\r\n        <td>\r\n            <span>Code:</span>\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 12 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\AddEmployees.cshtml"
       Write(Html.TextBoxFor(m => m.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            <span>Name:</span>\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 20 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\AddEmployees.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            <span>Salary:</span>\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 28 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\AddEmployees.cshtml"
       Write(Html.TextBoxFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\" align=\"center\">\r\n            <button value=\"submit\" class=\"btn btn-primary\" title=\"submit\">Save</button>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 37 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\AddEmployees.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 39 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\AddEmployees.cshtml"
   Write(Html.ActionLink("Back to List", "ViewEmployees"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591