#pragma checksum "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1886b2809672b5f7639a8ca53ef26365f1c3e1e3"
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
#line 1 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\_ViewImports.cshtml"
using StarRocks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\_ViewImports.cshtml"
using StarRocks.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1886b2809672b5f7639a8ca53ef26365f1c3e1e3", @"/Views/Event/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ed4ec54a68626f854df9a815b4092108e54521", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StarRocks.Models.EventViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:350px; height:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""h2 pt-3 text-center font-weight-bold"">UPCOMING EVENTS</div>
<div class=""pb-3 text-center font-weight-normal"">Bijzijn bij events = meemaken bij Team Rockstars IT! Kies een event naar eigen keuze en maak je klaar voor een verfrissende IT toekomst!</div>
<hr />

");
#nullable restore
#line 11 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n\r\n        <div class=\"card-body\">\r\n            <h2 class=\"font-weight-bold text-center pb3\">");
#nullable restore
#line 16 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
                                                    Write(Html.DisplayFor(ModelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <div class=\"row pt-3\">\r\n                <div class=\"col-5 img-fluid\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1886b2809672b5f7639a8ca53ef26365f1c3e1e34869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 666, "~/Images/", 666, 9, true);
#nullable restore
#line 18 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
AddHtmlAttributeValue("", 675, Html.DisplayFor(ModelItem =>item.ID), 675, 37, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 712, "event.jpg", 713, 10, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                <div class=\"col-7* font-weight-light \">\r\n                    ");
#nullable restore
#line 20 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(ModelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row pt-3\">\r\n                <div class=\"col font-weight-bolder\">\r\n                    ");
#nullable restore
#line 26 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(ModelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n                <div class=\"col-6 font-weight-bolder\">\r\n                    ");
#nullable restore
#line 31 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.DisplayFor(ModelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"col text-white\">\r\n\r\n                    ");
#nullable restore
#line 36 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
               Write(Html.ActionLink("Inschrijven", "Create", "EventRegistration", new { ID = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n");
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n");
#nullable restore
#line 44 "D:\Git\StarRocks\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Event\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
