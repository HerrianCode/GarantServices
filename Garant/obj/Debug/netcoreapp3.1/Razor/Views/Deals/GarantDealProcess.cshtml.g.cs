#pragma checksum "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12cffa2f723705d953212b67dc46f89a9bf785a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deals_GarantDealProcess), @"mvc.1.0.view", @"/Views/Deals/GarantDealProcess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cffa2f723705d953212b67dc46f89a9bf785a8", @"/Views/Deals/GarantDealProcess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8647bca0d96d677ed639d300136c69d4e32ab385", @"/Views/_ViewImports.cshtml")]
    public class Views_Deals_GarantDealProcess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 mb-3 button btn  btn-lg btn-block text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Deals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GarantDealProcess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container text-center text-gradient mt-5 mb-1\">\n    <h1>Активная сделка</h1>\n    <hr>\n</div>\n\n<span class=\"border border-primary\">\n    <div class=\"col-md-12 order-md-1\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12cffa2f723705d953212b67dc46f89a9bf785a85515", async() => {
                WriteLiteral("\n\n            <div class=\"mb-3\">\n                <label for=\"NameOfDeal\">Название сделки: ");
#nullable restore
#line 14 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                    Write(ViewBag.DealInfo.NameDeal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            </div>\n            <div class=\" mb-3\">\n                <label for=\"NumberOfDeal\">Номер заказа: ");
#nullable restore
#line 17 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                   Write(ViewBag.DealInfo.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            </div>\n            <div class=\"mb-3\">\n                <label for=\"Status\">Статус: ");
#nullable restore
#line 20 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml"
                                       Write(ViewBag.DealInfo.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            </div>\n            <div class=\"mb-3\">\n                <label for=\"DateOfCreate\">Дата создания: ");
#nullable restore
#line 23 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                    Write(ViewBag.DealInfo.DataCreated.ToString("d"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            </div>\n            <div class=\"mb-3\">\n                <label for=\"DateOfEnd\">Дата завершения: ");
#nullable restore
#line 26 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                   Write(ViewBag.DealInfo.DataFinish.ToString("d"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            </div>\n            <div class=\"mb-3\">\n                <label for=\"NameOfCreator\">Имя заказчика: ");
#nullable restore
#line 29 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                     Write(ViewBag.NameAuthor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            </div>\n            <div class=\"mb-3\">\n                <label for=\"Summ\">Сумма: ");
#nullable restore
#line 32 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml"
                                    Write(ViewBag.DealInfo.QurencySumma);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            </div>\n\n            <div class=\"mb-3\">\n                <label for=\"About\">Пояснение задачи</label>\n            </div>\n            <div class=\"row\">\n                <div class=\"mb-3\">\n                    ");
#nullable restore
#line 40 "C:\Users\эдем\Desktop\GarantServis.ASP.NET-master\Garant\Views\Deals\GarantDealProcess.cshtml"
               Write(ViewBag.DealInfo.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <br />
            </div>
            <div class=""row"">
                <div class=""col-md-3""> </div>
                <button class=""col-md-2 mb-3 button btn  btn-lg btn-block text-center"" type=""submit"">Завершить заказ</button>
                <div class=""col-md-1""> </div>
                <button class=""col-md-2 mb-3 button btn  btn-lg btn-block text-center"" type=""submit"">Отменить заказ</button>
                <div class=""col-md-1""> </div>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12cffa2f723705d953212b67dc46f89a9bf785a89667", async() => {
                    WriteLiteral("Перейти в ЛС");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</span>\n\n\n\n\n\n\n");
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
