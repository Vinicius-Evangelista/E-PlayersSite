#pragma checksum "C:\Users\Vinicius\Desktop\EplayersMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b20986f3080ee2e7a99dab084007f8db7126e7f4"
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
#line 1 "C:\Users\Vinicius\Desktop\EplayersMVC\Views\_ViewImports.cshtml"
using EplayersMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vinicius\Desktop\EplayersMVC\Views\_ViewImports.cshtml"
using EplayersMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b20986f3080ee2e7a99dab084007f8db7126e7f4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4090370d1fb27f87cb28420ffb0ff549f231b31e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Equipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Jogador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Vinicius\Desktop\EplayersMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section_banner "">
    <div class=""box_banner container"">
        <div class=""img_cs"">
            <img src=""/image/imgbin_counter-strike-global-offensive-league-of-legends-starcraft-dota-2-esports-png 1.png"">
        </div>
        <div class=""box_button"">
            <h1>Liga E-Players</h1>
            <span>O maior portal de campeonato online</span>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20986f3080ee2e7a99dab084007f8db7126e7f44802", async() => {
                WriteLiteral("Cadastrar Equipe");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20986f3080ee2e7a99dab084007f8db7126e7f46385", async() => {
                WriteLiteral("Cadastrar Jogador");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</section>

<div class=""box_logos"">
    <div class=""box container"">
        <nav class=""nav_logo"">
            <img src=""/image/formula-1-logo 1.png"" alt=""logo_f1"">
            <img src=""/image/logo-lol 1.png"" alt=""logo_lol"">
            <img src=""/image/valorant-logo 1.png"" alt=""logo_vlt"">
            <img src=""/image/Counter-Strike-Logo 1.png"" alt=""logo_cs"">
            <img src=""/image/FIFA_logo 1.png"" alt=""logo_fifa"">
        </nav>
    </div>
</div>

<!-- como participar -->


