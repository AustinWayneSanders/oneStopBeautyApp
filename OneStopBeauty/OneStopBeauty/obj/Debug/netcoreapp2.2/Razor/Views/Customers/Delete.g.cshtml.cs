#pragma checksum "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22cee7f5df2bb9c35883568ebf93ac198d7a3e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Delete), @"mvc.1.0.view", @"/Views/Customers/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Delete.cshtml", typeof(AspNetCore.Views_Customers_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cee7f5df2bb9c35883568ebf93ac198d7a3e0c", @"/Views/Customers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f09936910ba1c8bd77251604511233c28c7647c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneStopBeauty.Models.Customer>
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
#line 4 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(171, 232, true);
            WriteLiteral("\r\n<h1 style=\"color:mediumvioletred\">Delete</h1>\r\n\r\n\r\n\r\n<div style=\"background-color: white\">\r\n    <h4>Are you sure you want to delete this customer?</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(404, 45, false);
#line 18 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(449, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(511, 41, false);
#line 21 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(552, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(613, 44, false);
#line 24 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(657, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(719, 40, false);
#line 27 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(759, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(820, 39, false);
#line 30 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(859, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(921, 35, false);
#line 33 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(956, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1017, 42, false);
#line 36 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1121, 38, false);
#line 39 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1220, 45, false);
#line 42 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ethnicity));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1327, 41, false);
#line 45 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ethnicity));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1429, 46, false);
#line 48 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hair_Color));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1537, 42, false);
#line 51 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hair_Color));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1640, 46, false);
#line 54 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Skin_Color));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1748, 42, false);
#line 57 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Skin_Color));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1851, 45, false);
#line 60 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Eye_Color));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1958, 41, false);
#line 63 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Eye_Color));

#line default
#line hidden
            EndContext();
            BeginContext(1999, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2060, 41, false);
#line 66 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2101, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2163, 37, false);
#line 69 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2200, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2261, 50, false);
#line 72 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Street_Address));

#line default
#line hidden
            EndContext();
            BeginContext(2311, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2373, 46, false);
#line 75 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Street_Address));

#line default
#line hidden
            EndContext();
            BeginContext(2419, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2480, 40, false);
#line 78 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(2520, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2582, 36, false);
#line 81 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(2618, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2679, 41, false);
#line 84 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(2720, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2782, 37, false);
#line 87 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(2819, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2880, 44, false);
#line 90 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Zip_Code));

#line default
#line hidden
            EndContext();
            BeginContext(2924, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2986, 40, false);
#line 93 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Zip_Code));

#line default
#line hidden
            EndContext();
            BeginContext(3026, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(3060, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22cee7f5df2bb9c35883568ebf93ac198d7a3e0c16606", async() => {
                BeginContext(3086, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3096, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cee7f5df2bb9c35883568ebf93ac198d7a3e0c16999", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 98 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Customers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(3132, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3215, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22cee7f5df2bb9c35883568ebf93ac198d7a3e0c18920", async() => {
                    BeginContext(3237, 12, true);
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
                BeginContext(3253, 6, true);
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
            BeginContext(3266, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneStopBeauty.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
