#pragma checksum "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71076136e8ab9ab5866353114683417c7f069987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71076136e8ab9ab5866353114683417c7f069987", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formAlign"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empr??stimos";
    string Classe = "";
    int FiltroPorPag = Int32.Parse(ViewData["emprestimosPorPagina"].ToString());
    int PaginaAtual = Int32.Parse(ViewData["PaginaAtual"].ToString());
    int NumEmprestimosPorPag = (Model.Count < FiltroPorPag ? Model.Count : FiltroPorPag);
    int NumTotalDePag = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
     if (NumEmprestimosPorPag > 0)
    {
        NumTotalDePag = Model.Count / NumEmprestimosPorPag + (Model.Count % NumEmprestimosPorPag == 0 ? 0 : 1);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .formAlign {\r\n        display: flex;\r\n    }\r\n</style>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div id=\"SeletorPaginas\" class=\"text-right\">\r\n            <span class=\"lead\">P??gina:</span>\r\n");
#nullable restore
#line 24 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
             for (int i = 1; i <= NumTotalDePag; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 880, "\"", 922, 2);
            WriteAttributeValue("", 887, "/Emprestimo/Listagem?PaginaAtual=", 887, 33, true);
#nullable restore
#line 27 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 920, i, 920, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" role=\"button\">");
#nullable restore
#line 27 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </span>\r\n");
#nullable restore
#line 29 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71076136e8ab9ab5866353114683417c7f0699878205", async() => {
                WriteLiteral("\r\n            <div class=\"form-group mb-2\">\r\n                <select name=\"TipoFiltro\" class=\"form-control\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71076136e8ab9ab5866353114683417c7f0699878601", async() => {
                    WriteLiteral("Usu??rio");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71076136e8ab9ab5866353114683417c7f0699879845", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group mb-2 mx-sm-3"">
                <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
            </div>
            <div>
                <select name=""itensPorPagina"" id=""itensPorPagina"" class=""form-control"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71076136e8ab9ab5866353114683417c7f06998711423", async() => {
                    WriteLiteral("10 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71076136e8ab9ab5866353114683417c7f06998712670", async() => {
                    WriteLiteral("15 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71076136e8ab9ab5866353114683417c7f06998713917", async() => {
                    WriteLiteral("30 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71076136e8ab9ab5866353114683417c7f06998715164", async() => {
                    WriteLiteral("50 Livros");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71076136e8ab9ab5866353114683417c7f06998716411", async() => {
                    WriteLiteral("Todos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       WriteLiteral(Model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary mb-2\" style=\"margin-left: 10px;\">Pesquisar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <table class=\"table table-striped\">\r\n");
#nullable restore
#line 58 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
             if (Model.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">Id</th>
                        <th scope=""col"">Usuario</th>
                        <th scope=""col"">Data Empr??stimo</th>
                        <th scope=""col"">Data Devolu????o</th>
                        <th scope=""col"">Livro</th>
                        <th scope=""col"">Autor</th>
                        <th scope=""col"">Devolvido</th>
                        <th scope=""col"">A????o</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 73 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                     for (int i = (PaginaAtual - 1) * NumEmprestimosPorPag; i < (NumEmprestimosPorPag * PaginaAtual <
                   Model.Count ? NumEmprestimosPorPag * PaginaAtual : Model.Count); i++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                         if ((System.DateTime.Compare(System.DateTime.Now, Model[i].DataDevolucao) > 0))
                        {
                            Classe = "bg-danger text-white font-weight-bold";

                            if (Model[i].Devolvido == true)
                            {
                                Classe = "bg-light text-dark";
                            }
                            else
                            {
                                Classe = "bg-danger text-white font-weight-bold";
                            }

                        }
                        else
                        {
                            Classe = "";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr scope=\"row\"");
            BeginWriteAttribute("class", " class=\"", 3863, "\"", 3878, 1);
#nullable restore
#line 94 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 3871, Classe, 3871, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td class=\"font-weight-bold\">");
#nullable restore
#line 95 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                    Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 96 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 97 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 98 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 99 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 100 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 102 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                 if (@Model[i].Devolvido == true && (System.DateTime.Compare(System.DateTime.Now,
                               Model[i].DataDevolucao)) < 0 || @Model[i].Devolvido == true &&
                               (System.DateTime.Compare(System.DateTime.Now, Model[i].DataDevolucao)) == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-success font-weight-bold\">Devolvido</p>\r\n");
#nullable restore
#line 107 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                 if (@Model[i].Devolvido == true && (System.DateTime.Compare(System.DateTime.Now,
                               Model[i].DataDevolucao)) > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-warning font-weight-bold\">Devolvido com Atraso</p>\r\n");
#nullable restore
#line 112 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                 if (Model[i].Devolvido == false && (System.DateTime.Compare(System.DateTime.Now,
                               Model[i].DataDevolucao)) < 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-info font-weight-bold\">Em espera</p>\r\n");
#nullable restore
#line 117 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                 if (Model[i].Devolvido == false && (System.DateTime.Compare(System.DateTime.Now,
                               Model[i].DataDevolucao)) > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"font-weight-bold\">Pendente</p>\r\n");
#nullable restore
#line 122 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 5905, "\"", 5943, 2);
            WriteAttributeValue("", 5912, "/Emprestimo/Edicao/", 5912, 19, true);
#nullable restore
#line 124 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 5931, Model[i].Id, 5931, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Editar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 126 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n");
#nullable restore
#line 128 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"dnre\">\r\n                    <p class=\"nre\">Nenhum registro encontrado.</p>\r\n                    <a class=\"btn btn-primary\" href=\"/Emprestimo/Cadastro\">Cadastrar Emprestimo</a>\r\n                </div>\r\n");
#nullable restore
#line 135 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n<div id=\"SeletorPaginas\" class=\"text-center\">\r\n    <span class=\"lead\">P??gina:</span>\r\n");
#nullable restore
#line 141 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
     for (int i = 1; i <= NumTotalDePag; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 6566, "\"", 6608, 2);
            WriteAttributeValue("", 6573, "/Emprestimo/Listagem?PaginaAtual=", 6573, 33, true);
#nullable restore
#line 144 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 6606, i, 6606, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" role=\"button\">");
#nullable restore
#line 144 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </span>\r\n");
#nullable restore
#line 146 "G:\Meu Drive\UC07\ATIVIDADE 01\Biblioteca\Views\Emprestimo\Listagem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
