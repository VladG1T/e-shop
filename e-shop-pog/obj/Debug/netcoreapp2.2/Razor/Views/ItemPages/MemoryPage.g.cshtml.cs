#pragma checksum "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f34fff8b5637bb524cfc25c203cc75c5da396d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemPages_MemoryPage), @"mvc.1.0.view", @"/Views/ItemPages/MemoryPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ItemPages/MemoryPage.cshtml", typeof(AspNetCore.Views_ItemPages_MemoryPage))]
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
#line 1 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\_ViewImports.cshtml"
using EShop;

#line default
#line hidden
#line 2 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\_ViewImports.cshtml"
using EShop.Models;

#line default
#line hidden
#line 3 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\_ViewImports.cshtml"
using EShop.Helpers;

#line default
#line hidden
#line 4 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f34fff8b5637bb524cfc25c203cc75c5da396d3", @"/Views/ItemPages/MemoryPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8407176f053d7f2ee38904ca08f135ea6716f5c", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemPages_MemoryPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
  
	Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(50, 29, true);
            WriteLiteral("<h1 class=\"alert alert-info\">");
            EndContext();
            BeginContext(80, 17, false);
#line 4 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
                        Write(ViewBag.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(97, 14, true);
            WriteLiteral(" Memory</h1>\r\n");
            EndContext();
#line 5 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
 if (Context.Request.Query["success"].FirstOrDefault() == "true") {

#line default
#line hidden
            BeginContext(180, 124, true);
            WriteLiteral("\t<div class=\"alert alert-success\">\r\n\t\t<h4 class=\"alert-heading\">Success!</h4>\r\n\t\tThe item has been added to cart.\r\n\t</div>\r\n");
            EndContext();
#line 10 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
}

#line default
#line hidden
            BeginContext(307, 72, true);
            WriteLiteral("<hr />\r\n<div>\r\n\t<div class=\"image-container\">\r\n\t\t<img style=\"width:100%\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 379, "\"", 441, 1);
#line 14 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
WriteAttributeValue("", 385, Url.Content(String.Format("~{0}", ViewBag.Item.ImgURL)), 385, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(442, 28, true);
            WriteLiteral(" />\r\n\t\t<hr />\r\n\t\t<h2>Price: ");
            EndContext();
            BeginContext(471, 18, false);
#line 16 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
              Write(ViewBag.Item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(489, 10, true);
            WriteLiteral("$</h2>\r\n\t\t");
            EndContext();
            BeginContext(499, 403, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f34fff8b5637bb524cfc25c203cc75c5da396d36500", async() => {
                BeginContext(558, 37, true);
                WriteLiteral("\r\n\t\t\t<input type=\"hidden\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 595, "\"", 621, 1);
#line 18 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
WriteAttributeValue("", 603, ViewBag.Item.Name, 603, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(622, 42, true);
                WriteLiteral(" />\r\n\t\t\t<input type=\"hidden\" name=\"imgURL\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 664, "\"", 692, 1);
#line 19 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
WriteAttributeValue("", 672, ViewBag.Item.ImgURL, 672, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(693, 41, true);
                WriteLiteral(" />\r\n\t\t\t<input type=\"hidden\" name=\"price\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 734, "\"", 761, 1);
#line 20 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
WriteAttributeValue("", 742, ViewBag.Item.Price, 742, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(762, 133, true);
                WriteLiteral(" />\r\n\t\t\t<input type=\"hidden\" name=\"category\" value=\"Memory\" />\r\n\t\t\t<input type=\"submit\" class=\"btn-warning btn-lg\" value=\"Add\" />\r\n\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(902, 202, true);
            WriteLiteral("\r\n\t</div>\r\n\t<div class=\"content-container\">\r\n\t\t<b style=\"font-size: 18px\">Specs:</b>\r\n\t\t<br />\r\n\t\t<table class=\"table table-condensed table-striped table-bordered\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Name</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1105, 17, false);
#line 31 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
               Write(ViewBag.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 58, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Frequency</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1181, 22, false);
#line 35 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
               Write(ViewBag.Item.Frequency);

#line default
#line hidden
            EndContext();
            BeginContext(1203, 63, true);
            WriteLiteral(" MHz</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>RAM Buffer</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1267, 19, false);
#line 39 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
               Write(ViewBag.Item.Buffer);

#line default
#line hidden
            EndContext();
            BeginContext(1286, 56, true);
            WriteLiteral(" Gb</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Type</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1343, 17, false);
#line 43 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
               Write(ViewBag.Item.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1360, 52, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>LED</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1413, 19, false);
#line 47 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
               Write(ViewBag.Item.HasLED);

#line default
#line hidden
            EndContext();
            BeginContext(1432, 114, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t</table>\r\n\t</div>\r\n\t<div>\r\n\t\t<a class=\"btn btn-light\" style=\"margin-top:4px; margin-bottom:6px\"");
            EndContext();
            BeginWriteAttribute("href", " href=", 1546, "", 1671, 1);
#line 52 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
WriteAttributeValue("", 1552, String.Format("/comment/post?username={0}&categoryName={1}&itemId={2}", User.Identity.Name, "Memory", ViewBag.Item.Id), 1552, 119, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1671, 38, true);
            WriteLiteral(">Post a comment</a>\r\n\t</div>\r\n\t<div>\r\n");
            EndContext();
#line 55 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
         if (((IQueryable<Comment>)ViewBag.Comments).Any()) {
			foreach (Comment i in ViewBag.Comments) {

#line default
#line hidden
            BeginContext(1812, 100, true);
            WriteLiteral("\t\t\t\t<div class=\"frame\" style=\"height:auto\">\r\n\t\t\t\t\t<label style=\"font-size:18px; margin-bottom:-3px\">");
            EndContext();
            BeginContext(1913, 10, false);
#line 58 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
                                                                 Write(i.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1923, 72, true);
            WriteLiteral("</label><br />\r\n\t\t\t\t\t<label style=\"font-size:10px; font-weight:lighter\">");
            EndContext();
            BeginContext(1996, 6, false);
#line 59 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
                                                                  Write(i.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2002, 87, true);
            WriteLiteral("</label><br />\r\n\t\t\t\t\t<label style=\"font-size:14px; font-weight:normal\"><b>Comment: </b>");
            EndContext();
            BeginContext(2090, 6, false);
#line 60 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
                                                                                 Write(i.Body);

#line default
#line hidden
            EndContext();
            BeginContext(2096, 28, true);
            WriteLiteral("</label><br />\r\n\t\t\t\t</div>\r\n");
            EndContext();
#line 62 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\MemoryPage.cshtml"
			}
		}

#line default
#line hidden
            BeginContext(2135, 19, true);
            WriteLiteral("\t</div>\r\n</div>\r\n\r\n");
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
