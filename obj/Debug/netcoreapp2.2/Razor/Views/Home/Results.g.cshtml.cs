#pragma checksum "/home/dmkrebsbach/CodingDojo/CSharp/ASP/dojoSurveyModel/Views/Home/Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edbe99e772a1405636e7d00d7b49e582ef1be65c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Results.cshtml", typeof(MyApp.Namespace.Home.Views_Home_Results))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "/home/dmkrebsbach/CodingDojo/CSharp/ASP/dojoSurveyModel/Views/_ViewImports.cshtml"
using dojoSurveyModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edbe99e772a1405636e7d00d7b49e582ef1be65c", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468a01806d616bd6b60a894fa808b1499895c604", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dojoSurveyModel.Models.Survey>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\t");
            EndContext();
            BeginContext(34, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edbe99e772a1405636e7d00d7b49e582ef1be65c4090", async() => {
                BeginContext(40, 75, true);
                WriteLiteral("\n    \t<title>Survey Results</title>\n        <meta charset=\"utf-8\">\n        ");
                EndContext();
                BeginContext(115, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "edbe99e772a1405636e7d00d7b49e582ef1be65c4543", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(161, 2, true);
                WriteLiteral("\n\t");
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
            BeginContext(170, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(175, 759, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edbe99e772a1405636e7d00d7b49e582ef1be65c6640", async() => {
                BeginContext(181, 146, true);
                WriteLiteral("\n        <!-- This information is displayed ONLY for the Survey Class -->\n        <div class=\"container\">  \n            <div class=\"displayInfo\">\n");
                EndContext();
                BeginContext(381, 88, true);
                WriteLiteral("                <h3>Info Submitted by User:</h3>\n                <p><span>Name:</span>  ");
                EndContext();
                BeginContext(470, 10, false);
#line 14 "/home/dmkrebsbach/CodingDojo/CSharp/ASP/dojoSurveyModel/Views/Home/Results.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(480, 53, true);
                WriteLiteral("</p>\n                <p><span>Dojo Location:</span>  ");
                EndContext();
                BeginContext(534, 10, false);
#line 15 "/home/dmkrebsbach/CodingDojo/CSharp/ASP/dojoSurveyModel/Views/Home/Results.cshtml"
                                           Write(Model.Dojo);

#line default
#line hidden
                EndContext();
                BeginContext(544, 57, true);
                WriteLiteral("</p>\n                <p><span>Favorite Language:</span>  ");
                EndContext();
                BeginContext(602, 14, false);
#line 16 "/home/dmkrebsbach/CodingDojo/CSharp/ASP/dojoSurveyModel/Views/Home/Results.cshtml"
                                               Write(Model.Language);

#line default
#line hidden
                EndContext();
                BeginContext(616, 47, true);
                WriteLiteral("</p>\n                <p><span>Comment:</span>  ");
                EndContext();
                BeginContext(664, 13, false);
#line 17 "/home/dmkrebsbach/CodingDojo/CSharp/ASP/dojoSurveyModel/Views/Home/Results.cshtml"
                                     Write(Model.Comment);

#line default
#line hidden
                EndContext();
                BeginContext(677, 250, true);
                WriteLiteral("</p>\n                <a href=\"/\">Return to Form!!!</a>\n            </div>\n        </div>\n        <!-- Information displayed for any other class would required a new Div that displays\n            specifically for the Models.className -->\n        \n    ");
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
            BeginContext(934, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dojoSurveyModel.Models.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
