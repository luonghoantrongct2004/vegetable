#pragma checksum "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5d0257e503c2b0b8136dbc558f92d6919ae4d771f3dd12bab1bdaef4fcd85b24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Search_ListProductSearchPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Search/ListProductSearchPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5d0257e503c2b0b8136dbc558f92d6919ae4d771f3dd12bab1bdaef4fcd85b24", @"/Areas/Admin/Views/Search/ListProductSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"086bd7ff7373d5de0734195b0a29106af153b7e4ea47271790230bc058b0582f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Search_ListProductSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Selling_Vegetable_26102023.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 9 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 12 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
             if (item.Price.HasValue)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 21 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
               Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND\r\n                </td>\r\n");
#nullable restore
#line 23 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 29 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 33 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
             if (item.Active != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
                 if (item.StockQuantity > 0)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        Active\r\n                    </td>\r\n");
#nullable restore
#line 41 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        No Active\r\n                    </td>\r\n");
#nullable restore
#line 47 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d0257e503c2b0b8136dbc558f92d6919ae4d771f3dd12bab1bdaef4fcd85b2410876", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 53 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
                                       WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d0257e503c2b0b8136dbc558f92d6919ae4d771f3dd12bab1bdaef4fcd85b2413164", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
                                          WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d0257e503c2b0b8136dbc558f92d6919ae4d771f3dd12bab1bdaef4fcd85b2415458", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
                                         WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\PREDATOR\OneDrive\Tài liệu\Asp_Selling-Vegetable\Selling_Vegetable_26102023\Selling_Vegetable_26102023\Areas\Admin\Views\Search\ListProductSearchPartial.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Selling_Vegetable_26102023.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591