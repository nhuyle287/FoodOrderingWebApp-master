#pragma checksum "D:\Học tập\Năm 3\HKVI\framework\Đồ án\FoodOrderingWebApp-master\FoodOrderingWebApp\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea4cbed98acdb70d482926e31b53d9de0b9400bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "D:\Học tập\Năm 3\HKVI\framework\Đồ án\FoodOrderingWebApp-master\FoodOrderingWebApp\Views\_ViewImports.cshtml"
using FoodOrderingWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Học tập\Năm 3\HKVI\framework\Đồ án\FoodOrderingWebApp-master\FoodOrderingWebApp\Views\_ViewImports.cshtml"
using FoodOrderingWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea4cbed98acdb70d482926e31b53d9de0b9400bd", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05b1a04763ebca66ec179083c96e7b1b7217068", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\Học tập\Năm 3\HKVI\framework\Đồ án\FoodOrderingWebApp-master\FoodOrderingWebApp\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/LayoutClient.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- =====  CONTAINER START  ===== -->
<div class=""container"">
    <div class=""row "">
        <!-- =====  BANNER STRAT  ===== -->
        <div class=""col-sm-12"">
            <div class=""breadcrumb ptb_20"">
                <h1>Login</h1>
                <ul>
                    <li><a href=""index.html"">Home</a></li>
                    <li class=""active"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4cbed98acdb70d482926e31b53d9de0b9400bd5758", async() => {
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                </ul>
            </div>
        </div>
        <!-- =====  BREADCRUMB END===== -->
        <div id=""column-left"" class=""col-sm-4 col-lg-3 hidden-xs"">
            <div id=""category-menu"" class=""navbar collapse in mb_40"" aria-expanded=""true""");
            BeginWriteAttribute("style", " style=\"", 739, "\"", 747, 0);
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
                <div class=""nav-responsive"">
                    <div class=""heading-part"">
                        <h2 class=""main_title"">Top category</h2>
                    </div>
                    <ul class=""nav  main-navigation collapse in"">
                        <li><a href=""#"">Appliances</a></li>
                        <li><a href=""#"">Mobile Phones</a></li>
                        <li><a href=""#"">Tablet PC & Accessories</a></li>
                        <li><a href=""#"">Consumer Electronics</a></li>
                        <li><a href=""#"">Computers & Networking</a></li>
                        <li><a href=""#"">Electrical & Tools</a></li>
                        <li><a href=""#"">Apparel</a></li>
                        <li><a href=""#"">Bags & Shoes</a></li>
                        <li><a href=""#"">Toys & Hobbies</a></li>
                        <li><a href=""#"">Watches & Jewelry</a></li>
                        <li><a href=""#"">Home & Garden</a></li>
                        <li><a href=""#""");
            WriteLiteral(@">Health & Beauty</a></li>
                        <li><a href=""#"">Outdoors & Sports</a></li>
                    </ul>
                </div>
            </div>
            <div class=""left_banner left-sidebar-widget mt_30 mb_40""> <a href=""#""><img src=""images/left1.jpg"" alt=""Left Banner"" class=""img-responsive"" /></a> </div>
        </div>
        <div class=""col-sm-8 col-lg-9 mtb_20"">
            <!-- contact  -->
            <div class=""row"">
                <div class=""col-md-6 col-md-offset-3"">
                    <div class=""panel-login panel"">
                        <div class=""panel-heading"">
                            <div class=""row mb_20"">
                                <div class=""col-xs-6"">
                                    <a href=""#"" class=""active"" id=""login-form-link"">Login</a>
                                </div>
                                <div class=""col-xs-6"">
                                    <a href=""#"" id=""register-form-link"">Register</a>
                                </div");
            WriteLiteral(@">
                            </div>
                            <hr>
                        </div>
                        <div class=""panel-body"">
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4cbed98acdb70d482926e31b53d9de0b9400bd9800", async() => {
                WriteLiteral("\n                                        <div class=\"form-group\">\n                                            <input type=\"text\" name=\"username\" id=\"username1\" tabindex=\"1\" class=\"form-control\" placeholder=\"Username\"");
                BeginWriteAttribute("value", " value=\"", 3347, "\"", 3355, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""password"" name=""password"" id=""password"" tabindex=""2"" class=""form-control"" placeholder=""Password"">
                                        </div>
                                        <div class=""form-group text-center"">
                                            <input type=""checkbox"" tabindex=""3""");
                BeginWriteAttribute("class", " class=\"", 3828, "\"", 3836, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""remember"" id=""remember"">
                                            <label for=""remember""> Remember Me</label>
                                        </div>
                                        <div class=""form-group"">
                                            <div class=""row"">
                                                <div class=""col-sm-6 col-sm-offset-3"">
                                                    <input type=""submit"" name=""login-submit"" id=""login-submit"" tabindex=""4"" class=""form-control btn btn-login"" value=""Log In"">
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            <div class=""row"">
                                                <div class=""col-lg-12"">
                                                    <div class=""text-center"">
                                       ");
                WriteLiteral(@"                 <a href=""#"" tabindex=""5"" class=""forgot-password"">Forgot Password?</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4cbed98acdb70d482926e31b53d9de0b9400bd13894", async() => {
                WriteLiteral("\n                                        <div class=\"form-group\">\n                                            <input type=\"text\" name=\"username\" id=\"username\" tabindex=\"1\" class=\"form-control\" placeholder=\"Username\"");
                BeginWriteAttribute("value", " value=\"", 5505, "\"", 5513, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""email"" name=""email"" id=""email"" tabindex=""1"" class=""form-control"" placeholder=""Email Address""");
                BeginWriteAttribute("value", " value=\"", 5777, "\"", 5785, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""password"" name=""password"" id=""password2"" tabindex=""2"" class=""form-control"" placeholder=""Password"">
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""password"" name=""confirm-password"" id=""confirm-password"" tabindex=""2"" class=""form-control"" placeholder=""Confirm Password"">
                                        </div>
                                        <div class=""form-group"">
                                            <div class=""row"">
                                                <div class=""col-sm-6 col-sm-offset-3"">
                                                    <input type=""submit"" name=""register-submit"" id=""register-submit"" tabindex=""4"" class=""form-control btn btn-register"" value=""Register Now"">
            ");
                WriteLiteral("                                    </div>\n                                            </div>\n                                        </div>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
  </div>
<!-- Single Blog  -->
<!-- End Blog   -->
<!-- =====  CONTAINER END  ===== -->
");
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