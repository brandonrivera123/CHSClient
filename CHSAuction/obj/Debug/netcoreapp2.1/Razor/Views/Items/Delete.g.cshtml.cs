#pragma checksum "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2afaedc8197416716e62ac41e46ed26c5251bed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Delete), @"mvc.1.0.view", @"/Views/Items/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Delete.cshtml", typeof(AspNetCore.Views_Items_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2afaedc8197416716e62ac41e46ed26c5251bed", @"/Views/Items/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e24a37b1c58d539fa0a1722d329e3f686863c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CHSAuction.Models.Items>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(71, 157, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Items</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(229, 44, false);
#line 15 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(273, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(314, 40, false);
#line 18 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(354, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(395, 51, false);
#line 21 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemDescription));

#line default
#line hidden
            EndContext();
            BeginContext(446, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(487, 47, false);
#line 24 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemDescription));

#line default
#line hidden
            EndContext();
            BeginContext(534, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(575, 46, false);
#line 27 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(621, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(662, 42, false);
#line 30 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayFor(model => model.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(704, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(745, 45, false);
#line 33 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemImage));

#line default
#line hidden
            EndContext();
            BeginContext(790, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(831, 41, false);
#line 36 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemImage));

#line default
#line hidden
            EndContext();
            BeginContext(872, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(913, 45, false);
#line 39 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemValue));

#line default
#line hidden
            EndContext();
            BeginContext(958, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(999, 41, false);
#line 42 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ItemValue));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1081, 41, false);
#line 45 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Guest));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1163, 45, false);
#line 48 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Guest.GuestId));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1249, 43, false);
#line 51 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Package));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1333, 49, false);
#line 54 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Package.PackageId));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1416, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fbb27e7856f4ec1a7a6b34833dcfe33", async() => {
                BeginContext(1442, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1451, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "917cf39dc00640b3b76c06bf3ff5dbc4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Items/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ItemId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1491, 82, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n        ");
                EndContext();
                BeginContext(1573, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b8b205596ab4ea0b858ff515ab475f7", async() => {
                    BeginContext(1595, 12, true);
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
                BeginContext(1611, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1623, 8, true);
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
