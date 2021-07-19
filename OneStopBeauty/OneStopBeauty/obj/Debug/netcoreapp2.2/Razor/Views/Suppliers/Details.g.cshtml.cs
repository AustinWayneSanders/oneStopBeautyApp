#pragma checksum "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b255220f4898f9e1654fd38a671264b21c598ba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Suppliers_Details), @"mvc.1.0.view", @"/Views/Suppliers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Suppliers/Details.cshtml", typeof(AspNetCore.Views_Suppliers_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b255220f4898f9e1654fd38a671264b21c598ba5", @"/Views/Suppliers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f09936910ba1c8bd77251604511233c28c7647c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Suppliers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneStopBeauty.Models.Supplier>
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(172, 123, true);
            WriteLiteral("\r\n<script>\r\n\r\n    function getInventory(supplierID)\r\n    {\r\n        $.ajax({\r\n            type: \"POST\",\r\n            url: \"");
            EndContext();
            BeginContext(296, 39, false);
#line 15 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
             Write(Url.Action("GetInventory", "Suppliers"));

#line default
#line hidden
            EndContext();
            BeginContext(335, 707, true);
            WriteLiteral(@""",
            data: { id: supplierID },
            success: function (pvHtlmResult)
            {
                $(""#pvInventory"").html(pvHtlmResult);
            }, // the success attribute will call a javascript function that will
            //find the div tag and set the html element equal to the partial view

            error: function ()
            {
                alert(""No Inventory found for this Supplier"" + supplierID)
            }

        });
    }


</script>


<h1 style=""color:mediumvioletred; font:bold"">Details</h1>

<div style=""background-color: white;"">
    <h4>Supplier</h4>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
            EndContext();
            BeginContext(1043, 40, false);
#line 42 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1145, 36, false);
#line 45 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1242, 50, false);
#line 48 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Street_Address));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1354, 46, false);
#line 51 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Street_Address));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1461, 40, false);
#line 54 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1563, 36, false);
#line 57 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1660, 41, false);
#line 60 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1763, 37, false);
#line 63 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1800, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1861, 44, false);
#line 66 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Zip_Code));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1967, 40, false);
#line 69 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Zip_Code));

#line default
#line hidden
            EndContext();
            BeginContext(2007, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2054, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b255220f4898f9e1654fd38a671264b21c598ba59913", async() => {
                BeginContext(2108, 4, true);
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
#line 74 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
                           WriteLiteral(Model.SupplierID);

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
            BeginContext(2116, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2124, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b255220f4898f9e1654fd38a671264b21c598ba512258", async() => {
                BeginContext(2146, 12, true);
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
            BeginContext(2162, 37, true);
            WriteLiteral(" |\r\n    <button id=\"btnViewInventory\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2199, "\"", 2240, 3);
            WriteAttributeValue("", 2209, "getInventory(", 2209, 13, true);
#line 76 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\Suppliers\Details.cshtml"
WriteAttributeValue("", 2222, Model.SupplierID, 2222, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 2239, ")", 2239, 1, true);
            EndWriteAttribute();
            BeginContext(2241, 115, true);
            WriteLiteral(" class=\"btn btn-default\">View Inventory from this Supplier</button>\r\n</div>\r\n\r\n\r\n<div id=\"pvInventory\">\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneStopBeauty.Models.Supplier> Html { get; private set; }
    }
}
#pragma warning restore 1591
