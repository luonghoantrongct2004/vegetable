#pragma checksum "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "031d20ea08c9d2b1827cd1abbf011651e8678ac6f29d5b50c9f372ad02c885c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCustomers_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCustomers/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\_ViewImports.cshtml"
using Selling_Vegetable_26102023;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\_ViewImports.cshtml"
using Selling_Vegetable_26102023.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"031d20ea08c9d2b1827cd1abbf011651e8678ac6f29d5b50c9f372ad02c885c3", @"/Areas/Admin/Views/AdminCustomers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"086bd7ff7373d5de0734195b0a29106af153b7e4ea47271790230bc058b0582f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminCustomers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Selling_Vegetable_26102023.Models.Customer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 16 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 22 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 25 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 28 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 31 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 34 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 37 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 40 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 43 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 46 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 49 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 52 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 55 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 58 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 61 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 64 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastLogin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 67 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastLogin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 70 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 73 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 76 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 79 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031d20ea08c9d2b1827cd1abbf011651e8678ac6f29d5b50c9f372ad02c885c313870", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "031d20ea08c9d2b1827cd1abbf011651e8678ac6f29d5b50c9f372ad02c885c314161", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 84 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\AdminCustomers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031d20ea08c9d2b1827cd1abbf011651e8678ac6f29d5b50c9f372ad02c885c316062", async() => {
                    WriteLiteral("Back to List");
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
                WriteLiteral("\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Selling_Vegetable_26102023.Models.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
