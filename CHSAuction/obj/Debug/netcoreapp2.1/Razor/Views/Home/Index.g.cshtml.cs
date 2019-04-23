#pragma checksum "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ea6e19e250877983fe818d33e4fa030e5f4e87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Noah\CHSClient\CHSAuction\Views\_ViewImports.cshtml"
using CHSAuction;

#line default
#line hidden
#line 2 "C:\Users\Noah\CHSClient\CHSAuction\Views\_ViewImports.cshtml"
using CHSAuction.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ea6e19e250877983fe818d33e4fa030e5f4e87", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e24a37b1c58d539fa0a1722d329e3f686863c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CHSAuction.Models.Events>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(89, 61, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h2>CHS Auction Dashboard</h2>\r\n");
            EndContext();
            BeginContext(515, 101, true);
            WriteLiteral("</div>\r\n<div>\r\n    <hr />\r\n    <h2>List of Upcoming Events:</h2>\r\n    <hr />\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 20 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#line 22 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
             if (DateTime.Today.Month < 7)
            {
                

#line default
#line hidden
#line 24 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                 if (item.EventStart.Month < 7)
                {
                    

#line default
#line hidden
#line 26 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                     if (DateTime.Today.Year == item.EventStart.Year)
                    {

#line default
#line hidden
            BeginContext(886, 220, true);
            WriteLiteral("                        <div id=\"eventCard\" class=\"col-sm-6 col-md-4\">\r\n                            <div class=\"thumbnail\">\r\n                                <div class=\"caption\">\r\n                                    <h3>");
            EndContext();
            BeginContext(1107, 40, false);
#line 31 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(model => item.EventName));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 56, true);
            WriteLiteral("</h3>\r\n                                    <p>Location: ");
            EndContext();
            BeginContext(1204, 44, false);
#line 32 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(model => item.EventLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 59, true);
            WriteLiteral("</p>\r\n                                    <p># of Tickets: ");
            EndContext();
            BeginContext(1308, 45, false);
#line 33 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                                Write(Html.DisplayFor(model => item.EventTicketNum));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 57, true);
            WriteLiteral("</p>\r\n                                    <p>Start Time: ");
            EndContext();
            BeginContext(1411, 41, false);
#line 34 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                              Write(Html.DisplayFor(model => item.EventStart));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 42, true);
            WriteLiteral("</p>\r\n                                    ");
            EndContext();
            BeginContext(1494, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30e7b970499e480fa3259f52251da449", async() => {
                BeginContext(1595, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                                                                                              WriteLiteral(item.EventId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1606, 110, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 39 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#line 39 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                     
                }
                else
                {
                    

#line default
#line hidden
#line 43 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                     if (DateTime.Today.AddYears(-1).Year == item.EventStart.Year)
                    {

#line default
#line hidden
            BeginContext(1906, 220, true);
            WriteLiteral("                        <div id=\"eventCard\" class=\"col-sm-6 col-md-4\">\r\n                            <div class=\"thumbnail\">\r\n                                <div class=\"caption\">\r\n                                    <h3>");
            EndContext();
            BeginContext(2127, 40, false);
#line 48 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(model => item.EventName));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 56, true);
            WriteLiteral("</h3>\r\n                                    <p>Location: ");
            EndContext();
            BeginContext(2224, 44, false);
#line 49 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(model => item.EventLocation));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 59, true);
            WriteLiteral("</p>\r\n                                    <p># of Tickets: ");
            EndContext();
            BeginContext(2328, 45, false);
#line 50 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                                Write(Html.DisplayFor(model => item.EventTicketNum));

#line default
#line hidden
            EndContext();
            BeginContext(2373, 57, true);
            WriteLiteral("</p>\r\n                                    <p>Start Time: ");
            EndContext();
            BeginContext(2431, 41, false);
#line 51 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                              Write(Html.DisplayFor(model => item.EventStart));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 42, true);
            WriteLiteral("</p>\r\n                                    ");
            EndContext();
            BeginContext(2514, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c32d211d1e984985bed52cc069ab470f", async() => {
                BeginContext(2615, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                                                                                              WriteLiteral(item.EventId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2626, 110, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 56 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#line 56 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#line 57 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                 
            }
            else
            {
                

#line default
#line hidden
#line 61 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                 if (item.EventStart.Month < 7)
                {
                    

#line default
#line hidden
#line 63 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                     if (DateTime.Today.AddYears(1).Year == item.EventStart.Year)
                    {

#line default
#line hidden
            BeginContext(3000, 220, true);
            WriteLiteral("                        <div id=\"eventCard\" class=\"col-sm-6 col-md-4\">\r\n                            <div class=\"thumbnail\">\r\n                                <div class=\"caption\">\r\n                                    <h3>");
            EndContext();
            BeginContext(3221, 40, false);
#line 68 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(model => item.EventName));

#line default
#line hidden
            EndContext();
            BeginContext(3261, 56, true);
            WriteLiteral("</h3>\r\n                                    <p>Location: ");
            EndContext();
            BeginContext(3318, 44, false);
#line 69 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(model => item.EventLocation));

#line default
#line hidden
            EndContext();
            BeginContext(3362, 59, true);
            WriteLiteral("</p>\r\n                                    <p># of Tickets: ");
            EndContext();
            BeginContext(3422, 45, false);
#line 70 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                                Write(Html.DisplayFor(model => item.EventTicketNum));

#line default
#line hidden
            EndContext();
            BeginContext(3467, 57, true);
            WriteLiteral("</p>\r\n                                    <p>Start Time: ");
            EndContext();
            BeginContext(3525, 41, false);
#line 71 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                              Write(Html.DisplayFor(model => item.EventStart));

#line default
#line hidden
            EndContext();
            BeginContext(3566, 42, true);
            WriteLiteral("</p>\r\n                                    ");
            EndContext();
            BeginContext(3608, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6335025c90374731af154e5f941bc2c5", async() => {
                BeginContext(3709, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                                                                                              WriteLiteral(item.EventId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3720, 110, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 76 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#line 76 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                     
                }
                else
                {
                    

#line default
#line hidden
#line 80 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                     if (DateTime.Today.Year == item.EventStart.Year)
                    {

#line default
#line hidden
            BeginContext(4007, 220, true);
            WriteLiteral("                        <div id=\"eventCard\" class=\"col-sm-6 col-md-4\">\r\n                            <div class=\"thumbnail\">\r\n                                <div class=\"caption\">\r\n                                    <h3>");
            EndContext();
            BeginContext(4228, 40, false);
#line 85 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(model => item.EventName));

#line default
#line hidden
            EndContext();
            BeginContext(4268, 56, true);
            WriteLiteral("</h3>\r\n                                    <p>Location: ");
            EndContext();
            BeginContext(4325, 44, false);
#line 86 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(model => item.EventLocation));

#line default
#line hidden
            EndContext();
            BeginContext(4369, 59, true);
            WriteLiteral("</p>\r\n                                    <p># of Tickets: ");
            EndContext();
            BeginContext(4429, 45, false);
#line 87 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                                Write(Html.DisplayFor(model => item.EventTicketNum));

#line default
#line hidden
            EndContext();
            BeginContext(4474, 57, true);
            WriteLiteral("</p>\r\n                                    <p>Start Time: ");
            EndContext();
            BeginContext(4532, 41, false);
#line 88 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                              Write(Html.DisplayFor(model => item.EventStart));

#line default
#line hidden
            EndContext();
            BeginContext(4573, 42, true);
            WriteLiteral("</p>\r\n                                    ");
            EndContext();
            BeginContext(4615, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0040463d3ee04ef2bfb9e152a44afc59", async() => {
                BeginContext(4716, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                                                                                                              WriteLiteral(item.EventId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4727, 110, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 93 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#line 93 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#line 94 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#line 95 "C:\Users\Noah\CHSClient\CHSAuction\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(4905, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CHSAuction.Models.Events>> Html { get; private set; }
    }
}
#pragma warning restore 1591
