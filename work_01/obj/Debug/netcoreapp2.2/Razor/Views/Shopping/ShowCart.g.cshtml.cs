#pragma checksum "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e000128157a9d213ca2d31d1eaad76d8626eb0db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shopping_ShowCart), @"mvc.1.0.view", @"/Views/Shopping/ShowCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shopping/ShowCart.cshtml", typeof(AspNetCore.Views_Shopping_ShowCart))]
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
#line 1 "I:\.NET Practice\Project\work_01\Views\_ViewImports.cshtml"
using work_01;

#line default
#line hidden
#line 2 "I:\.NET Practice\Project\work_01\Views\_ViewImports.cshtml"
using work_01.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e000128157a9d213ca2d31d1eaad76d8626eb0db", @"/Views/Shopping/ShowCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bff49a12a178b6e69a33afd67df073c05760467", @"/Views/_ViewImports.cshtml")]
    public class Views_Shopping_ShowCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<work_01.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CartStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shopping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark mb-1 btn1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-lg mt-1 mb-3 btn1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
  
    ViewData["Title"] = "ShowCart";
    double subtotal = 0;
    double total = 0;
    int sl = 1;

#line default
#line hidden
            BeginContext(156, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(164, 475, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e000128157a9d213ca2d31d1eaad76d8626eb0db7317", async() => {
                BeginContext(170, 408, true);
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">

    ");
                EndContext();
                BeginContext(578, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e000128157a9d213ca2d31d1eaad76d8626eb0db8119", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(630, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(639, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(641, 7512, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e000128157a9d213ca2d31d1eaad76d8626eb0db10248", async() => {
                BeginContext(647, 57, true);
                WriteLiteral("\r\n    <h1 class=\"mb-5 text-center\">Shopping Cart</h1>\r\n\r\n");
                EndContext();
#line 26 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
     if (Model != null)
    {

#line default
#line hidden
                BeginContext(736, 289, true);
                WriteLiteral(@"        <div class=""container"">
            <div class=""row "">
                <div class=""col-md-8"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>
                                    ");
                EndContext();
                BeginContext(1026, 41, false);
#line 35 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                               Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
                EndContext();
                BeginContext(1067, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1183, 40, false);
#line 38 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1223, 117, true);
                WriteLiteral("\r\n                                </th>\r\n\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1341, 41, false);
#line 42 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1382, 115, true);
                WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
                EndContext();
                BeginContext(1498, 44, false);
#line 45 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(1542, 390, true);
                WriteLiteral(@"
                                </th>
                                <th>
                                    Sub Total
                                </th>
                                <th>
                                    Action
                                </th>

                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 57 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
                BeginContext(2021, 80, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n");
                EndContext();
#line 61 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                          
                                            var b64 = Convert.ToBase64String(item.Image);
                                            var imageSource = String.Format("data:image/jpg;base64,{0}", b64);
                                        

#line default
#line hidden
                BeginContext(2391, 44, true);
                WriteLiteral("                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2435, "\"", 2453, 1);
#line 65 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
WriteAttributeValue("", 2441, imageSource, 2441, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2454, 170, true);
                WriteLiteral(" alt=\"Product Image\" style=\"width:150px\" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2625, 39, false);
#line 68 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2664, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2792, 40, false);
#line 71 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(2832, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2960, 43, false);
#line 74 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(3003, 87, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
                EndContext();
#line 77 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                          
                                            subtotal = item.Price * item.Quantity;
                                            total += subtotal;
                                        

#line default
#line hidden
                BeginContext(3325, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(3366, 8, false);
#line 81 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                   Write(subtotal);

#line default
#line hidden
                EndContext();
                BeginContext(3374, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(3501, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e000128157a9d213ca2d31d1eaad76d8626eb0db17549", async() => {
                    BeginContext(3579, 6, true);
                    WriteLiteral("Remove");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 84 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                                                                                WriteLiteral(item.Id);

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
                BeginContext(3589, 86, true);
                WriteLiteral("\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 88 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                sl++;
                            }

#line default
#line hidden
                BeginContext(3745, 140, true);
                WriteLiteral("                            <tr>\r\n                                <td colspan=\"7\"><b>Total</b></td>\r\n                                <td><b>");
                EndContext();
                BeginContext(3886, 5, false);
#line 92 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                  Write(total);

#line default
#line hidden
                EndContext();
                BeginContext(3891, 395, true);
                WriteLiteral(@"</b></td>
                            </tr>
                        </tbody>
                    </table>
                </div>

                <div class=""col-md-4 border align-text-bottom"" id=""cartcal"">
                    <h4 class=""text-lg-left px-1 py-2 border-bottom""><b>Total</b></h4>
                    <div class=""py-5"">
                        <h5>Your total amount is: <b>");
                EndContext();
                BeginContext(4287, 5, false);
#line 101 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                                                Write(total);

#line default
#line hidden
                EndContext();
                BeginContext(4292, 95, true);
                WriteLiteral("</b> Taka</h5>\r\n                    </div>\r\n                    <div>\r\n                        ");
                EndContext();
                BeginContext(4387, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e000128157a9d213ca2d31d1eaad76d8626eb0db21870", async() => {
                    BeginContext(4466, 19, true);
                    WriteLiteral("Continuing Shopping");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4489, 81, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        ");
                EndContext();
                BeginContext(4570, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e000128157a9d213ca2d31d1eaad76d8626eb0db23731", async() => {
                    BeginContext(4664, 9, true);
                    WriteLiteral("Check Out");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4677, 90, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 182 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
                    
    }
    else
    {

#line default
#line hidden
                BeginContext(7823, 215, true);
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-10\">\r\n                <h4 class=\"text-danger text-center\">sorry ! You have no item in your cart</h4>\r\n            </div>\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(8038, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e000128157a9d213ca2d31d1eaad76d8626eb0db26092", async() => {
                    BeginContext(8089, 8, true);
                    WriteLiteral("Shop Now");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8101, 38, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 194 "I:\.NET Practice\Project\work_01\Views\Shopping\ShowCart.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8153, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<work_01.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
