#pragma checksum "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\SaveEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9bb017b3792ba335121c2be16e14595576522c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_SaveEmployees), @"mvc.1.0.view", @"/Views/Employees/SaveEmployees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bb017b3792ba335121c2be16e14595576522c4", @"/Views/Employees/SaveEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96d00b1b53294b9a00e427e264fab62932dc9dea", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_SaveEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Save Success</p>\r\n<div>\r\n    ");
#nullable restore
#line 3 "D:\Outsource\WebEmployee\WebEmployee\Views\Employees\SaveEmployees.cshtml"
Write(Html.ActionLink("Back to List", "ViewEmployees"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div> ");
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
