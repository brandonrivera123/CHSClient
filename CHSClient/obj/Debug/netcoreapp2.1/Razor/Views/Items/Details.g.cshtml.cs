#pragma checksum "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e85f895ab836f676c10723f936f55efbbd6d57e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Details), @"mvc.1.0.view", @"/Views/Items/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Details.cshtml", typeof(AspNetCore.Views_Items_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e85f895ab836f676c10723f936f55efbbd6d57e4", @"/Views/Items/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e24a37b1c58d539fa0a1722d329e3f686863c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CHSAuction.Models.Items>
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
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(72, 111, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Items</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(184, 44, false);
#line 14 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(228, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(269, 40, false);
#line 17 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(309, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(350, 51, false);
#line 20 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemDescription));

#line default
#line hidden
            EndContext();
            BeginContext(401, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(442, 47, false);
#line 23 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemDescription));

#line default
#line hidden
            EndContext();
            BeginContext(489, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(530, 46, false);
#line 26 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(576, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(617, 42, false);
#line 29 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(659, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(700, 45, false);
#line 32 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemImage));

#line default
#line hidden
            EndContext();
            BeginContext(745, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(786, 41, false);
#line 35 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemImage));

#line default
#line hidden
            EndContext();
            BeginContext(827, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(868, 45, false);
#line 38 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemValue));

#line default
#line hidden
            EndContext();
            BeginContext(913, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(954, 41, false);
#line 41 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemValue));

#line default
#line hidden
            EndContext();
            BeginContext(995, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1036, 41, false);
#line 44 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Guest));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1118, 45, false);
#line 47 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayFor(model => model.Guest.GuestId));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1204, 43, false);
#line 50 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Package));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1288, 49, false);
#line 53 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
       Write(Html.DisplayFor(model => model.Package.PackageId));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1379, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1597385b1ee542bbb3405c7cd8e8df41", async() => {
                BeginContext(1429, 4, true);
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
#line 58 "/Users/brandonrivera/Desktop/Test-Auth 2/CHSAuction/Views/Items/Details.cshtml"
                           WriteLiteral(Model.ItemId);

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
            BeginContext(1437, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1444, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333850f0f5cf4d76baf11192c083d5a5", async() => {
                BeginContext(1466, 12, true);
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
            BeginContext(1482, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CHSAuction.Models.Items> Html { get; private set; }
    }
}
#pragma warning restore 1591
