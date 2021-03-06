#pragma checksum "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e92d160bab6e0720336e3b9193d7e62dedbda0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Api_Exchange), @"mvc.1.0.view", @"/Views/Api/Exchange.cshtml")]
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
#line 1 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/_ViewImports.cshtml"
using forex_converter_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/_ViewImports.cshtml"
using forex_converter_mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
using forex_converter_mvc.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
using forex_converter_mvc.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e92d160bab6e0720336e3b9193d7e62dedbda0b", @"/Views/Api/Exchange.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e07143590db150df459ae8c049d7ade94812d9e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Api_Exchange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValueCalculator>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("step", new global::Microsoft.AspNetCore.Html.HtmlString("0.01"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
  ViewData["Title"] = "Exchange Rates"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Currency Converter</h1>
    <p>Built with ASP.NET Core MVC using <a href=""https://developer.sebgroup.com/products"">SEB Foreign Exchange Rates API</a>.</p>
</div>



<br>

<!--disable scroll wheel in <input type=""number"" />-->
<style>
    input::-webkit-outer-spin-button,
    input::-webkit-inner-spin-button {
        -webkit-appearance: none;
        margin: 0;
    }
</style>



");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e92d160bab6e0720336e3b9193d7e62dedbda0b6728", async() => {
                WriteLiteral(@"

    <!--Label-->
    <span style=""position:relative; display:inline-block; margin-left: 51%; padding: 4px; width:auto;"">
        Currency from:
    </span>

    <!--""Amount"" input-->
    <span class=""form-group"" style=""position:relative; display:inline-block; margin-left: 20%; padding: 4px; width:30%;"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e92d160bab6e0720336e3b9193d7e62dedbda0b7304", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 35 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Amount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1047, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 36 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
                             if (TempData.ContainsKey("ValueCalculator"))
                            {
                                var v = TempData.Get<ValueCalculator>("ValueCalculator");
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
                           Write(v.Amount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
                                         ;
                            }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 1047, 238, false);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </span>\n\n    <!--\"Currency from\" input-->\n    <span style=\"position:relative; display:inline-block; margin-left: auto; padding: 4px; width:30%;\">\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e92d160bab6e0720336e3b9193d7e62dedbda0b11267", async() => {
                    WriteLiteral("\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e92d160bab6e0720336e3b9193d7e62dedbda0b11544", async() => {
                        WriteLiteral("\n");
#nullable restore
#line 47 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
                 if (TempData.ContainsKey("ValueCalculator"))
                {
                    var v = TempData.Get<ValueCalculator>("ValueCalculator");
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
               Write(v.CF);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
                         ;
                }

#line default
#line hidden
#nullable disable
                        WriteLiteral("            ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 45 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CurrencyFrom);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 45 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = new SelectList(ViewBag.CurrenciesFrom);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </span>




    <!--Label-->
    <span style=""position:relative; display:inline-block; margin-left: 51%; padding: 4px; width:auto;"">
        Currency to:
    </span>

    <!--Exchange output-->
    <span class=""form-group"" style=""position: relative; display: inline-block; margin-left: 20%; padding: 4px; width: 30%; border: 1px solid LightGray;"">
");
#nullable restore
#line 66 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
         if (TempData.ContainsKey("ValueCalculator"))
        {
            var v = TempData.Get<ValueCalculator>("ValueCalculator");
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
       Write(v.ResultAmount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
                           ;
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        &nbsp\n    </span>\n\n    <!--\"Currency to\" input-->\n    <span style=\"position:relative; display:inline-block; margin-left: auto; padding: 4px; width:30%;\">\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e92d160bab6e0720336e3b9193d7e62dedbda0b17318", async() => {
                    WriteLiteral("\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e92d160bab6e0720336e3b9193d7e62dedbda0b17595", async() => {
                        WriteLiteral("\n");
#nullable restore
#line 78 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
                 if (TempData.ContainsKey("ValueCalculator"))
                {
                    var v = TempData.Get<ValueCalculator>("ValueCalculator");
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
               Write(v.CT);

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
                         ;
                }

#line default
#line hidden
#nullable disable
                        WriteLiteral("            ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 76 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CurrencyTo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 76 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = new SelectList(ViewBag.CurrenciesTo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </span>\n\n\n\n    <!--Date output-->\n    <br>\n    <span style=\"position: relative; display: inline-block; margin-left: 20%; padding: 4px; width: 30%;\">\n");
#nullable restore
#line 92 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
         if (TempData.ContainsKey("ValueCalculator"))
        {
            var v = TempData.Get<ValueCalculator>("ValueCalculator");

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h>\n                Exchange rate updated: ");
#nullable restore
#line 96 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
                                  Write(v.date);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </h>\n");
#nullable restore
#line 99 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
             if (ApiController.ErrorMessage != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <hr>\n                <h>\n                    ");
#nullable restore
#line 103 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
               Write(ApiController.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("                 \n                </h>\n");
#nullable restore
#line 105 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </span>\n\n    <!--Button-->\n    <button class=\"btn-primary\" type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3568, "\"", 3630, 4);
                WriteAttributeValue("", 3578, "await", 3578, 5, true);
                WriteAttributeValue(" ", 3583, "location.href=\'", 3584, 16, true);
#nullable restore
#line 110 "/Users/jonasdeksnys/Desktop/_programming/forex_converter_mvc/forex_converter_mvc/Views/Api/Exchange.cshtml"
WriteAttributeValue("", 3599, Url.Action("Exchange", "Api"), 3599, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3629, "\'", 3629, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"Convert\" style=\"position:relative; display:inline-block; margin-left: auto\" ;>Convert</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ValueCalculator> Html { get; private set; }
    }
}
#pragma warning restore 1591
