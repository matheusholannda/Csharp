#pragma checksum "C:\Users\35711103822\Desktop\Senai.Tarefas.MVC.WEB\Views\Usuario\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aa06dc9ab3ae436aaaa0480abb7bdefc0be7aa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastro), @"mvc.1.0.view", @"/Views/Usuario/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastro.cshtml", typeof(AspNetCore.Views_Usuario_Cadastro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aa06dc9ab3ae436aaaa0480abb7bdefc0be7aa3", @"/Views/Usuario/Cadastro.cshtml")]
    public class Views_Usuario_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 1 "C:\Users\35711103822\Desktop\Senai.Tarefas.MVC.WEB\Views\Usuario\Cadastro.cshtml"
               Layout = "MasterPageDeslogado"; 

#line default
#line hidden
            BeginContext(50, 646, true);
            WriteLiteral(@"            
            <h1>Cadastro de Usuários</h1>

            <form action=""/Usuario/Cadastro"" method=""POST"">
                <label>
                    Nome
                    <input type=""text"" name=""nome"">
                </label>

                <label>
                    E-mail
                    <input type=""email"" name=""email"">
                </label>

                <label>
                    Senha
                    <input type=""password"" name=""senha"">
                </label>

                <button type=""submit"">Salvar</button>
                
            </form>
            
            ");
            EndContext();
            BeginContext(697, 16, false);
#line 25 "C:\Users\35711103822\Desktop\Senai.Tarefas.MVC.WEB\Views\Usuario\Cadastro.cshtml"
       Write(ViewBag.Mensagem);

#line default
#line hidden
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