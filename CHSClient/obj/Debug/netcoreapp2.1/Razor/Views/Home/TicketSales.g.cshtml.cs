#pragma checksum "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Home/TicketSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "069c67e4609bec4a420c41de355f3b71ea8b983c"
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
#line 1 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/_ViewImports.cshtml"
using CHSAuction;

#line default
#line hidden
#line 2 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/_ViewImports.cshtml"
using CHSAuction.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069c67e4609bec4a420c41de355f3b71ea8b983c", @"/Views/Home/TicketSales.cshtml")]
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
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Home/TicketSales.cshtml"
  
    ViewData["Title"] = "TicketSales";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 7 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Home/TicketSales.cshtml"
  
    ViewBag.Title = "Ticket Sales";

#line default
#line hidden
            BeginContext(88, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(93, 13, false);
#line 10 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Home/TicketSales.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(106, 6, true);
            WriteLiteral("</h2>\n");
            EndContext();
            BeginContext(112, 2201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "120bbc2d27eb4f1989af0f659392c4e5", async() => {
                BeginContext(142, 2164, true);
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

            <label class=""col-lg-2 control-label"" for=""phone"">Phone Number (optional)</label>
            <div class=""col");
                WriteLiteral(@"-lg-10"">
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
                <button class=""btn btn-default"" type=""reset"">Cancel</button>
            ");
                WriteLiteral("    <button class=\"btn btn-primary\" type=\"submit\">Submit</button>\n            </div>\n        </div>\n    </fieldset>\n");
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
            BeginContext(2313, 1, true);
            WriteLiteral("\n");
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
