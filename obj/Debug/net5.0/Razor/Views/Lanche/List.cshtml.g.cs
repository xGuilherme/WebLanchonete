#pragma checksum "D:\Projetos VIsual studio\ProjetoLanchonete\Views\Lanche\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32f3c0cdfca33f5221fe19dd32f92fcb916d0d5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lanche_List), @"mvc.1.0.view", @"/Views/Lanche/List.cshtml")]
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
#line 1 "D:\Projetos VIsual studio\ProjetoLanchonete\Views\_ViewImports.cshtml"
using ProjetoLanchonete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos VIsual studio\ProjetoLanchonete\Views\_ViewImports.cshtml"
using ProjetoLanchonete.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projetos VIsual studio\ProjetoLanchonete\Views\_ViewImports.cshtml"
using ProjetoLanchonete.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32f3c0cdfca33f5221fe19dd32f92fcb916d0d5c", @"/Views/Lanche/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cdf859030118723ffd4dc45e2667cbf65839140", @"/Views/_ViewImports.cshtml")]
    public class Views_Lanche_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LancheListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div><h2>");
#nullable restore
#line 3 "D:\Projetos VIsual studio\ProjetoLanchonete\Views\Lanche\List.cshtml"
    Write(Model.CategoriaAtual);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n\r\n");
#nullable restore
#line 5 "D:\Projetos VIsual studio\ProjetoLanchonete\Views\Lanche\List.cshtml"
 foreach (Lanche lanche in Model.Lanches)
{    
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projetos VIsual studio\ProjetoLanchonete\Views\Lanche\List.cshtml"
   Write(Html.Partial("_LanchesResumo", lanche));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projetos VIsual studio\ProjetoLanchonete\Views\Lanche\List.cshtml"
                                               ;       
  
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LancheListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
