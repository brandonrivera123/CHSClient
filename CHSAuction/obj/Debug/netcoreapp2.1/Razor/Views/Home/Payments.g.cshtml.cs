#pragma checksum "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Home/Payments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "469469e117cc7af8160421370062889fd8976729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Payments), @"mvc.1.0.view", @"/Views/Home/Payments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Payments.cshtml", typeof(AspNetCore.Views_Home_Payments))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469469e117cc7af8160421370062889fd8976729", @"/Views/Home/Payments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e24a37b1c58d539fa0a1722d329e3f686863c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Payments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Home/Payments.cshtml"
  
    ViewBag.Title = "Payments";

#line default
#line hidden
            BeginContext(40, 19, true);
            WriteLiteral("<h2>Payments</h2>\r\n");
            EndContext();
#line 5 "/Users/brandonrivera/Desktop/CHSClient/CHSAuction/Views/Home/Payments.cshtml"
  
    ViewData["Title"] = "Manage Bidders";

#line default
#line hidden
            BeginContext(109, 5746, true);
            WriteLiteral(@"<meta charset=""utf-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<br>
<div class=""jumbotron"">
    <h1>Total: $201.00</h1>
    <p>Break Down</p>
    <!-- <div class=""row"">
           <ul class=""nav nav-pills"">
               <li id=""paidPill""><a href=""#"">Paid <span class=""badge"">3</span></a></li>
               <li id=""notPaidPill""><a href=""#"">Not Paid <span class=""badge"">3</span></a></li>
               <li id=""pendingPill""><a href=""#"">Pending <span class=""badge"">3</span></a></li>
           </ul>
       </div>-->
    <div class=""row"">
        <div class=""col-lg-2 alert alert-dismissible alert-success"" id=""paidTotal"">
            <strong>Paid: 3</strong><br />Total: $50.00
        </div>
        <div class=""col-lg-2 alert alert-dismissible alert-info"" id=""pendingTotal"">
            <strong>Pending: 3</strong><br />Total: $101.00
        </div>
        <div class=""col-lg-2 al");
            WriteLiteral(@"ert alert-dismissible alert-danger"" id=""notPaidTotal"">
            <strong>Not Paid: 3</strong><br />Total: $50.00
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-3"">
        <label class=""control-label"" for=""focusedInput"">Bidder Search</label>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""form-group"">
            <input class=""form-control"" id=""focusedInput"" onkeyup=""myFunction()"" type=""text"" placeholder=""Search"">
        </div>
    </div>
    <div class=""col-lg-1"">
        <div class=""btn-group"">
            <a href=""#"" class=""btn btn-warning dropdown-toggle"" id=""Filter"" data-toggle=""dropdown"">Filter <span class=""caret""></span></a>
            <ul class=""dropdown-menu"" id=""selectedvalue"">
                <li><a href=""#"" id=""PendingApproved"">Paid/Pending Payment</a></li>
                <li><a href=""#"" id=""Approved"">Paid</a></li>
                <li><a href=""#"" id=""Pending"">Pending Payment</a></li>
                <li><a hr");
            WriteLiteral(@"ef=""#"" id=""Disapproved"">Not Paid</a></li>
                <li class=""divider""></li>
                <li><a href=""#"" id=""All"">All</a></li>
            </ul>
        </div>
    </div>
    <div class=""col-lg-1"">
        <a href=""#"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#addModal"">Add</a>
    </div>
</div>
<table class=""table table-striped table-hover "" id=""myTable"">
    <thead>
        <tr>
            <th>#</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Address</th>
            <th>Status</th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        <tr class=""active"">
            <td>1</td>
            <td>Brandon</td>
            <td>Rivera</td>
            <td><a href=""mailto:brandon.rivera2014@gmail.com"" target=""_top"">brandon.rivera2014@gmail.com</a></td>
            <td>1 UNF Dr</td>
            <td>N/A</td>
            <td><a href=""#"" data-toggle=""modal"" data-");
            WriteLiteral(@"target=""#myModal"">Edit</a></td>
            <td><a href=""#"">Delete</a></td>
        </tr>
        <tr class=""active"">
            <td>2</td>
            <td>Noah</td>
            <td>Sterling</td>
            <td><a href=""mailto:noah.sterling@gmail.com"" target=""_top"">noah.sterling@gmail.com</a></td>
            <td>1 UNF Dr</td>
            <td>N/A</td>
            <td><a href=""#"" data-toggle=""modal"" data-target=""#myModal"">Edit</a></td>
            <td><a href=""#"">Delete</a></td>
        </tr>
        <tr class=""info"">
            <td>3</td>
            <td>Camille</td>
            <td>Soliman</td>
            <td><a href=""mailto:camille.soliman@gmail.com"" target=""_top"">camille.soliman@gmail.com</a></td>
            <td>1 UNF Dr</td>
            <td>Pending Payment</td>
            <td><a href=""#"" data-toggle=""modal"" data-target=""#myModal"">Edit</a></td>
            <td><a href=""#"">Delete</a></td>
        </tr>
        <tr class=""success"">
            <td>4</td>
            <td>Alec</t");
            WriteLiteral(@"d>
            <td>Rance</td>
            <td><a href=""mailto:alec.rance@gmail.com"" target=""_top"">alec.rance@gmail.com</a></td>
            <td>1 UNF Dr</td>
            <td>Paid</td>
            <td><a href=""#"" data-toggle=""modal"" data-target=""#myModal"">Edit</a></td>
            <td><a href=""#"">Delete</a></td>
        </tr>
        <tr class=""danger"">
            <td>5</td>
            <td>First</td>
            <td>Last</td>
            <td><a href=""mailto:first.last@gmail.com"" target=""_top"">first.last@gmail.com</a></td>
            <td>1 UNF Dr</td>
            <td>Not Paid</td>
            <td><a href=""#"" data-toggle=""modal"" data-target=""#myModal"">Edit</a></td>
            <td><a href=""#"">Delete</a></td>
        </tr>
        <tr class=""active"">
            <td>7</td>
            <td>First</td>
            <td>Last</td>
            <td><a href=""mailto:first.last@gmail.com"" target=""_top"">first.last@gmail.com</a></td>
            <td>1 UNF Dr</td>
            <td>N/A</td>
          ");
            WriteLiteral(@"  <td><a href=""#"" data-toggle=""modal"" data-target=""#myModal"">Edit</a></td>
            <td><a href=""#"">Delete</a></td>
        </tr>
    </tbody>
</table>
<!-- Modal -->
<div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Update Bidder Form</h4>
            </div>
            <div class=""modal-body"">
                <div>
                    ");
            EndContext();
            BeginContext(5855, 3487, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8090f6907b7848b0a24f633ac7bdf2a5", async() => {
                BeginContext(5885, 2581, true);
                WriteLiteral(@"
                        <fieldset>
                            <legend>Fill Out Form</legend>
                            <div class=""form-group"">
                                <label for=""inputEmail"" class=""col-lg-2 control-label"">Email</label>
                                <div class=""col-lg-10"">
                                    <input type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""Email"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=""inputFirstName"" class=""col-lg-2 control-label"">First Name</label>
                                <div class=""col-lg-10"">
                                    <input type=""password"" class=""form-control"" id=""inputFirstName"" placeholder=""First Name"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=");
                WriteLiteral(@"""inputLastName"" class=""col-lg-2 control-label"">Last Name</label>
                                <div class=""col-lg-10"">
                                    <input type=""password"" class=""form-control"" id=""inputLastName"" placeholder=""Last Name"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=""inputLastName"" class=""col-lg-2 control-label"">Address</label>
                                <div class=""col-lg-10"">
                                    <input type=""password"" class=""form-control"" id=""inputAddress"" placeholder=""Address"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=""textArea"" class=""col-lg-2 control-label"">Comments</label>
                                <div class=""col-lg-10"">
                                    <textarea class=""form-control"" row");
                WriteLiteral(@"s=""3"" id=""textArea""></textarea>
                                    <span class=""help-block"">List any important info.</span>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=""select"" class=""col-lg-2 control-label"">Selects</label>
                                <div class=""col-lg-10"">
                                    <select class=""form-control"" id=""select"">
                                        ");
                EndContext();
                BeginContext(8466, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8175c8f63764aa2834b29a7099bbed7", async() => {
                    BeginContext(8474, 16, true);
                    WriteLiteral("Pending Approval");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8499, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(8541, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60addde09301476c8578dfec8ac311df", async() => {
                    BeginContext(8549, 8, true);
                    WriteLiteral("Approved");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8566, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(8608, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84c3b9b1c7a84ec99d99afc5b664520f", async() => {
                    BeginContext(8616, 11, true);
                    WriteLiteral("Disapproved");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8636, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(8678, 20, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deadb2e0253849e6a7d85f6ef3d08623", async() => {
                    BeginContext(8686, 3, true);
                    WriteLiteral("N/A");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8698, 637, true);
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <br>
                            <div class=""form-group"">
                                <div class=""col-lg-10 col-lg-offset-2"">
                                    <button type=""reset"" data-dismiss=""modal"" class=""btn btn-default"">Cancel</button>
                                    <button type=""submit"" class=""btn btn-primary"">Submit</button>
                                </div>
                            </div>
                        </fieldset>
                    ");
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
            BeginContext(9342, 546, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Modal -->
<div class=""modal fade"" id=""addModal"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Add Bidder Form</h4>
            </div>
            <div class=""modal-body"">
                <div>
                    ");
            EndContext();
            BeginContext(9888, 3487, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "119ba2d16b87452a89ed13c1361fec0a", async() => {
                BeginContext(9918, 2581, true);
                WriteLiteral(@"
                        <fieldset>
                            <legend>Fill Out Form</legend>
                            <div class=""form-group"">
                                <label for=""inputEmail"" class=""col-lg-2 control-label"">Email</label>
                                <div class=""col-lg-10"">
                                    <input type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""Email"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=""inputFirstName"" class=""col-lg-2 control-label"">First Name</label>
                                <div class=""col-lg-10"">
                                    <input type=""password"" class=""form-control"" id=""inputFirstName"" placeholder=""First Name"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=");
                WriteLiteral(@"""inputLastName"" class=""col-lg-2 control-label"">Last Name</label>
                                <div class=""col-lg-10"">
                                    <input type=""password"" class=""form-control"" id=""inputLastName"" placeholder=""Last Name"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=""inputLastName"" class=""col-lg-2 control-label"">Address</label>
                                <div class=""col-lg-10"">
                                    <input type=""password"" class=""form-control"" id=""inputAddress"" placeholder=""Address"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=""textArea"" class=""col-lg-2 control-label"">Comments</label>
                                <div class=""col-lg-10"">
                                    <textarea class=""form-control"" row");
                WriteLiteral(@"s=""3"" id=""textArea""></textarea>
                                    <span class=""help-block"">List any important info.</span>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=""select"" class=""col-lg-2 control-label"">Selects</label>
                                <div class=""col-lg-10"">
                                    <select class=""form-control"" id=""select"">
                                        ");
                EndContext();
                BeginContext(12499, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f27bf26b0e9f459dbb94eca51e08dcf3", async() => {
                    BeginContext(12507, 16, true);
                    WriteLiteral("Pending Approval");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(12532, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(12574, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47320b3255b48908c96484538d90c9e", async() => {
                    BeginContext(12582, 8, true);
                    WriteLiteral("Approved");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(12599, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(12641, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2971c47977374693aa521c395d699ddb", async() => {
                    BeginContext(12649, 11, true);
                    WriteLiteral("Disapproved");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(12669, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(12711, 20, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2cc8af8d35343f4a8c8a452b2f7b403", async() => {
                    BeginContext(12719, 3, true);
                    WriteLiteral("N/A");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(12731, 637, true);
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <br>
                            <div class=""form-group"">
                                <div class=""col-lg-10 col-lg-offset-2"">
                                    <button type=""reset"" data-dismiss=""modal"" class=""btn btn-default"">Cancel</button>
                                    <button type=""submit"" class=""btn btn-primary"">Submit</button>
                                </div>
                            </div>
                        </fieldset>
                    ");
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
            BeginContext(13375, 2679, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<script>
function myFunction() {
        var input, filter, table, tr, td, i;
        input = document.getElementById(""focusedInput"");
        filter = input.value.toUpperCase();
        table = document.getElementById(""myTable"");
        tr = table.getElementsByTagName(""tr"");
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName(""td"")[1];
            if (td) {
                if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = """";
                } else {
                    tr[i].style.display = ""none"";
                }
            }
        }
    }

    $(document).ready(function(){
        $(""#PendingApproved"").click(function(){
            $("".warning"").hide();
            $("".active"").hide();
            $("".danger"").hide();
            $("".info"").show();
            $("".success"").show();
        });
        $(""#Approve");
            WriteLiteral(@"d"").click(function(){
            $("".warning"").hide();
            $("".active"").hide();
            $("".danger"").hide();
            $("".info"").hide();
            $("".success"").show();
        });
        $(""#Pending"").click(function(){
            $("".warning"").hide();
            $("".active"").hide();
            $("".danger"").hide();
            $("".info"").show();
            $("".success"").hide();
        });
        $(""#Disapproved"").click(function(){
            $("".warning"").hide();
            $("".active"").hide();
            $("".danger"").show();
            $("".info"").hide();
            $("".success"").hide();
        });
        $(""#Inactive"").click(function(){
            $("".warning"").show();
            $("".active"").hide();
            $("".danger"").hide();
            $("".info"").hide();
            $("".success"").hide();
        });
        $(""#All"").click(function(){
            $("".warning"").show();
            $("".active"").show();
            $("".danger"").show();
 ");
            WriteLiteral(@"           $("".info"").show();
            $("".success"").show();
        });
        $(""#pendingPill"").click(function () {
            $(""#paidTotal"").hide();
            $(""#notPaidTotal"").hide();
            $(""#pendingTotal"").show();
        });
        $(""#paidPill"").click(function () {
            $(""#paidTotal"").show();
            $(""#notPaidTotal"").hide();
            $(""#pendingTotal"").hide();
        });
        $(""#notPaidPill"").click(function () {
            $(""#paidTotal"").hide();
            $(""#notPaidTotal"").show();
            $(""#pendingTotal"").hide();
        });
    });
    </script>
");
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
