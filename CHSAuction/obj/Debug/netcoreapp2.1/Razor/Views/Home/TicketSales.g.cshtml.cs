#pragma checksum "C:\Users\n01069219\CHSClient\CHSAuction\Views\Home\TicketSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124b094b414227842899e3b4e9153ae73c7b4730"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TicketSales), @"mvc.1.0.view", @"/Views/Home/TicketSales.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TicketSales.cshtml", typeof(AspNetCore.Views_Home_TicketSales))]
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
#line 1 "C:\Users\n01069219\CHSClient\CHSAuction\Views\_ViewImports.cshtml"
using CHSAuction;

#line default
#line hidden
#line 2 "C:\Users\n01069219\CHSClient\CHSAuction\Views\_ViewImports.cshtml"
using CHSAuction.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124b094b414227842899e3b4e9153ae73c7b4730", @"/Views/Home/TicketSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e24a37b1c58d539fa0a1722d329e3f686863c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TicketSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\n01069219\CHSClient\CHSAuction\Views\Home\TicketSales.cshtml"
  
    ViewData["Title"] = "TicketSales";

#line default
#line hidden
            BeginContext(49, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\n01069219\CHSClient\CHSAuction\Views\Home\TicketSales.cshtml"
  
    ViewBag.Title = "Ticket Sales";

#line default
#line hidden
            BeginContext(97, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(102, 13, false);
#line 10 "C:\Users\n01069219\CHSClient\CHSAuction\Views\Home\TicketSales.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(115, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(122, 2261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "344b53defc344bc4866cfab64f52bb24", async() => {
                BeginContext(152, 2224, true);
                WriteLiteral(@"
    <fieldset>
        <hr />
        <h3> Guest Information</h3>
        <div class=""form-group"">
            <label class=""col-lg-2 control-label"">First Name</label>
            <div class=""col-lg-10"">
                <input class=""form-control"" id=""inputFirstName"" placeholder=""First Name"">
            </div>
        </div>

        <div class=""form-group"">
            <label class=""col-lg-2 control-label"">Last Name</label>
            <div class=""col-lg-10"">
                <input class=""form-control"" id=""inputLastName"" placeholder=""Last Name"">
            </div>
        </div>

        <div class=""form-group"">
            <label class=""col-lg-2 control-label"" for=""inputEmail"">Email</label>
            <div class=""col-lg-10"">
                <input class=""form-control"" id=""inputEmail"" type=""email"" placeholder=""Email"">
            </div>
        </div>

        <div class=""form-group"">

            <label class=""col-lg-2 control-label"" for=""phone"">Phone Number (optional)</label>");
                WriteLiteral(@"
            <div class=""col-lg-10"">
                <input class=""form-control"" id=""inputPhone"" type=""tel"" placeholder=""Phone Number"">
            </div>
        </div>

        <h3> Tickets Information </h3>

        <div class=""form-group"">

            <label class=""col-lg-2 control-label"" for=""numberOfTickets"">Number of Tickets</label>
            <div class=""col-lg-10"">
                <input class=""form-control"" id=""numberOfTickets"" name=""numberOfTickets"" type=""number"" min=""1"" max=""10"" placeholder=""Number of Tickets"">
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-lg-10 col-lg-offset-2"" >
                <header>
                    <h4 style=""display:inline"">Total Price:</h4> <span style=""float: none; color: orangered""> $##.## </span>
                </header>
            </div> 
            
        </div>


        <div class=""form-group"">
            <div class=""col-lg-10 col-lg-offset-2"">
                <button class=""btn");
                WriteLiteral(" btn-default\" type=\"reset\">Cancel</button>\r\n                <button class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n            </div>\r\n        </div>\r\n    </fieldset>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2383, 2, true);
            WriteLiteral("\r\n");
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
