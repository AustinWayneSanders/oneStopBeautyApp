#pragma checksum "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bd2b201b910c68cad6791e6b89dd1f1d9388653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BillingStatements_Details), @"mvc.1.0.view", @"/Views/BillingStatements/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BillingStatements/Details.cshtml", typeof(AspNetCore.Views_BillingStatements_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd2b201b910c68cad6791e6b89dd1f1d9388653", @"/Views/BillingStatements/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f09936910ba1c8bd77251604511233c28c7647c0", @"/Views/_ViewImports.cshtml")]
    public class Views_BillingStatements_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneStopBeauty.Models.BillingStatement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(180, 133, true);
            WriteLiteral("\r\n\r\n<script>\r\n\r\n    function getItemsSold(billingStatementID)\r\n    {\r\n        $.ajax({\r\n            type: \"POST\",\r\n            url: \"");
            EndContext();
            BeginContext(314, 47, false);
#line 16 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
             Write(Url.Action("getItemsSold", "BillingStatements"));

#line default
#line hidden
            EndContext();
            BeginContext(361, 742, true);
            WriteLiteral(@""",
            data: { id: billingStatementID },
            success: function (pvHtlmResult)
            {
                $(""#pvItemsSold"").html(pvHtlmResult);
            }, // the success attribute will call a javascript function that will
            //find the div tag and set the html element equal to the partial view

            error: function ()
            {
                alert(""No Items Sold Found for this Billing Statement"" + billingStatementID)
            }

        });
    }


</script>


<h1 style=""color:mediumvioletred; font:bold"">Details</h1>

<div style=""background-color: white;"">
    <h4>Billing Statement</h4>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
            EndContext();
            BeginContext(1104, 54, false);
#line 43 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BillingStatementID));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1220, 50, false);
#line 46 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayFor(model => model.BillingStatementID));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1331, 44, false);
#line 49 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1437, 49, false);
#line 52 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1501, 50, false);
#line 53 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1612, 44, false);
#line 56 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(1656, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1718, 49, false);
#line 59 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1782, 50, false);
#line 60 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1893, 48, false);
#line 63 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Invoice_Date));

#line default
#line hidden
            EndContext();
            BeginContext(1941, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2003, 44, false);
#line 66 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Invoice_Date));

#line default
#line hidden
            EndContext();
            BeginContext(2047, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2108, 47, false);
#line 69 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total_Price));

#line default
#line hidden
            EndContext();
            BeginContext(2155, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2217, 43, false);
#line 72 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Total_Price));

#line default
#line hidden
            EndContext();
            BeginContext(2260, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2321, 41, false);
#line 75 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Taxes));

#line default
#line hidden
            EndContext();
            BeginContext(2362, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2424, 37, false);
#line 78 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Taxes));

#line default
#line hidden
            EndContext();
            BeginContext(2461, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(2495, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd2b201b910c68cad6791e6b89dd1f1d938865312221", async() => {
                BeginContext(2581, 4, true);
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
#line 82 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
                           WriteLiteral(Model.BillingStatementID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2589, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2597, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd2b201b910c68cad6791e6b89dd1f1d938865314666", async() => {
                BeginContext(2619, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2635, 37, true);
            WriteLiteral(" |\r\n    <button id=\"btnViewItemsSold\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2672, "\"", 2721, 3);
            WriteAttributeValue("", 2682, "getItemsSold(", 2682, 13, true);
#line 84 "C:\Users\Austin Sanders\source\repos\OneStopBeauty\OneStopBeauty\Views\BillingStatements\Details.cshtml"
WriteAttributeValue("", 2695, Model.BillingStatementID, 2695, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 2720, ")", 2720, 1, true);
            EndWriteAttribute();
            BeginContext(2722, 93, true);
            WriteLiteral(" class=\"btn btn-default\">View Items Sold</button>\r\n</div>\r\n\r\n<div id=\"pvItemsSold\">\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneStopBeauty.Models.BillingStatement> Html { get; private set; }
    }
}
#pragma warning restore 1591