#pragma checksum "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5aec2a2f3e6ce394e01db0d7810bd99d7c00a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5aec2a2f3e6ce394e01db0d7810bd99d7c00a59", @"/Views/Home/index.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
    
    ViewData["Title"] = "Home";
    var user = (string) ViewData["User"];

#line default
#line hidden
            BeginContext(85, 38, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(123, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d7c1ab236004fb18b43cdb2b3d677b3", async() => {
                BeginContext(129, 191, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Ponto Digital</title>\r\n    <link rel=\"stylesheet\" href=\"/css/style.css\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(327, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(331, 10704, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef19a1c893b940609dc9641e69ddf12f", async() => {
                BeginContext(337, 449, true);
                WriteLiteral(@"
    <header id=""banner"" class=""banner"">
        <br>
        <div id=""menu"" class=""bann"">
            <span id=""btn_menu"" class=""botao_menu"">M</span>
            <nav class=""menu"">
                <ul>
                    <!-- <li> <a href=""index.cshtml""><h1>Ponto Digital</h1></a></li> -->
                    <li><a href=""#planosss"">Planos</a></li>
                    <li><a href=""#somos"">Quem Somos</a></li>
                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 786, "\'", 829, 1);
#line 24 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 793, Url.Action("Cadastrar", "Cadastro"), 793, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(830, 23, true);
                WriteLiteral(">Cadastre-se</a></li>\r\n");
                EndContext();
#line 25 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
                     if(string.IsNullOrEmpty(user))
                    {

#line default
#line hidden
                BeginContext(929, 30, true);
                WriteLiteral("                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 959, "\'", 1000, 1);
#line 27 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 966, Url.Action("FaqDeslogado", "FAQ"), 966, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1001, 180, true);
                WriteLiteral(">FAQ</a></li>\r\n                        <li><a id=\"bt_login\" asp-controller=\"Home\" asp-action=\"Login\" href=\"/Home/Login\"></a></li>\r\n                        <!-- Login/Cadastro -->\r\n");
                EndContext();
#line 30 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
                    } else {

#line default
#line hidden
                BeginContext(1211, 30, true);
                WriteLiteral("                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1241, "\'", 1273, 1);
#line 31 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 1248, Url.Action("FAQ", "FAQ"), 1248, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1274, 140, true);
                WriteLiteral(">FAQ</a></li>\r\n                        <li><a id=\"bt_logout\" asp-controller=\"Home\" asp-action=\"Logout\" href=\"/Home/Logout\">Logout</a></li>\r\n");
                EndContext();
#line 33 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1437, 339, true);
                WriteLiteral(@"                </ul>
            </nav>
        </div>
        <div>
            <img src=""img/Sem Título-1.png"" alt=""Logo"">
        </div>
        <br>
        <section class=""login"" id=""login"">
            <br>
            <h2>Login</h2>
            <br>
            <div class=""divisao"">
                <form method=""POST""");
                EndContext();
                BeginWriteAttribute("action", " action=\'", 1776, "\'", 1813, 1);
#line 46 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 1785, Url.Action("Login", "Home"), 1785, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1814, 3068, true);
                WriteLiteral(@">

                    <label for=""E-mail"">E-mail</label>
                    <br>
                    <input type=""email"" name=""email"" required>
                    <br>
                    <div>
                        <label for=""Senha"">Senha</label>
                        <br>
                        <input type=""password"" name=""senha"" required>
                        <br>
                    </div>
                    <div>
                        <label for=""Chave Do Produto"">Chave Do Produto</label>
                        <br>
                        <input type=""text"" >
                    </div>
                    <div>
                        <br>
                        
                        <input type=""submit"" value=""Enviar""/>

                        <br>
                    </div>
                </form>
                <br>
            </div>
        </section>
    </header>
    <main>
        <section id=""produtos"">
            <div class=""retangulo""></di");
                WriteLiteral(@"v>
            <div class=""produto"">
                <div class=""texto"">
                    <br>
                    <h2>Produtos</h2>
                    <br>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc odio lorem, elementum pellentesque
                        libero porttitor, venenatis laoreet ligula. Donec tempus, ipsum fermentum pellentesque
                        sagittis,
                        nulla nuncLorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc odio lorem, elementum
                        pellentesque
                        libero porttitor, venenatis laoreet ligula. Donec tempus, ipsum fermentum pellentesque
                        sagittis,
                        nulla nuncLorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc odio lorem, elementum
                        pellentesque
                        libero porttitor, venenatis laoreet ligula. Donec tempus, ipsum fermentum pellentesque
                ");
                WriteLiteral(@"        sagittis,
                        nulla nuncLorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc odio lorem, elementum
                        pellentesque
                        libero porttitor, venenatis laoreet ligula. Donec tempus, ipsum fermentum pellentesque
                        sagittis,
                        nulla nuncLorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc odio lorem, elementum
                        pellentesque
                        libero porttitor, venenatis laoreet ligula. Donec tempus, ipsum fermentum pellentesque
                        sagittis,
                        nulla nuncLorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc odio lorem, elementum
                        pellentesque
                        libero porttitor, venenatis laoreet ligula. Donec tempus, ipsum fermentum pellentesque
                        sagittis,
                        nulla nunc </p>
                    <br>
                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 4882, "\'", 4922, 1);
#line 108 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 4889, Url.Action("Produto", "Produto"), 4889, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4923, 353, true);
                WriteLiteral(@">Ler mais</a>
                </div>
                <div class=""imagem"">
                    <img src=""img/pc.png"" alt="""">
                </div>
            </div>
        </section>
        <br>
        <br>

        <nav id=""navegacao"">
            <div class=""planos""><a href=""#planosss"">PLANOS</a></div>
            <div class=""faq""><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 5276, "\'", 5308, 1);
#line 120 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 5283, Url.Action("FAQ", "FAQ"), 5283, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5309, 1822, true);
                WriteLiteral(@">FAQ</a></div>
            <div class=""contato""><a href=""faq.html"">CONTATOS</a></div>
            <br>
            <br>
        </nav>

        <section id=""somos"">
            <br>
            <div class=""retanguloazul"">
                <h2>Quem Somos Nós</h2>
            </div>
            <div class=""quadradoazul"">
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc odio lorem, elementum pellentesque
                    libero
                    porttitor, venenatis laoreet ligula. Donec tempus, ipsum fermentum pellentesque sagittis, nulla
                    nunc
                    facilisis libero, ac aliquam ante lorem et dolor. Maecenas ex tortor, pellentesque sit amet velit
                    sit
                    amet, maximus ultricies justo. Proin euismod quis massa nec ullamcorper. Aliquam rutrum interdum
                    diam.
                    Donec ultricies felis mi, quis dapibus metus ultrices nec. Phasellus nec ullamcorper massa, ut");
                WriteLiteral(@"
                    condimentum sapien.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc odio lorem,
                    elementum pellentesque
                    libero
                    porttitor, venenatis laoreet ligula. Donec tempus, ipsum fermentum pellentesque sagittis, nulla
                    nunc
                    facilisis libero, ac aliquam ante lorem et dolor. Maecenas ex tortor, pellentesque sit amet velit
                    sit
                    amet, maximus ultricies justo. Proin euismod quis massa nec ullamcorper. Aliquam rutrum interdum
                    diam.
                    Donec ultricies felis mi, quis dapibus metus ultrices nec. Phasellus nec ullamcorper massa, ut
                    condimentum sapien.</p>
                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 7131, "\'", 7169, 1);
#line 152 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 7138, Url.Action("Somos", "Produto"), 7138, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7170, 1085, true);
                WriteLiteral(@">Ler Mais</a>
                <br>
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.888887080243!2d-46.648335685070926!3d-23.5364984846952!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deb99025%3A0xb23619858bc7e63e!2sEscola+SENAI+de+Inform%C3%A1tica!5e0!3m2!1spt-BR!2sbr!4v1552331446506""
                    width=""600"" height=""460"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
            </div>
        </section>
        <section id=""planosss"">
            <br>
            <h2>Planos</h2>
            <br>
            <div class=""container_planos content"">
                <div class=""plano"">
                    <div class=""miinii"">
                        <h3>Plano Gratuito</h3>
                    </div>
                    <br>
                    <p>-Teste-</p>
                    <p>1 funcionário</p>
                    <p>período de 1 mês</p>
                    <p>suporte de 48h</p>
                    <br>
           ");
                WriteLiteral("         <br>\r\n                    <button class=\"comprar\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 8255, "\'", 8298, 1);
#line 174 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 8262, Url.Action("Cadastrar", "Cadastro"), 8262, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8299, 495, true);
                WriteLiteral(@" class=""aa1"">Comprar</a></button>
                </div>
                <div class=""plano"">
                    <div class=""miinii"">
                        <h3>Plano 1</h3>
                    </div>
                    <br>
                    <p>até 5 funcionários</p>
                    <p>R$29,90 mensal</p>
                    <p>Suporte de até 24h</p>
                    <br>
                    <br>
                    <br>
                    <button class=""comprar""><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 8794, "\'", 8837, 1);
#line 187 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 8801, Url.Action("Cadastrar", "Cadastro"), 8801, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8838, 497, true);
                WriteLiteral(@" class=""aa1"">Comprar</a></button>
                </div>
                <div class=""plano"">
                    <div class=""miinii"">
                        <h3>Plano 2</h3>
                    </div>
                    <br>
                    <p>até 50 funcionários</p>
                    <p>R$149,90 mensal</p>
                    <p>Suporte de até 12h</p>
                    <br>
                    <br>
                    <br>
                    <button class=""comprar""><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 9335, "\'", 9378, 1);
#line 200 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 9342, Url.Action("Cadastrar", "Cadastro"), 9342, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9379, 497, true);
                WriteLiteral(@" class=""aa1"">Comprar</a></button>
                </div>
                <div class=""plano"">
                    <div class=""miinii"">
                        <h3>Plano 3</h3>
                    </div>
                    <br>
                    <p>até 500 funcionários</p>
                    <p>R$299,90 mensal</p>
                    <p>Suporte de até 2h</p>
                    <br>
                    <br>
                    <br>
                    <button class=""comprar""><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 9876, "\'", 9919, 1);
#line 213 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 9883, Url.Action("Cadastrar", "Cadastro"), 9883, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9920, 503, true);
                WriteLiteral(@" class=""aa1"">Comprar</a></button>
                </div>
                <div class=""plano plano4"">
                    <div class=""miinii"">
                        <h3>Plano 4</h3>
                    </div>
                    <br>
                    <p>acima de 500 funcionários</p>
                    <p>à definir</p>
                    <p>Suporte de até 1h</p>
                    <br>
                    <br>
                    <br>
                    <button class=""comprar""><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 10423, "\'", 10466, 1);
#line 226 "D:\senai\PONTODIGITAL2\PONTODIGITAL\Views\Home\index.cshtml"
WriteAttributeValue("", 10430, Url.Action("Cadastrar", "Cadastro"), 10430, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10467, 561, true);
                WriteLiteral(@" class=""aa1"">Comprar</a></button>
                </div>
            </div>
        </section>

    </main>
    <br>
    <footer>
        <p><a href=""solução.html"">Soluçao de problema</a></p>
    </footer>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script>
        $(function () {
            var nav = $('.menu');
            var botao = $('.botao_menu');
            botao.on('click', function () {
                nav.toggleClass(""active"");
            });
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11035, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
