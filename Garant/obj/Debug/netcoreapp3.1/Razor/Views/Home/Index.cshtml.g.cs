#pragma checksum "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9a58790e9acfea16bfe0f25bd72c195fd4009a9"
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
#line 1 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\_ViewImports.cshtml"
using Garant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\_ViewImports.cshtml"
using Garant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a58790e9acfea16bfe0f25bd72c195fd4009a9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8647bca0d96d677ed639d300136c69d4e32ab385", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("buttons buttons-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateDeal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Deals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"

<div class=""container-fluid text-center   "">


    <div class=""cont "">
        <div class=""row"">
            <div class=""mx-auto col-md-7 col-sm-12 text-gradient animated fadeInUp"">
                <h1>
                    Мы гарантируем вам 100% <br> сделку с минимальной <br> комиссией
                </h1>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12"">
");
#nullable restore
#line 21 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Home\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"button \">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9a58790e9acfea16bfe0f25bd72c195fd4009a95824", async() => {
                WriteLiteral("Перейти");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </button>\n");
#nullable restore
#line 26 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"button \">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9a58790e9acfea16bfe0f25bd72c195fd4009a97620", async() => {
                WriteLiteral("Перейти");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </button>\n");
#nullable restore
#line 32 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>

    </div>
    <div class=""container text-center "">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 mt-4 animated   "">
                <h1>
                    Что такое безопасная сделка?
                </h1>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 text mt-5 mb-5 animated "">
                <p>
                    Безопасная сделка – сервис защиты покупателя и продавца в интернете.
                    Безопасная сделка гарантирует 100% предоплату, которая хранится на счёте
                    гаранта ,
                    пока продавец не выполнит все свои обязательства, а покупатель не
                    получит товар или услугу.

                </p>
            </div>
        </div>
    </div>
    <hr>

    <div class=""container text-center mt-5"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12"">
                <h1>
                    Преимущества GarantD1mso
 ");
            WriteLiteral(@"               </h1>
            </div>
        </div>
        <div class=""row mt-5"">
            <div class=""col-md-4 col-sm-12"">
                <img src=""img/quality 1.png"" alt=""Качество"">
                <p class=""text mt-4"">Качественно</p>
            </div>
            <div class=""col-md-4 col-sm-12"">
                <img src=""img/surface1.png"" alt=""Безопасно"">
                <p class=""text mt-4"">Безопасно</p>
            </div>
            <div class=""col-md-4 col-sm-12"">
                <img src=""img/Анонимно.png"" alt=""Анонимно"">
                <p class=""text mt-4""> Анонимно</p>
            </div>
        </div>
    </div>
    <hr>


    <div class=""container text-center mt-5"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12"">
                <h1>
                    Сколько стоит безопасная сделка?
                </h1>
            </div>
        </div>
        <div class=""row mt-1"">
            <div class=""col-md-6 col-sm-12 "">
                <p class=""text mt-4"">Сумма сделк");
            WriteLiteral(@"и</p>
                <input type=""text"" id=""txtFirst""> </br>
            </div>
            <div class=""col-md-6 col-sm-12"">
                <p class=""text mt-4"">Комиссия</p>
                <input type=""text"" id=""txtResult"">
            </div>
        </div>

        <div class=""row"">
            <div class=""col-md-12 col-sm-12"">
                
                <button class=""button"" id=""btnOK"">
                    <a class=""buttons buttons-text"">Рассчитать</a>
                </button>

            </div>
        </div>
    </div>
</div>


<hr>
<div class=""container text-center mt-5"">
    <div class=""row"">
        <div class=""col-md-12 col-sm-12"">
            <h1>
                Как происходит безопасная сделка через гарант-сервис?
            </h1>
        </div>
    </div>
    <div class=""row mt-5"">
        <div class="" blockof mx-auto col-lg-2 col-md-5 col-sm-12"">
            <img src=""img/Как происходит сделка1.png"" alt=""Качество"">
            <p class=""text2 mt-4"">Продавец и покупатель договорились ");
            WriteLiteral(@"о безопасной сделке</p>
        </div>
        <div class="" blockof mx-auto col-lg-2  col-md-5 col-sm-12"">
            <img src=""img/Как происходит сделка 2.png"" alt=""Безопасно"">
            <p class=""text2 mt-4"">Покупатель переводит деньги на безопасный счет </p>
        </div>
        <div class="" blockof mx-auto col-lg-2 col-md-5 col-sm-12"">
            <img src=""img/Как происходит сделка3.png"" alt=""Анонимно"">
            <p class=""text2 mt-4""> Продавец осуществляет передачу товара или услуги покупателю</p>
        </div>
        <div class="" blockof mx-auto col-lg-2 col-md-5 col-sm-12"">
            <img src=""img/Как происходит сделка 3.png"" alt=""Анонимно"">
            <p class=""text2 mt-4"">
                Покупатель принимает товар, проверяет его соответствие условиям
                сделки
            </p>
        </div>
        <div class="" blockof mx-auto col-lg-2 col-md-5 col-sm-12"">
            <img src=""img/Как происходит сделка 5.png"" alt=""Анонимно"">
            <p class=""text2 mt-4"">
            ");
            WriteLiteral(@"    Сервис переводит деньги продавцу и завершает безопасную сделку
            </p>
        </div>
    </div>
</div>
<hr>
<div class=""container text-center mt-2"">
    <div class=""row"">
        <div class=""col-md-12 col-sm-12"">
            <h1>
                Наши группы
            </h1>
        </div>
    </div>
    <div class=""row mt-5"">
        <div class=""col-lg-3 col-md-5 col-sm-6 mt-5"">
            <p class=""text mt-4"">EnjoyMaloy</p>
        </div>
        <div class=""col-lg-3 col-md-5 col-sm-6 "">
            <a href=""https://vk.com/enjoymaloy"" target=""_blank"">
                <img src=""img/EnjoyMaloy.png""
                     alt=""EnjoyMaloy"">
            </a>
        </div>
        <div class=""col-lg-3 col-md-5 col-sm-6 second__img"">
            <a href=""https://vk.com/d1msolinostat"" target=""_blank"">
                <img src=""img/D1mso.png""
                     alt=""D1msolinostat"">
            </a>
        </div>
        <div class=""col-lg-3     col-md-5 col-sm-6 mt-5 "">
            <p class=""text mt");
            WriteLiteral("-4\">D1msolinostat</p>\n        </div>\n    </div>\n</div>\n\n");
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
