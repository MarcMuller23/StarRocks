#pragma checksum "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73add862d0b058da1e1d797f46d11b0145a129b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Index), @"mvc.1.0.view", @"/Views/Event/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\_ViewImports.cshtml"
using StarRocks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\_ViewImports.cshtml"
using StarRocks.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73add862d0b058da1e1d797f46d11b0145a129b", @"/Views/Event/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"447aa83a18f77bd64d92874f87418e8a0050fe9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StarRocks.Models.EventViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div>\r\n    <table class=\"table\">6\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 14 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaxCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AccountID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaxCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AccountID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { ID = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 70 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { ID = item.ID }, new { onclick = "return confirm('Are sure wants to delete?');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 73 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n    ");
#nullable restore
#line 75 "C:\Users\goert\Downloads\StarRocks-master (3)\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73add862d0b058da1e1d797f46d11b0145a129b11368", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StarRocks.Models.EventViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
