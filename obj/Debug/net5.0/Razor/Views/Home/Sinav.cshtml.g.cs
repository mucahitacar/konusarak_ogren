#pragma checksum "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce51972ce66e2f3042615f6eb78aef3bc4ae5103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sinav), @"mvc.1.0.view", @"/Views/Home/Sinav.cshtml")]
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
#line 1 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\_ViewImports.cshtml"
using KonusarakOgren;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\_ViewImports.cshtml"
using KonusarakOgren.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce51972ce66e2f3042615f6eb78aef3bc4ae5103", @"/Views/Home/Sinav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505cd664a39c207ec978def83647500638b5b7d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sinav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KonusarakOgren.Models.Sinav>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formTest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
  
    ViewData["Title"] = "Sinav";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n\r\n    <h1> ");
#nullable restore
#line 9 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
    Write(Model.FirstOrDefault().baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1><br />\r\n    ");
#nullable restore
#line 10 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
Write(Model.FirstOrDefault().yazi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <\r\n</div>>\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce51972ce66e2f3042615f6eb78aef3bc4ae51034378", async() => {
                WriteLiteral("\r\n    <fieldset class=\"radiogroup\">\r\n        <legend>Soru 1: ");
#nullable restore
#line 57 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                   Write(Model[0].soru);

#line default
#line hidden
#nullable disable
                WriteLiteral("</legend>\r\n        <ul class=\"radio\" style=\"list-style:none\">\r\n            <li>A) <input type=\"radio\" name=\"q1\" value=\"A\" /><label>");
#nullable restore
#line 59 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[0].A_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>B) <input type=\"radio\" name=\"q1\" value=\"B\" /><label>");
#nullable restore
#line 60 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[0].B_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>C) <input type=\"radio\" name=\"q1\" value=\"C\" /><label>");
#nullable restore
#line 61 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[0].C_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>D) <input type=\"radio\" name=\"q1\" value=\"D\" /><label>");
#nullable restore
#line 62 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[0].D_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n        </ul>\r\n    </fieldset>\r\n\r\n    <fieldset class=\"radiogroup\">\r\n        <legend>Soru 2: ");
#nullable restore
#line 67 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                   Write(Model[1].soru);

#line default
#line hidden
#nullable disable
                WriteLiteral("</legend>\r\n        <ul class=\"radio\" style=\"list-style:none\">\r\n            <li>A) <input type=\"radio\" name=\"q2\" value=\"A\" /><label>");
#nullable restore
#line 69 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[1].A_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>B) <input type=\"radio\" name=\"q2\" value=\"B\" /><label>");
#nullable restore
#line 70 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[1].B_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>C) <input type=\"radio\" name=\"q2\" value=\"C\" /><label>");
#nullable restore
#line 71 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[1].C_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>D) <input type=\"radio\" name=\"q2\" value=\"D\" /><label>");
#nullable restore
#line 72 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[1].D_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n        </ul>\r\n    </fieldset>\r\n\r\n    <fieldset class=\"radiogroup\">\r\n        <legend>Soru 2: ");
#nullable restore
#line 77 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                   Write(Model[2].soru);

#line default
#line hidden
#nullable disable
                WriteLiteral("</legend>\r\n        <ul class=\"radio\" style=\"list-style:none\">\r\n            <li>A) <input type=\"radio\" name=\"q3\" value=\"A\" /><label>");
#nullable restore
#line 79 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[2].A_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>B) <input type=\"radio\" name=\"q3\" value=\"B\" /><label>");
#nullable restore
#line 80 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[2].B_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>C) <input type=\"radio\" name=\"q3\" value=\"C\" /><label>");
#nullable restore
#line 81 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[2].C_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>D) <input type=\"radio\" name=\"q3\" value=\"D\" /><label>");
#nullable restore
#line 82 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[2].D_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n        </ul>\r\n    </fieldset>\r\n    <fieldset class=\"radiogroup\">\r\n        <legend>Soru 2: ");
#nullable restore
#line 86 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                   Write(Model[3].soru);

#line default
#line hidden
#nullable disable
                WriteLiteral("</legend>\r\n        <ul class=\"radio\" style=\"list-style:none\">\r\n            <li>A) <input type=\"radio\" name=\"q4\" value=\"A\" /><label>");
#nullable restore
#line 88 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[3].A_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>B) <input type=\"radio\" name=\"q4\" value=\"B\" /><label>");
#nullable restore
#line 89 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[3].B_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>C) <input type=\"radio\" name=\"q4\" value=\"C\" /><label>");
#nullable restore
#line 90 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[3].C_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n            <li>D) <input type=\"radio\" name=\"q4\" value=\"D\" /><label>");
#nullable restore
#line 91 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                               Write(Model[3].D_sikki);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></li>\r\n        </ul>\r\n    </fieldset>\r\n    <input type=\"button\" value=\"Cevapla\" onclick=\"checkAnswer()\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div id=\"rapor\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    function checkAnswer() {\r\n        var soruSayisi = 4;\r\n        var gelenCevap = new Array();\r\n        var dogruCevap = new Array(\"");
#nullable restore
#line 102 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                               Write(Model[0].cevap);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\"");
#nullable restore
#line 102 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                 Write(Model[1].cevap);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\"");
#nullable restore
#line 102 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                                   Write(Model[2].cevap);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\"");
#nullable restore
#line 102 "C:\Users\macar\Desktop\mucahit\konusarak_ogren\Views\Home\Sinav.cshtml"
                                                                                     Write(Model[3].cevap);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
        var dogru = 0;
        var yanlis = 0;
        var cevap = 0;
        var rapor = """";

        for (i = 1; i <= soruSayisi; i++) {
            var secenekler = document.getElementsByName(""q"" + i);
            for (j = 0; j < secenekler.length; j++) {
                if (secenekler[j].checked) {
                    if (secenekler[j].value == dogruCevap[i - 1]) {
                        cevap = 1;
                    } else {
                        cevap = 0;
                    }
                    if (cevap) {
                        rapor += i + "". Soru için cevabınız: "" + secenekler[j].value + "", Doğru <br />"";
                    } else {
                        rapor += i + "". Soru için cevabınız: "" + secenekler[j].value + "", YANLIŞ, Doğru Cevap: "" + dogruCevap[i - 1] + ""<br />"";
                    }
                    gelenCevap.push(secenekler[j].value);
                }
            }
        }

        for (k = 0; k < soruSayisi; k++) {
            if (gelenCe");
            WriteLiteral(@"vap[k] == dogruCevap[k]) {
                dogru++;
            } else {
                yanlis++;
            }
        }
        rapor += ""Sonuç: "" + dogru + "" Doğru, "" + yanlis + "" Yanlış"" + ""<br />"";
        document.getElementById('rapor').innerHTML = rapor;
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KonusarakOgren.Models.Sinav>> Html { get; private set; }
    }
}
#pragma warning restore 1591
