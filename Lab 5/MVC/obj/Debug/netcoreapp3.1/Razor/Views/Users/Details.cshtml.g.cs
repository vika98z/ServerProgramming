#pragma checksum "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1bf6f494b783ae51f3b69bdccdee4cf3f4c7daa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
#line 1 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1bf6f494b783ae51f3b69bdccdee4cf3f4c7daa", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b2584a0f305912f282c929283661d4ff97bacf", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid gedf-wrapper"">
    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""image mb-2""><img class=""rounded-circle"" width=""150""");
            BeginWriteAttribute("src", " src=\"", 373, "\"", 391, 1);
#nullable restore
#line 13 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
WriteAttributeValue("", 379, Model.Image, 379, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 392, "\"", 398, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                    <div class=\"h5\">");
#nullable restore
#line 14 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
                               Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>\r\n                        <span class=\"h7 text-muted\">");
            WriteLiteral("@");
#nullable restore
#line 16 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
                                                 Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <button class=\"btn btn-primary btn-sm ml-3\" type=\"button\">Follow</button>\r\n                    </div>\r\n                    <div class=\"h7\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
                   Write(Model.Biography);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <ul class=""list-group list-group-flush"">
                    <li class=""list-group-item"">
                        <div class=""h6 text-muted"">Followers</div>
                        <div class=""h5"">");
#nullable restore
#line 26 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
                                   Write(Model.FollowersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </li>\r\n                    <li class=\"list-group-item\">\r\n                        <div class=\"h6 text-muted\">Following</div>\r\n                        <div class=\"h5\">");
#nullable restore
#line 30 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
                                   Write(Model.FollowingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </li>
                </ul>
            </div>
        </div>

        <div class=""col-md-6 gedf-main"">
            <!--- UserPage -->
            <div class=""card gedf-card"">
                <div class=""card-header"">
                    <ul class=""nav nav-tabs card-header-tabs"" id=""myTab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""posts-tab"" data-toggle=""tab"" href=""#posts"" role=""tab""
                               aria-controls=""posts"" aria-selected=""true"">
                                Make
                                a publication
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""images-tab"" data-toggle=""tab"" role=""tab"" aria-controls=""images""
                               aria-selected=""false"" href=""#images"">Images</a>
                        </li>
                 ");
            WriteLiteral(@"   </ul>
                </div>
                <div class=""card-body"">
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""posts"" role=""tabpanel""
                             aria-labelledby=""posts-tab"">
                            <div class=""form-group"">
                                <label class=""sr-only"" for=""message"">post</label>
                                <textarea class=""form-control"" id=""message"" rows=""3""
                                          placeholder=""What are you thinking?""></textarea>
                            </div>

                        </div>
                        <div class=""tab-pane fade"" id=""images"" role=""tabpanel"" aria-labelledby=""images-tab"">
                            <div class=""form-group"">
                                <div class=""custom-file"">
                                    <input type=""file"" class=""custom-file-input"" id=""customFile"">
                           ");
            WriteLiteral(@"         <label class=""custom-file-label"" for=""customFile"">Upload image</label>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""sr-only"" for=""message"">post</label>
                                <textarea class=""form-control"" id=""message"" rows=""1""
                                          placeholder=""What are you thinking?""></textarea>
                            </div>
                        </div>
                    </div>
                    <div class=""btn-toolbar justify-content-between"">
                        <div class=""btn-group"">
                            <button type=""submit"" class=""btn btn-primary"">Share</button>
                        </div>
                        <div class=""btn-group"">
                            <button id=""btnGroupDrop1"" type=""button"" class=""btn btn-link dropdown-toggle""
                                    data-toggle=""dropdown""");
            WriteLiteral(@" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fa fa-globe""></i>
                            </button>
                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""btnGroupDrop1"">
                                <a class=""dropdown-item"" href=""#""><i class=""fa fa-globe""></i> Public</a>
                                <a class=""dropdown-item"" href=""#""><i class=""fa fa-users""></i> Friends</a>
                                <a class=""dropdown-item"" href=""#""><i class=""fa fa-user""></i> Just me</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- UserPage -->

");
#nullable restore
#line 99 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
             foreach (var post in Model.Posts.FindAll(x => x.Author.UserId == @Model.UserId))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
           Write(Html.Partial("_PostCard", post));

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\stety\Documents\ServerProgramming\Lab 5\MVC\Views\Users\Details.cshtml"
                                                ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
