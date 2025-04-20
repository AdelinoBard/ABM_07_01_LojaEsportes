using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using LojaEsportes_WebApp.Models.ViewModels;

namespace LojaEsportes_WebApp.Infrastructure {
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory) {
            urlHelperFactory = helperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext? ViewContext { get; set; }
        public PagingInfo? PageModel { get; set; }
        public string? PageAction { get; set; }
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; } = String.Empty;
        public string PageClassNormal { get; set; } = String.Empty;
        public string PageClassSelected { get; set; } = String.Empty;
        public override void Process(TagHelperContext context,
                TagHelperOutput output) {
            if (ViewContext != null && PageModel != null) {
                IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
                TagBuilder result = new TagBuilder("div");
                for (int i = 1; i <= PageModel.TotalPages; i++) {
                    TagBuilder tag = new TagBuilder("a");
                    tag.Attributes["href"] = urlHelper.Action(PageAction,
                       new { productPage = i });
                    if (PageClassesEnabled) {
                        tag.AddCssClass(PageClass);
                        tag.AddCssClass(i == PageModel.CurrentPage
                            ? PageClassSelected : PageClassNormal);
                    }
                    tag.InnerHtml.Append(i.ToString());
                    result.InnerHtml.AppendHtml(tag);
                }
                output.Content.AppendHtml(result.InnerHtml);
            }
        }
    }
}

/*
## Adicionando a classe auxiliar de tags
Este auxiliar de tag preenche um elemento div com elementos que correspondem a páginas de produtos.
Usar auxiliares de tag é preferível a incluir blocos de código C# em uma visualização porque um auxiliar de tag pode ser facilmente testado em unidades e pode ser reutilizado em outras visualizações.
A classe PageLinkTagHelper herda de TagHelper e tem um construtor que aceita um IUrlHelperFactory. O método Process é chamado quando o Razor encontra a tag <div page-model="...">. Ele cria um elemento div e preenche-o com links para cada página de produtos, usando o IUrlHelper para gerar os URLs corretos.
## Adicionando o atributo page-model
O atributo page-model é adicionado ao elemento div na visualização de índice. Isso informa ao Razor que o elemento div deve ser preenchido com links para as páginas de produtos.

A maioria dos componentes do ASP.NET Core, como controladores e visualizações, são descobertos automaticamente, mas os auxiliares de tag precisam ser registrados. Necessário adicionar uma instrução ao arquivo _ViewImports.cshtml na pasta Views que informa ao ASP.NET Core para procurar classes auxiliares de tag no projeto. Também é necessário adicionar uma expressão @using para que possa referir às classes do modelo de visualização em visualizações sem ter que qualificar seus nomes com o namespace.

Adicionando classes a elementos no arquivo PageLinkTagHelper.cs na pasta SportsStore/Infrastructure_ 
Preciso estilizar os botões gerados pela classe PageLinkTagHelper, mas não quero conectar as classes Bootstrap ao código C# porque isso dificulta a reutilização do auxiliar de tag em outro lugar no aplicativo ou a alteração da aparência dos botões. Em vez disso, defini atributos personalizados no elemento div que especificam as classes que preciso, e elas correspondem às propriedades que adicionei à classe auxiliar de tag, que são então usadas para estilizar os elementos a que são produzidos. As propriedades PageClass, PageClassNormal e PageClassSelected são usadas para definir as classes CSS que serão aplicadas aos links de página. A propriedade PageClassesEnabled é usada para habilitar ou desabilitar a aplicação dessas classes CSS. Se PageClassesEnabled for verdadeiro, as classes CSS serão aplicadas aos links de página. Caso contrário, os links de página serão gerados sem classes CSS.

Os valores dos atributos são usados automaticamente para definir os valores de propriedade do auxiliar de tag, com o mapeamento entre o formato de nome de atributo HTML (page-class-normal) e o formato de nome de propriedade C# (PageClassNormal) levado em conta. Isso permite que os auxiliares de tag respondam de forma diferente com base nos atributos de um elemento HTML, criando uma maneira mais flexível de gerar conteúdo em um aplicativo ASP.NET Core. 


*/