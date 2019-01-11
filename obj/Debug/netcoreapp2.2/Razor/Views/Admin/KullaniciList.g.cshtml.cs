#pragma checksum "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e7f6476810973492361bc63b75c8ccb610a6a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_KullaniciList), @"mvc.1.0.view", @"/Views/Admin/KullaniciList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/KullaniciList.cshtml", typeof(AspNetCore.Views_Admin_KullaniciList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e7f6476810973492361bc63b75c8ccb610a6a83", @"/Views/Admin/KullaniciList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b78e6739f3da655871799a821921bbaa06e1839", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_KullaniciList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kullanici>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KullaniciEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KullaniciDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
  
    Layout="~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(78, 220, true);
            WriteLiteral("\n<div class=\"container\">\n    <h2>Kullanici List</h2>\n    <hr />\n    <div>\n        <a class=\"btn btn-primary\" href=\"/Admin/KullaniciCreate\">Create</a>\n    </div>\n    <hr />\n    <div class=\"row\">\n        <div class=\"col\">\n");
            EndContext();
#line 15 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
             if(Model.Count()>0)
            {

#line default
#line hidden
            BeginContext(345, 506, true);
            WriteLiteral(@"                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Username</th>
                            <th>Password</th>
                            <th>Ad</th>
                            <th>Soyad</th>
                            <th>Mail</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 30 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                         foreach (Kullanici kullanici in Model)
                        {

#line default
#line hidden
            BeginContext(941, 69, true);
            WriteLiteral("                            <tr>\n                                <td>");
            EndContext();
            BeginContext(1011, 21, false);
#line 33 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                               Write(kullanici.kullaniciID);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(1075, 18, false);
#line 34 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                               Write(kullanici.username);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(1136, 18, false);
#line 35 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                               Write(kullanici.password);

#line default
#line hidden
            EndContext();
            BeginContext(1154, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(1197, 12, false);
#line 36 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                               Write(kullanici.ad);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(1252, 15, false);
#line 37 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                               Write(kullanici.soyad);

#line default
#line hidden
            EndContext();
            BeginContext(1267, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(1310, 14, false);
#line 38 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                               Write(kullanici.mail);

#line default
#line hidden
            EndContext();
            BeginContext(1324, 112, true);
            WriteLiteral("</td>\n                                \n                                <td>\n                                    ");
            EndContext();
            BeginContext(1436, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e7f6476810973492361bc63b75c8ccb610a6a838332", async() => {
                BeginContext(1558, 85, true);
                WriteLiteral("\n                                        Details\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                                                                                                                          WriteLiteral(kullanici.kullaniciID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1647, 37, true);
            WriteLiteral("\n                                    ");
            EndContext();
            BeginContext(1684, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e7f6476810973492361bc63b75c8ccb610a6a8311111", async() => {
                BeginContext(1807, 84, true);
                WriteLiteral("\n                                        Delete\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                                                                                                                           WriteLiteral(kullanici.kullaniciID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1895, 110, true);
            WriteLiteral("\n                                    \n                                </td>\n                            </tr>\n");
            EndContext();
#line 50 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
                        }

#line default
#line hidden
            BeginContext(2031, 54, true);
            WriteLiteral("                    </tbody>\n                </table>\n");
            EndContext();
#line 53 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2130, 106, true);
            WriteLiteral("                <div class=\"alert alert-danger\">\n                    Kullanici Yok\n                </div>\n");
            EndContext();
#line 59 "/home/mustafa/Desktop/KoksHamit/Views/Admin/KullaniciList.cshtml"
            }

#line default
#line hidden
            BeginContext(2250, 32, true);
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kullanici>> Html { get; private set; }
    }
}
#pragma warning restore 1591