<section class=""campeonatos"">
    <div class=""filtro_campeonato"">
        <div class=""polygon"">
            <div class=""box_campeonatos container"">
                <div class=""container_campeonatos"">
                    <h2>Como participar das ligas ?</h2>
                    <p class=""texto_campeonatos"">
                        Lorem Ipsum is simply dummy text of the priting and typesetting industry. Lorem Ipsum
                        has been the industry???s standard dummy te");
            WriteLiteral(@"xt ever since the 1500s, when an unknown
                        printer took a galley of type anf scrambled it to make a type specimen book. It has
                        survived not only five centuries, but also the leap into electronic typesetting,
                        remaining essentially unchanged. It was popularized in the.<br>
                        <br>
                        Lorem Ipsum is simply dummy text of thr printing and typesetting industry. Lorem Ipsum
                        has been the industry???s standard dummy text ever since the 1500s, when an unknown
                        printer took a galley of type and scrambled it to make a type specimen book.
                    </p>
                </div>
                <img src=""/image/league-of-legends-champions 1.png"" alt=""chapion_lol"">
            </div>
        </div>
    </div>
</section>


<!-- partidas -->


<div class=""partidas"">
    <div class=""aovivo container"">
        <nav class=""nav_ao_vivo"">
       ");
            WriteLiteral(@"     <div class=""box_aovivo"">
                <span class=""textos_span"">ao vivo</span>
                <span class=""textos_time"">sk</span>
                <img class=""logo_sk"" src=""/image/sk-logo 1.png"">
                <span class=""span_vs"">vs</span>
                <img class=""logo_flamengo"" src=""/image/fla-logo 1.png"" alt=""logo flamengo"">
                <span class=""textos_time"">fla</span>
            </div>
        </nav>
        <div class=""container_borda"">
            <div class=""borda""></div>
        </div>
        <nav class=""nav_embreve"">
            <div class=""box_embreve"">
                <span class=""em_breve textos_span"">em breve</span>
                <span class=""textos_time"">sk</span>
                <img class=""logo_sk"" src=""/image/sk-logo 1.png"">
                <span class=""span_vs"">vs</span>
                <img class=""logo_flamengo"" src=""/image/fla-logo 1.png"" alt=""logo flamengo"">
                <span class=""span_time""> mibr</span>
            </div>
        </nav");
            WriteLiteral(@">

        <div class=""box_jogos_extra"">
            <nav class=""nav_jogos_extra"">
                <span class=""textos_time"">sk</span>
                <img class=""logo_sk"" src=""/image/sk-logo 1.png"">
                <span class=""span_vs"">vs</span>
                <img class=""logo_flamengo"" src=""/image/fla-logo 1.png"" alt=""logo flamengo"">
                <span class=""textos_time"">f??ria</span>
            </nav>
        </div>
    </div>
</div>

<!-- noticias -->

<section class=""noticias"">
    <div class=""all_noticias_elements container"">
        <div class=""container_noticias"">
            <h2>Not??cias</h2>
            <div class=""box_noticias"">
                <article class=""noticias_elements"">
                    <img src=""/image/player 1.png"" class=""girl_player"" alt=""player"">
                    <div class=""textos_noticias"">
                        <h3>titulo da noticias</h3>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lore");
            WriteLiteral(@"m
                            Ipsum has been the industry's standard dummy text.</p>
                    </div>
                </article>

                <article class=""noticias_elements"">
                    <img src=""/image/player 1.png"" class=""girl_player"" alt=""player"">
                    <div class=""textos_noticias"">
                        <h3>titulo da noticias</h3>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                            Ipsum has been the industry's standard dummy text.</p>
                    </div>
                </article>

                <article class=""noticias_elements"">
                    <img src=""/image/player 1.png"" class=""girl_player"" alt=""player"">
                    <div class=""textos_noticias"">
                        <h3>titulo da noticias</h3>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                            Ipsum");
            WriteLiteral(@" has been the industry's standard dummy text.</p>
                    </div>
                </article>





                <article id=""off_768"" class=""noticias_elements"">
                    <img src=""/image/player 1.png"" class=""girl_player"" alt=""player"">
                    <div class=""textos_noticias"">
                        <h3>titulo da noticias</h3>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                            Ipsum has been the industry's standard dummy text.</p>
                    </div>
                </article>

                <article id=""off_768"" class=""noticias_elements"">
                    <img src=""/image/player 1.png"" class=""girl_player"" alt=""player"">
                    <div class=""textos_noticias"">
                        <h3>titulo da noticias</h3>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                            Ipsum h");
            WriteLiteral(@"as been the industry's standard dummy text.</p>
                    </div>
                </article>

                <article id=""off_768"" class=""noticias_elements"">
                    <img src=""/image/player 1.png"" class=""girl_player"" alt=""player"">
                    <div class=""textos_noticias"">
                        <h3>titulo da noticias</h3>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                            Ipsum has been the industry's standard dummy text.</p>
                    </div>
                </article>
            </div>
        </div>


        <!-- jogos list -->

        <section class=""proximos_jogos"">
            <h2>Pr??ximos jogos</h2>
            <div class=""box_proximos_jogos"">
                <nav class=""box_container_jogos"">
                    <div class=""container_jogos_proximos"">
                        <span class=""textos_time"">sk</span>
                        <img class=""logo_sk""");
            WriteLiteral(@" src=""/image/sk-logo 1.png"">
                        <span class=""span_vs"">vs</span>
                        <img class=""logo_flamengo"" src=""/image/fla-logo 1.png"" alt=""logo flamengo"">
                        <span class=""span_vrs"">vrs</span>
                    </div>
                    <span>1/12/2020 19:00</span>
                    <div class=""container_jogos_proximos"">
                        <span class=""textos_time"">sk</span>
                        <img class=""logo_sk"" src=""/image/sk-logo 1.png"">
                        <span class=""span_vs'"">vs</span>
                        <img class=""logo_flamengo"" src=""/image/fla-logo 1.png"" alt=""logo flamengo"">
                        <span class=""span_vrs"">vrs</span>
                    </div>
                    <span>1/12/2020 19:00</span>
                    <div class=""container_jogos_proximos"">
                        <span class=""textos_time"">sk</span>
                        <img class=""logo_sk"" src=""/image/sk-logo 1.png"">
             ");
            WriteLiteral(@"           <span class=""span_vs"">vs</span>
                        <img class=""logo_flamengo"" src=""/image/fla-logo 1.png"" alt=""logo flamengo"">
                        <span class=""span_vrs"">vrs</span>
                    </div>
                    <span>1/12/2020 19:00</span>
                    <div class=""container_jogos_proximos"">
                        <span class=""textos_time"">sk</span>
                        <img class=""logo_sk"" src=""/image/sk-logo 1.png"">
                        <span class=""span_vs"">vs</span>
                        <img class=""logo_flamengo"" src=""/image/fla-logo 1.png"" alt=""logo flamengo""> <span
                            class=""span_vrs"">vrs</span>
                    </div>
                    <span>1/12/2020 19:00</span>
                    <div class=""container_jogos_proximos"">
                        <span class=""textos_time"">sk</span>
                        </img class=""logo_sk"" src=""/image/sk-logo 1.png"">
                        <span class=""span_vs"">vs</sp");
            WriteLiteral(@"an>
                        </img class=""logo_flamengo"" src=""/image/fla-logo 1.png"" alt=""logo flamengo"">
                        <span class=""span_vrs"">vrs</span>
                    </div>
                    <span>1/12/2020 19:00</span>
                </nav>
            </div>
        </section>
    </div>
</section>");
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
