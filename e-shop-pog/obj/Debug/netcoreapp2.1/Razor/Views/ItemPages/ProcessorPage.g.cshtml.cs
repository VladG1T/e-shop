#pragma checksum "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ec11c6c732d19b8818a1fa640f965fb2018cacc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ec11c6c732d19b8818a1fa640f965fb2018cacc", @"/Views/ItemPages/ProcessorPage.cshtml")]
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
#line 1 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
  
	Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(50, 29, true);
            WriteLiteral("<h1 class=\"alert alert-info\">");
            EndContext();
            BeginContext(80, 17, false);
#line 4 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
                        Write(ViewBag.Item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(97, 17, true);
            WriteLiteral(" Processor</h1>\r\n");
            EndContext();
#line 5 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
 if (Context.Request.Query["success"].FirstOrDefault() == "true") {

#line default
#line hidden
            BeginContext(183, 124, true);
            WriteLiteral("\t<div class=\"alert alert-success\">\r\n\t\t<h4 class=\"alert-heading\">Success!</h4>\r\n\t\tThe item has been added to cart.\r\n\t</div>\r\n");
            EndContext();
#line 10 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
}

#line default
#line hidden
            BeginContext(310, 74, true);
            WriteLiteral("<hr />\r\n<div>\r\n\t<div class=\"image-container\">\r\n\t\t<img style=\"width: 350px\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 384, "\"", 446, 1);
#line 14 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 390, Url.Content(String.Format("~{0}", ViewBag.Item.ImgURL)), 390, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 28, true);
            WriteLiteral(" />\r\n\t\t<hr />\r\n\t\t<h1>Price: ");
            EndContext();
            BeginContext(476, 18, false);
#line 16 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
              Write(ViewBag.Item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(494, 9, true);
            WriteLiteral("</h1>\r\n\t\t");
            EndContext();
            BeginContext(503, 406, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "893338eeaa7a4f66b2dabfd0fca33a85", async() => {
                BeginContext(562, 37, true);
                WriteLiteral("\r\n\t\t\t<input type=\"hidden\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 599, "\"", 625, 1);
#line 18 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 607, ViewBag.Item.Name, 607, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(626, 42, true);
                WriteLiteral(" />\r\n\t\t\t<input type=\"hidden\" name=\"imgURL\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 668, "\"", 696, 1);
#line 19 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 676, ViewBag.Item.ImgURL, 676, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(697, 41, true);
                WriteLiteral(" />\r\n\t\t\t<input type=\"hidden\" name=\"price\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 738, "\"", 765, 1);
#line 20 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 746, ViewBag.Item.Price, 746, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(766, 136, true);
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
            BeginContext(909, 166, true);
            WriteLiteral("\r\n\t</div>\r\n\t<div class=\"content-container\">\r\n\t\t<b style=\"font-size: 18px\">Specs:</b>\r\n\t\t<br />\r\n\t\t<table class=\"table table-condensed table-striped table-bordered\">\r\n");
            EndContext();
#line 29 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
             for (int i = 1; i < ViewBag.Item.GetType().GetProperties().Length - 2; i++) {

#line default
#line hidden
            BeginContext(1158, 4, true);
            WriteLiteral("\t\t\t\t");
            EndContext();
            BeginContext(1164, 15, true);
            WriteLiteral("<tr>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1180, 46, false);
#line 31 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
                   Write(ViewBag.Item.GetType().GetProperties()[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(1226, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1243, 70, false);
#line 32 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
                   Write(ViewBag.Item.GetType().GetProperties()[i].GetValue(ViewBag.Item, null));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 11, true);
            WriteLiteral("</td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1326, 7, true);
            WriteLiteral("</tr>\r\n");
            EndContext();
#line 34 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
			}

#line default
#line hidden
            BeginContext(1339, 88, true);
            WriteLiteral("\t\t</table>\r\n\t</div>\r\n\t<a class=\"btn btn-light\" style=\"margin-top:4px; margin-bottom:6px\"");
            EndContext();
            BeginWriteAttribute("href", " href=", 1427, "", 1555, 1);
#line 37 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
WriteAttributeValue("", 1433, String.Format("/comment/post?username={0}&categoryName={1}&itemId={2}", User.Identity.Name, "Processor", ViewBag.Item.Id), 1433, 122, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1555, 29, true);
            WriteLiteral(">Post a comment</a>\r\n\t<div>\r\n");
            EndContext();
#line 39 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
         if (((IQueryable<Comment>)ViewBag.Comments).Any()) {
			foreach (Comment i in ViewBag.Comments) {

#line default
#line hidden
            BeginContext(1687, 104, true);
            WriteLiteral("\t\t\t\t<div class=\"frame\" style=\"min-height:95px\">\r\n\t\t\t\t\t<label style=\"font-size:18px; margin-bottom:-3px\">");
            EndContext();
            BeginContext(1792, 10, false);
#line 42 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
                                                                 Write(i.Username);

#line default
#line hidden
            EndContext();
            BeginContext(1802, 72, true);
            WriteLiteral("</label><br />\r\n\t\t\t\t\t<label style=\"font-size:10px; font-weight:lighter\">");
            EndContext();
            BeginContext(1875, 6, false);
#line 43 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
                                                                  Write(i.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1881, 87, true);
            WriteLiteral("</label><br />\r\n\t\t\t\t\t<label style=\"font-size:14px; font-weight:normal\"><b>Comment: </b>");
            EndContext();
            BeginContext(1969, 6, false);
#line 44 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
                                                                                 Write(i.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1975, 28, true);
            WriteLiteral("</label><br />\r\n\t\t\t\t</div>\r\n");
            EndContext();
#line 46 "D:\Лабы\3 курс\E_Shop\EShop\Views\ItemPages\ProcessorPage.cshtml"
			}
		}

#line default
#line hidden
            BeginContext(2014, 17, true);
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
