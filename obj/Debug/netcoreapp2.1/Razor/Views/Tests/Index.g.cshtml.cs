#pragma checksum "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c003a45f5dfed5183940e5a5c7ef3478fdbc16a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tests_Index), @"mvc.1.0.view", @"/Views/Tests/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tests/Index.cshtml", typeof(AspNetCore.Views_Tests_Index))]
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
#line 1 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\_ViewImports.cshtml"
using SportsApp;

#line default
#line hidden
#line 2 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\_ViewImports.cshtml"
using SportsApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c003a45f5dfed5183940e5a5c7ef3478fdbc16a4", @"/Views/Tests/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29803cf5ad0215661363923a75a503b0b025185d", @"/Views/_ViewImports.cshtml")]
    public class Views_Tests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SportsApp.Models.Test>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 78, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n    function Click(id){\r\n         var url = \'");
            EndContext();
            BeginContext(165, 52, false);
#line 8 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
               Write(Url.Action("Index","TestDetails",new { id = "_id_"}));

#line default
#line hidden
            EndContext();
            BeginContext(217, 173, true);
            WriteLiteral("\';\r\n         window.location.href = url.replace(\'_id_\',id);\r\n    }\r\n</script>\r\n    <div class=\"col-md-2\">\r\n\r\n    </div>\r\n\r\n    <div class=\"col-md-8\">\r\n        \r\n            ");
            EndContext();
            BeginContext(390, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98f548814ed9464d9cc123ee4569f5f7", async() => {
                BeginContext(438, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(452, 146, true);
            WriteLiteral("\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(599, 40, false);
#line 23 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(639, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(731, 53, false);
#line 26 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.NumOfParticipants));

#line default
#line hidden
            EndContext();
            BeginContext(784, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(876, 44, false);
#line 29 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.TestType));

#line default
#line hidden
            EndContext();
            BeginContext(920, 111, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
            BeginContext(1106, 27, true);
            WriteLiteral("                        <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1133, "\"", 1162, 3);
            WriteAttributeValue("", 1143, "Click(", 1143, 6, true);
#line 37 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
WriteAttributeValue("", 1149, item.TestId, 1149, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1161, ")", 1161, 1, true);
            EndWriteAttribute();
            BeginContext(1163, 69, true);
            WriteLiteral(">\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1233, 39, false);
#line 39 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1376, 52, false);
#line 42 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NumOfParticipants));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1532, 43, false);
#line 45 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TestType));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\rahulmondal\source\repos\SportsApp\SportsApp\Views\Tests\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1666, 116, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        \r\n    </div>\r\n      <div class=\"col-md-2\">\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SportsApp.Models.Test>> Html { get; private set; }
    }
}
#pragma warning restore 1591
