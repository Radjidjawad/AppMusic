#pragma checksum "D:\285164-Projet2netAsp\Preject2netAsp\Views\User\DisplayMostListenedMusics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9198dfe14f4fcd0ac051690043f23aca4d2af1b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DisplayMostListenedMusics), @"mvc.1.0.view", @"/Views/User/DisplayMostListenedMusics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/DisplayMostListenedMusics.cshtml", typeof(AspNetCore.Views_User_DisplayMostListenedMusics))]
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
#line 1 "D:\285164-Projet2netAsp\Preject2netAsp\Views\_ViewImports.cshtml"
using Preject2netAsp;

#line default
#line hidden
#line 2 "D:\285164-Projet2netAsp\Preject2netAsp\Views\_ViewImports.cshtml"
using Preject2netAsp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9198dfe14f4fcd0ac051690043f23aca4d2af1b3", @"/Views/User/DisplayMostListenedMusics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06193186cc34e6bda1d5b07faba4f99fae7f449", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DisplayMostListenedMusics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Preject2netAsp.Models.TracksTops>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstraps.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\285164-Projet2netAsp\Preject2netAsp\Views\User\DisplayMostListenedMusics.cshtml"
  
    ViewData["Title"] = "Wavesurfer";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\285164-Projet2netAsp\Preject2netAsp\Views\User\DisplayMostListenedMusics.cshtml"
  
    ViewData["Title"] = "Wavesurfer";

#line default
#line hidden
            BeginContext(150, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "D:\285164-Projet2netAsp\Preject2netAsp\Views\User\DisplayMostListenedMusics.cshtml"
  
    var serializedJson = Json.Serialize(@Model.Select(m => m.Audio));

#line default
#line hidden
            BeginContext(230, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(232, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb42edf1706941f5a6ff4a78ef9c958f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(285, 94, true);
            WriteLiteral("\r\n<h2>\r\n    The 10 Music Most Listen During the Week\r\n</h2>\r\n\r\n\r\n\r\n<script>\r\n    var audios = ");
            EndContext();
            BeginContext(380, 14, false);
#line 23 "D:\285164-Projet2netAsp\Preject2netAsp\Views\User\DisplayMostListenedMusics.cshtml"
            Write(serializedJson);

#line default
#line hidden
            EndContext();
            BeginContext(394, 1149, true);
            WriteLiteral(@";
</script>

<div id=""waveform""></div>

<div id=""btn"">

    <button onclick=""previous()""><< Previous</button>
    <button onclick=""togglePlay()"">Play/Pause</button>
    <button onclick=""next()"">Next >></button>
    <button onclick=""toggleMute()"">Mute/Unmoute</button>

</div>



<script src=""https://unpkg.com/wavesurfer.js""></script>
<script>
    var audio = 0;
    var wavesurfer = WaveSurfer.create({
        container: '#waveform'
    });
    function lancerwaveform(audio) {
        console.log(audio)
        wavesurfer.load(audios[audio]);
    }
    wavesurfer.on('ready', function () {
        wavesurfer.play();
    });
    lancerwaveform(audio);
    function togglePlay() {
        wavesurfer.playPause();
    }
    function next() {
        audio++;
        if (audio >= audios.length) {
            audio = 0;
        }
        lancerwaveform(audio);
    }
    function previous() {
        audio--;
        if (audio < 0) {
            audio = audios.length - 1;
    ");
            WriteLiteral("    }\r\n        lancerwaveform(audio);\r\n    }\r\n    function toggleMute() {\r\n        wavesurfer.toggleMute();\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Preject2netAsp.Models.TracksTops>> Html { get; private set; }
    }
}
#pragma warning restore 1591
