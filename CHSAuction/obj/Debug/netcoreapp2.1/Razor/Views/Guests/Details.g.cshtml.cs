#pragma checksum "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29e33a708ee743e91e99bbbcdd22709d606102b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guests_Details), @"mvc.1.0.view", @"/Views/Guests/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Guests/Details.cshtml", typeof(AspNetCore.Views_Guests_Details))]
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
#line 1 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/_ViewImports.cshtml"
using CHSAuction;

#line default
#line hidden
#line 2 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/_ViewImports.cshtml"
using CHSAuction.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e33a708ee743e91e99bbbcdd22709d606102b6", @"/Views/Guests/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e24a37b1c58d539fa0a1722d329e3f686863c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Guests_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CHSAuction.Models.Guests>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 112, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Guests</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(186, 50, false);
#line 14 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(236, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(277, 46, false);
#line 17 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(323, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(364, 49, false);
#line 20 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestLastName));

#line default
#line hidden
            EndContext();
            BeginContext(413, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(454, 45, false);
#line 23 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestLastName));

#line default
#line hidden
            EndContext();
            BeginContext(499, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(540, 46, false);
#line 26 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestEmail));

#line default
#line hidden
            EndContext();
            BeginContext(586, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(627, 42, false);
#line 29 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestEmail));

#line default
#line hidden
            EndContext();
            BeginContext(669, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(710, 46, false);
#line 32 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestPhone));

#line default
#line hidden
            EndContext();
            BeginContext(756, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(797, 42, false);
#line 35 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestPhone));

#line default
#line hidden
            EndContext();
            BeginContext(839, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(880, 48, false);
#line 38 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestAddress));

#line default
#line hidden
            EndContext();
            BeginContext(928, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(969, 44, false);
#line 41 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1054, 45, false);
#line 44 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestCity));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1140, 41, false);
#line 47 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestCity));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1222, 46, false);
#line 50 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestState));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1309, 42, false);
#line 53 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestState));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1392, 44, false);
#line 56 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestZip));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1477, 40, false);
#line 59 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestZip));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1558, 48, false);
#line 62 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Organization));

#line default
#line hidden
            EndContext();
            BeginContext(1606, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1647, 61, false);
#line 65 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
       Write(Html.DisplayFor(model => model.Organization.OrganizationName));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1750, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dbd9f3823de4013a62b00aaf3051c52", async() => {
                BeginContext(1801, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Guests/Details.cshtml"
                           WriteLiteral(Model.GuestId);

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
            BeginContext(1809, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1816, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc60e70fa1ab4525a0575451b77e6a83", async() => {
                BeginContext(1838, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1854, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CHSAuction.Models.Guests> Html { get; private set; }
    }
}
#pragma warning restore 1591
