#pragma checksum "C:\Users\Tia Smith\source\repos\tiajsmith\tiajsmith\Views\MyHangman\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8553685310b50039b8de6173337df1b4653532a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyHangman_Game), @"mvc.1.0.view", @"/Views/MyHangman/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyHangman/Game.cshtml", typeof(AspNetCore.Views_MyHangman_Game))]
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
#line 1 "C:\Users\Tia Smith\source\repos\tiajsmith\tiajsmith\Views\_ViewImports.cshtml"
using tiajsmith;

#line default
#line hidden
#line 2 "C:\Users\Tia Smith\source\repos\tiajsmith\tiajsmith\Views\_ViewImports.cshtml"
using tiajsmith.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8553685310b50039b8de6173337df1b4653532a", @"/Views/MyHangman/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c644c8ce4411ec912f512e41dd020f22850c2209", @"/Views/_ViewImports.cshtml")]
    public class Views_MyHangman_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Tia Smith\source\repos\tiajsmith\tiajsmith\Views\MyHangman\Game.cshtml"
  
    ViewData["Title"] = "MyShoppingCart";

#line default
#line hidden
            BeginContext(50, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(211, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(238, 273, true);
            WriteLiteral(@"
<h2>Scan</h2>

<input type=text size=16 placeholder=""Tracking Code"" class=qrcode-text><label class=qrcode-text-btn>
    <input type=file accept=""image/*""
           capture onchange=""openQRCamera(this);"" tabindex=-1>
</label>
<input type=button value=""Go"" disabled>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
