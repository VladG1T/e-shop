#pragma checksum "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "177111fa39a03d3211c6473587b5dd2b16304034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemPages_ProcessorPage), @"mvc.1.0.view", @"/Views/ItemPages/ProcessorPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ItemPages/ProcessorPage.cshtml", typeof(AspNetCore.Views_ItemPages_ProcessorPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"177111fa39a03d3211c6473587b5dd2b16304034", @"/Views/ItemPages/ProcessorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8407176f053d7f2ee38904ca08f135ea6716f5c", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemPages_ProcessorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
  
	Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(50, 29, true);
            WriteLiteral("<h1 class=\"alert alert-info\">");
            EndContext();
            BeginContext(80, 17, false);
#line 4 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
                        Write(ViewBag.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(97, 17, true);
            WriteLiteral(" Processor</h1>\r\n");
            EndContext();
#line 5 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
 if (Context.Request.Query["success"].FirstOrDefault() == "true") {

#line default
#line hidden
            BeginContext(183, 124, true);
            WriteLiteral("\t<div class=\"alert alert-success\">\r\n\t\t<h4 class=\"alert-heading\">Success!</h4>\r\n\t\tThe item has been added to cart.\r\n\t</div>\r\n");
            EndContext();
#line 10 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
}

#line default
#line hidden
            BeginContext(310, 72, true);
            WriteLiteral("<hr />\r\n<div>\r\n\t<div class=\"image-container\">\r\n\t\t<img style=\"width:100%\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 382, "\"", 444, 1);
#line 14 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 388, Url.Content(String.Format("~{0}", ViewBag.Item.ImgURL)), 388, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(445, 28, true);
            WriteLiteral(" />\r\n\t\t<hr />\r\n\t\t<h2>Price: ");
            EndContext();
            BeginContext(474, 18, false);
#line 16 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
              Write(ViewBag.Item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(492, 10, true);
            WriteLiteral("$</h2>\r\n\t\t");
            EndContext();
            BeginContext(502, 406, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "177111fa39a03d3211c6473587b5dd2b163040346542", async() => {
                BeginContext(561, 37, true);
                WriteLiteral("\r\n\t\t\t<input type=\"hidden\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 598, "\"", 624, 1);
#line 18 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 606, ViewBag.Item.Name, 606, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(625, 42, true);
                WriteLiteral(" />\r\n\t\t\t<input type=\"hidden\" name=\"imgURL\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 667, "\"", 695, 1);
#line 19 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 675, ViewBag.Item.ImgURL, 675, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(696, 41, true);
                WriteLiteral(" />\r\n\t\t\t<input type=\"hidden\" name=\"price\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 737, "\"", 764, 1);
#line 20 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 745, ViewBag.Item.Price, 745, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(765, 136, true);
                WriteLiteral(" />\r\n\t\t\t<input type=\"hidden\" name=\"category\" value=\"Processor\" />\r\n\t\t\t<input type=\"submit\" class=\"btn-warning btn-lg\" value=\"Add\" />\r\n\t\t");
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
            BeginContext(908, 202, true);
            WriteLiteral("\r\n\t</div>\r\n\t<div class=\"content-container\">\r\n\t\t<b style=\"font-size: 18px\">Specs:</b>\r\n\t\t<br />\r\n\t\t<table class=\"table table-condensed table-striped table-bordered\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Name</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1111, 17, false);
#line 31 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
               Write(ViewBag.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 58, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Frequency</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1187, 22, false);
#line 35 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
               Write(ViewBag.Item.Frequency);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 68, true);
            WriteLiteral(" GHz</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Turbo Frequency</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1278, 27, false);
#line 39 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
               Write(ViewBag.Item.TurboFrequency);

#line default
#line hidden
            EndContext();
            BeginContext(1305, 58, true);
            WriteLiteral(" GHz</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Cores</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1364, 21, false);
#line 43 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
               Write(ViewBag.Item.NumCores);

#line default
#line hidden
            EndContext();
            BeginContext(1385, 56, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Threads</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1442, 23, false);
#line 47 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
               Write(ViewBag.Item.NumThreads);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 54, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Cache</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1520, 18, false);
#line 51 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
               Write(ViewBag.Item.Cache);

#line default
#line hidden
            EndContext();
            BeginContext(1538, 63, true);
            WriteLiteral(" MB</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>RAM Support</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1602, 23, false);
#line 55 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
               Write(ViewBag.Item.RAMSupport);

#line default
#line hidden
            EndContext();
            BeginContext(1625, 52, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>TDP</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1678, 16, false);
#line 59 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
               Write(ViewBag.Item.TDP);

#line default
#line hidden
            EndContext();
            BeginContext(1694, 62, true);
            WriteLiteral(" W</td>\r\n\t\t\t</tr>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>Lithography</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(1757, 24, false);
#line 63 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
               Write(ViewBag.Item.Lithography);

#line default
#line hidden
            EndContext();
            BeginContext(1781, 117, true);
            WriteLiteral(" nm</td>\r\n\t\t\t</tr>\r\n\t\t</table>\r\n\t</div>\r\n\t<div>\r\n\t\t<a class=\"btn btn-light\" style=\"margin-top:4px; margin-bottom:6px\"");
            EndContext();
            BeginWriteAttribute("href", " href=", 1898, "", 2026, 1);
#line 68 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 1904, String.Format("/comment/post?username={0}&categoryName={1}&itemId={2}", User.Identity.Name, "Processor", ViewBag.Item.Id), 1904, 122, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2026, 38, true);
            WriteLiteral(">Post a comment</a>\r\n\t</div>\r\n\t<div>\r\n");
            EndContext();
#line 71 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
         if (((IQueryable<Comment>)ViewBag.Comments).Any()) {
			foreach (Comment i in ViewBag.Comments) {

#line default
#line hidden
            BeginContext(2167, 100, true);
            WriteLiteral("\t\t\t\t<div class=\"frame\" style=\"height:auto\">\r\n\t\t\t\t\t<label style=\"font-size:18px; margin-bottom:-3px\">");
            EndContext();
            BeginContext(2268, 10, false);
#line 74 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
                                                                 Write(i.Username);

#line default
#line hidden
            EndContext();
            BeginContext(2278, 72, true);
            WriteLiteral("</label><br />\r\n\t\t\t\t\t<label style=\"font-size:10px; font-weight:lighter\">");
            EndContext();
            BeginContext(2351, 6, false);
#line 75 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
                                                                  Write(i.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2357, 87, true);
            WriteLiteral("</label><br />\r\n\t\t\t\t\t<label style=\"font-size:14px; font-weight:normal\"><b>Comment: </b>");
            EndContext();
            BeginContext(2445, 6, false);
#line 76 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
                                                                                 Write(i.Body);

#line default
#line hidden
            EndContext();
            BeginContext(2451, 28, true);
            WriteLiteral("</label><br />\r\n\t\t\t\t</div>\r\n");
            EndContext();
#line 78 "D:\Лабы\3 курс\E_Shop\e-shop-pog\Views\ItemPages\ProcessorPage.cshtml"
			}
		}

#line default
#line hidden
            BeginContext(2490, 17, true);
            WriteLiteral("\t</div>\r\n</div>\r\n");
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
