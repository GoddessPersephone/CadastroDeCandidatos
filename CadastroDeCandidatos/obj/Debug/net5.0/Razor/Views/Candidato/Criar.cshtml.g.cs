#pragma checksum "C:\Users\Lara\OneDrive\Documentos\Prova\CadastroDeCandidatos\CadastroDeCandidatos\Views\Candidato\Criar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27be679c102660978ab50385420e11f464b16da2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidato_Criar), @"mvc.1.0.view", @"/Views/Candidato/Criar.cshtml")]
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
#line 1 "C:\Users\Lara\OneDrive\Documentos\Prova\CadastroDeCandidatos\CadastroDeCandidatos\Views\_ViewImports.cshtml"
using CadastroDeCandidatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lara\OneDrive\Documentos\Prova\CadastroDeCandidatos\CadastroDeCandidatos\Views\_ViewImports.cshtml"
using CadastroDeCandidatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27be679c102660978ab50385420e11f464b16da2", @"/Views/Candidato/Criar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9766ae1a4a48693fd923fe63d3684854539cf07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Candidato_Criar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Candidato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lara\OneDrive\Documentos\Prova\CadastroDeCandidatos\CadastroDeCandidatos\Views\Candidato\Criar.cshtml"
  
    ViewData["Title"] = "Cadastrar novo Candidato";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Cadastre-se!</h1>\r\n\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27be679c102660978ab50385420e11f464b16da25184", async() => {
                WriteLiteral(@"
     <div class=""form-group"">
            <label for=""nome"">Nome</label>
            <input type=""text"" class=""form-control"" placeholder=""Digite o seu nome"">
     </div>

     <div class=""form-group"">
            <label for=""celular"">Celular</label>
            <input type=""text"" class=""form-control"" placeholder=""Digite o seu celular"">
     </div>

     <div class=""form-group"">
            <label for=nome>Conhecimentos</label>
            <input type=""text"" class=""form-control"" placeholder=""Informe os seus conhecimentos em tecnologia"">
      </div>   

      <div class=""form-group"">
            <label for=""exampleInputEmail1"">Email</label>
            <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Digite seu Email"">
            <small id=""emailHelp"" class=""form-text text-muted"">Suas informações pessoais estão seguras conosco</small>
     </div>

    <div class=""form-group"">
            <label for=""exampleInputPassword1"">Senha<");
                WriteLiteral(@"/label>
            <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Digite sua senha"">
    </div>

<h3>Marque os Conhecimentos que possui</h3>

<div class=""block"">

    <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""inlineCheckbox1"" value=""option1"">
            <label class=""form-check-label"" for=""inlineCheckbox1"">Python</label>
     </div>

    <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""inlineCheckbox2"" value=""option2"">
            <label class=""form-check-label"" for=""inlineCheckbox2"">C#</label>
     </div>

    <div class=""form-check"">
        <input class=""form-check-input"" type=""checkbox"" id=""inlineCheckbox3"" value=""option3"">
        <label class=""form-check-label"" for=""inlineCheckbox3"">Java</label>
        </div>
        <div class=""form-check"">
        <input class=""form-check-input"" type=""checkbox"" id=""inlineCheckbox4"" value=""option4"">
        <label class=");
                WriteLiteral(@"""form-check-label"" for=""inlineCheckbox4"">Kotlin</label>
        </div>

        <div class=""form-check"">
        <input class=""form-check-input"" type=""checkbox"" id=""inlineCheckbox5"" value=""option5"">
        <label class=""form-check-label"" for=""inlineCheckbox5"">JavaScript</label>
        </div>

        <div class=""form-check"">
        <input class=""form-check-input"" type=""checkbox"" id=""inlineCheckbox6"" value=""option6"">
        <label class=""form-check-label"" for=""inlineCheckbox6"">Asp.NET</label>
        </div>

     </div>

<br />

      <button type=""submit"" class=""btn btn-success btn-block"">Cadastrar</button>
      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27be679c102660978ab50385420e11f464b16da28350", async() => {
                    WriteLiteral("Voltar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
