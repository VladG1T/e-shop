#pragma checksum "D:\Лабы\3 курс\E_Shop\EShop\Views\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df9f2048a1d3bbf718cf3d25be33329ec55172e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index), @"mvc.1.0.view", @"/Views/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Index.cshtml", typeof(AspNetCore.Views_Index))]
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
#line 1 "D:\Лабы\3 курс\E_Shop\EShop\Views\_ViewImports.cshtml"
using EShop;

#line default
#line hidden
#line 2 "D:\Лабы\3 курс\E_Shop\EShop\Views\_ViewImports.cshtml"
using EShop.Models;

#line default
#line hidden
#line 3 "D:\Лабы\3 курс\E_Shop\EShop\Views\_ViewImports.cshtml"
using EShop.Helpers;

#line default
#line hidden
#line 4 "D:\Лабы\3 курс\E_Shop\EShop\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9f2048a1d3bbf718cf3d25be33329ec55172e7", @"/Views/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8407176f053d7f2ee38904ca08f135ea6716f5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Лабы\3 курс\E_Shop\EShop\Views\Index.cshtml"
  
	Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 5 "D:\Лабы\3 курс\E_Shop\EShop\Views\Index.cshtml"
  
	ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(114, 68, true);
            WriteLiteral("<table class=\"table table-condensed table-striped table-bordered\">\r\n");
            EndContext();
#line 9 "D:\Лабы\3 курс\E_Shop\EShop\Views\Index.cshtml"
     foreach (Category item in Model) {
		if ((item.Id - 1) % 3 == 0) {

#line default
#line hidden
            BeginContext(253, 3, true);
            WriteLiteral("\t\t\t");
            EndContext();
            BeginContext(258, 6, true);
            WriteLiteral("<tr>\r\n");
            EndContext();
#line 12 "D:\Лабы\3 курс\E_Shop\EShop\Views\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(270, 42, true);
            WriteLiteral("\t\t\t<td style=\"width:150px; height:30px\">\r\n");
            EndContext();
            BeginContext(403, 6, true);
            WriteLiteral("\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=", 409, "", 490, 1);
#line 15 "D:\Лабы\3 курс\E_Shop\EShop\Views\Index.cshtml"
WriteAttributeValue("", 415, String.Format("/{0}/view", item.Name.Replace(" ", string.Empty).ToLower()), 415, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(490, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(492, 9, false);
#line 15 "D:\Лабы\3 курс\E_Shop\EShop\Views\Index.cshtml"
                                                                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(501, 16, true);
            WriteLiteral("</a>\r\n\t\t\t</td>\r\n");
            EndContext();
#line 17 "D:\Лабы\3 курс\E_Shop\EShop\Views\Index.cshtml"

			if (item.Id % 3 == 0) {

#line default
#line hidden
            BeginContext(547, 3, true);
            WriteLiteral("\t\t\t");
            EndContext();
            BeginContext(552, 7, true);
            WriteLiteral("</tr>\r\n");
            EndContext();
#line 20 "D:\Лабы\3 курс\E_Shop\EShop\Views\Index.cshtml"
		}
	}

#line default
#line hidden
            BeginContext(568, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
