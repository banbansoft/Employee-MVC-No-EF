#pragma checksum "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\ViewEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24f4c7f55b127d5444368831bc41a52e3550afc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_ViewEmployees), @"mvc.1.0.view", @"/Views/Employees/ViewEmployees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24f4c7f55b127d5444368831bc41a52e3550afc0", @"/Views/Employees/ViewEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96d00b1b53294b9a00e427e264fab62932dc9dea", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_ViewEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employees>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24f4c7f55b127d5444368831bc41a52e3550afc03308", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24f4c7f55b127d5444368831bc41a52e3550afc04367", async() => {
                WriteLiteral("\r\n    <p>\r\n        ");
#nullable restore
#line 13 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\ViewEmployees.cshtml"
   Write(Html.ActionLink("Create New", "AddEmployees"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <br />\r\n    <table cellpadding=\"0\" cellspacing=\"0\">\r\n        <tr>\r\n            <th>Code</th>\r\n            <th>Name</th>\r\n            <th>Salary</th>\r\n        </tr>\r\n");
#nullable restore
#line 22 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\ViewEmployees.cshtml"
         foreach (var employee in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\ViewEmployees.cshtml"
               Write(employee.Code);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\ViewEmployees.cshtml"
               Write(employee.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\ViewEmployees.cshtml"
               Write(employee.Salary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\ViewEmployees.cshtml"
               Write(Html.ActionLink("Edit", "SearchEmployees", employee));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                    ");
#nullable restore
#line 30 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\ViewEmployees.cshtml"
               Write(Html.ActionLink("Delete", "DeleteEmployees", new { id = employee.Code }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\ViewEmployees.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employees>> Html { get; private set; }
    }
}
#pragma warning restore 1591
