#pragma checksum "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a561146b6fa6638157eb5fea76ca71bb9a1ad9af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Form), @"mvc.1.0.view", @"/Views/Shared/_Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Form.cshtml", typeof(AspNetCore.Views_Shared__Form))]
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
#line 1 "D:\Study\Test\TFriend\TFriend\Views\_ViewImports.cshtml"
using TFriend;

#line default
#line hidden
#line 2 "D:\Study\Test\TFriend\TFriend\Views\_ViewImports.cshtml"
using TFriend.Models;

#line default
#line hidden
#line 3 "D:\Study\Test\TFriend\TFriend\Views\_ViewImports.cshtml"
using Main.Model;

#line default
#line hidden
#line 4 "D:\Study\Test\TFriend\TFriend\Views\_ViewImports.cshtml"
using General;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a561146b6fa6638157eb5fea76ca71bb9a1ad9af", @"/Views/Shared/_Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f4a8ada526e44e98e81feffd11d50643f6d8b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pl-3 pr-3 form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
  
    if (ViewBag.FormId != null)
    {

#line default
#line hidden
            BeginContext(46, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(54, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a561146b6fa6638157eb5fea76ca71bb9a1ad9af4230", async() => {
                BeginContext(251, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(265, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a561146b6fa6638157eb5fea76ca71bb9a1ad9af4624", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                BeginWriteTagHelperAttribute();
#line 10 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
               WriteLiteral(ViewBag.Template);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(301, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
AddHtmlAttributeValue("", 113, ViewBag.FormId, 113, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
AddHtmlAttributeValue("", 153, ViewBag.Url, 153, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 8 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
          WriteLiteral(ViewBag.Method);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("method", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "callback", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
AddHtmlAttributeValue("", 232, ViewBag.CallBack, 232, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(320, 47, true);
            WriteLiteral("\r\n        <script>\r\n           createToolTip(\"#");
            EndContext();
            BeginContext(368, 14, false);
#line 14 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
                      Write(ViewBag.FormId);

#line default
#line hidden
            EndContext();
            BeginContext(382, 88, true);
            WriteLiteral("\");\r\n            $(document).ready(function () {\r\n                \r\n                $(\"#");
            EndContext();
            BeginContext(471, 14, false);
#line 17 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
               Write(ViewBag.FormId);

#line default
#line hidden
            EndContext();
            BeginContext(485, 837, true);
            WriteLiteral(@""").submit(function (e) {
                    e.preventDefault();
                    if (!$(this).valid()) {
                        return false;
                    }
                    var options = {
                        type: 'POST',
                        async: false,
                        cache: false,
                        enctype: 'multipart/form-data',
                        processData: false,
                        contentType: ""application/x-www-form-urlencoded"",
                        success: function (resp) {
                            if (!resp.success) {
                                toastDanger(resp.msg);
                                return false;
                            }
                            toastSuccess(resp.msg);
                            var tableId = '");
            EndContext();
            BeginContext(1323, 15, false);
#line 35 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
                                      Write(ViewBag.TableId);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 34, true);
            WriteLiteral("\';\r\n\r\n                            ");
            EndContext();
            BeginContext(1373, 16, false);
#line 37 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
                       Write(ViewBag.CallBack);

#line default
#line hidden
            EndContext();
            BeginContext(1389, 503, true);
            WriteLiteral(@";
                        },
                        error: function (resp) {
                            toastDanger(""Please contact the developer"");
                        },
                        complete: function () {
                            hideSpinner();
                        }
                    };
                    showSpinner();
                    $(this).ajaxSubmit(options);
                    return false;
                })
            })
        </script>
");
            EndContext();
#line 52 "D:\Study\Test\TFriend\TFriend\Views\Shared\_Form.cshtml"
    }

#line default
#line hidden
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