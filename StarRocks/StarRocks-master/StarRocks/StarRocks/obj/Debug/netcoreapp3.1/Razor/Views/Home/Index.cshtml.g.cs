#pragma checksum "C:\Users\Kursat\Desktop\star\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e39a20305c2d6e96d7eb5dfd88a3a20ee56bf26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Kursat\Desktop\star\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\_ViewImports.cshtml"
using StarRocks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kursat\Desktop\star\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\_ViewImports.cshtml"
using StarRocks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kursat\Desktop\star\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Home\Index.cshtml"
using StarRocks.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kursat\Desktop\star\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kursat\Desktop\star\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Home\Index.cshtml"
using StarRocks.Interfaces.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e39a20305c2d6e96d7eb5dfd88a3a20ee56bf26", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ed4ec54a68626f854df9a815b4092108e54521", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Kursat\Desktop\star\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container position-relative text-center text-white"">
    <img src=""https://cdn.discordapp.com/attachments/697767886344683560/697768922119929916/cropped-Event-page-1.png"" class=""img-fluid"" style=""width:100%;"" />
    <div class=""centered"">Team Up IT!</div>
</div>
<br />

<div class=""card p-xl-3 bg-transparent"">
    <h2 class=""text-center font-weight-bold ""> Upcoming Events! </h2>
    <hr/>
    `
    <div class=""card-deck"">
        <div class=""card"" style=""width:400px;"">
            <img class=""card-img-top"" src=""https://cdn.discordapp.com/attachments/697767886344683560/714781271368269934/RST-062-img-teamUPit-2020-DaviddeHoop-600x521.png"" alt=""Card image"">
            <div class=""card-body"">
                <h4 class=""card-title"">Pizzasessie Chapter North | David de Hoop – GitLab</h4>
                <p class=""card-text"">22 mei, 2020</p>
            </div>
        </div>

        <div class=""card"" style=""width:400px;"">
            <img class=""card-img-top"" src=""https://cdn.dis");
            WriteLiteral(@"cordapp.com/attachments/697767886344683560/714776210781110362/RST-062-img-teamUPit-GLGroups-boardgames-600x521.png"" alt=""Card image"">
            <div class=""card-body"">
                <h4 class=""card-title"">Chapter West: Digitale Bordspellenavond (YESS!) </h4>
                <p class=""card-text"">mei 29, 2020</p>
            </div>
        </div>

        <div class=""card"" style=""width:400px;"">
            <img class=""card-img-top"" src=""https://cdn.discordapp.com/attachments/697767886344683560/714776210781110362/RST-062-img-teamUPit-GLGroups-boardgames-600x521.png"" alt=""Card image"">
            <div class=""card-body"">
                <h4 class=""card-title"">John Doe</h4>
                <p class=""card-text"">Some example text.</p>
            </div>
        </div>
    </div>
    <br/>
    <button class=""btn-dark"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 2115, "\"", 2170, 3);
            WriteAttributeValue("", 2125, "location.href=\'", 2125, 15, true);
#nullable restore
#line 48 "C:\Users\Kursat\Desktop\star\StarRocks\StarRocks\StarRocks-master\StarRocks\StarRocks\Views\Home\Index.cshtml"
WriteAttributeValue("", 2140, Url.Action("Index", "Event"), 2140, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2169, "\'", 2169, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">View all events!</button>
</div>


<div class=""card-body"">
    <h2 class=""font-weight-bold text-center p-3"">About Us</h2>
    <div class=""row"">
        <div class=""col-6 img-fluid""><img src=""https://cdn.discordapp.com/attachments/697767886344683560/714819528550514728/group-sky-jump-military-formation-extreme-sport-749603-pxhere-e1514896669553.png"" style=""width:500px; height:300px;"" /></div>
        <div class=""col-6 font-italic"">Team Up IT is de opleidingstak van Team Rockstars IT. Team Up IT staat voor ontwikkeling. IT Rockstars zijn op de hoogte van wat er speelt in hun vakgebied en voelen de drang de beste versie van hunzelf te worden! Bij Team Up IT bieden we de ontwikkelmogelijkheden op verschillende gebieden om dit te bereiken. Deze website geeft je een beeld van de kansen die we je kunnen bieden op jouw gewenste ontwikkelgebied. Vervolgens maak je in overleg met je Rockstars Coach een programma dat goed aansluit bij jouw groeiwensen! Je kan denken aan een rol als lead developer, projectmanager");
            WriteLiteral(@", architect, consultant of ondernemer. Op die manier verzeker je jezelf niet alleen nu van een goede carrière, maar zorg je er ook dat je over 5 jaar aan de absolute top staat. Prikkel jezelf en ga voor ontwikkeling! </div>

    </div>
</div>
<hr />
<div class=""card-body p-xl-3"">
    <h2 class=""font-weight-bold text-center p-3"">Opleidingen</h2>
    <div class=""row"">

        <div class=""col-8 font-italic"">Team Up IT is de opleidingstak van Team Rockstars IT. Team Up IT staat voor ontwikkeling. IT Rockstars zijn op de hoogte van wat er speelt in hun vakgebied en voelen de drang de beste versie van hunzelf te worden! Bij Team Up IT bieden we de ontwikkelmogelijkheden op verschillende gebieden om dit te bereiken. Deze website geeft je een beeld van de kansen die we je kunnen bieden op jouw gewenste ontwikkelgebied. Vervolgens maak je in overleg met je Rockstars Coach een programma dat goed aansluit bij jouw groeiwensen! Je kan denken aan een rol als lead developer, projectmanager, architect, consultant ");
            WriteLiteral(@"of ondernemer. Op die manier verzeker je jezelf niet alleen nu van een goede carrière, maar zorg je er ook dat je over 5 jaar aan de absolute top staat. Prikkel jezelf en ga voor ontwikkeling! </div>
        <div class=""col-4 img-fluid""><img src=""https://cdn.discordapp.com/attachments/697767886344683560/714822245712789534/image-1-4-e1514897346316.png"" style=""width:300px; height:200px;"" /></div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
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
