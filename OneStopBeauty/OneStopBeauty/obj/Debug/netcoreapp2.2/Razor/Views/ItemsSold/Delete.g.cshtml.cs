#pragma checksum "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d0459709af1f3aaa8ff43ed046c4b25e9c1ca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemsSold_Delete), @"mvc.1.0.view", @"/Views/ItemsSold/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ItemsSold/Delete.cshtml", typeof(AspNetCore.Views_ItemsSold_Delete))]
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
#line 1 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\_ViewImports.cshtml"
using OneStopBeauty.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\_ViewImports.cshtml"
using OneStopBeauty.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d0459709af1f3aaa8ff43ed046c4b25e9c1ca2", @"/Views/ItemsSold/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f09936910ba1c8bd77251604511233c28c7647c0", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemsSold_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneStopBeauty.Models.ItemSold>
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(171, 229, true);
            WriteLiteral("\r\n<h1 style=\"color:mediumvioletred\">Delete</h1>\r\n\r\n<div style=\"background-color: white\">\r\n    <h4>Are you sure you want to delete this item sold?</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(401, 52, false);
#line 16 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BillingStatement));

#line default
#line hidden
            EndContext();
            BeginContext(453, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(515, 67, false);
#line 19 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BillingStatement.BillingStatementID));

#line default
#line hidden
            EndContext();
            BeginContext(582, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(643, 45, false);
#line 22 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventory));

#line default
#line hidden
            EndContext();
            BeginContext(688, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(750, 53, false);
#line 25 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Inventory.InventoryID));

#line default
#line hidden
            EndContext();
            BeginContext(803, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(864, 44, false);
#line 28 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Services));

#line default
#line hidden
            EndContext();
            BeginContext(908, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(970, 50, false);
#line 31 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Services.ServiceID));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1081, 42, false);
#line 34 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Online));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1185, 38, false);
#line 37 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Online));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1284, 44, false);
#line 40 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1390, 51, false);
#line 43 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Location.LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1502, 58, false);
#line 46 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Shipped_Date_Sold_Item));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1622, 54, false);
#line 49 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Shipped_Date_Sold_Item));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1737, 58, false);
#line 52 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Arrived_Date_Sold_Item));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1857, 54, false);
#line 55 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Arrived_Date_Sold_Item));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1972, 45, false);
#line 58 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ext_Price));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2079, 41, false);
#line 61 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ext_Price));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2181, 44, false);
#line 64 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2225, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2287, 40, false);
#line 67 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2327, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2388, 44, false);
#line 70 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(2432, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2494, 40, false);
#line 73 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(2534, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(2568, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d0459709af1f3aaa8ff43ed046c4b25e9c1ca214107", async() => {
                BeginContext(2594, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2604, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65d0459709af1f3aaa8ff43ed046c4b25e9c1ca214500", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 78 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\ItemsSold\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ItemSoldID);

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
                BeginContext(2648, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2731, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d0459709af1f3aaa8ff43ed046c4b25e9c1ca216429", async() => {
                    BeginContext(2753, 12, true);
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
                BeginContext(2769, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(2782, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneStopBeauty.Models.ItemSold> Html { get; private set; }
    }
}
#pragma warning restore 1591
