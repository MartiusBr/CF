#pragma checksum "C:\Users\diox_\Desktop\Nueva carpeta\orchard\OrchardSite\OrchardSite\Pages\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c8dcc0930ab07bb4e2c1e2328c3718332b3d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages__Layout), @"mvc.1.0.view", @"/Pages/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/_Layout.cshtml", typeof(AspNetCore.Pages__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c8dcc0930ab07bb4e2c1e2328c3718332b3d04", @"/Pages/_Layout.cshtml")]
    public class Pages__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            EndContext();
            BeginContext(34, 882, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46c8dcc0930ab07bb4e2c1e2328c3718332b3d042891", async() => {
                BeginContext(40, 869, true);
                WriteLiteral(@"

  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
  <meta name=""description"" content="""">
  <meta name=""author"" content="""">

  <title>Clean Blog - Start Bootstrap Theme</title>

  <!-- Bootstrap core CSS -->
  <link href=""vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

  <!-- Custom fonts for this template -->
  <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
  <link href='https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
  <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>

  <!-- Custom styles for this template -->
  <link href=""css/clean-blog.min.css"" rel=""stylesheet"">

");
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
            BeginContext(916, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(918, 2606, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46c8dcc0930ab07bb4e2c1e2328c3718332b3d044968", async() => {
                BeginContext(924, 1072, true);
                WriteLiteral(@"

  <!-- Navigation -->
  <nav class=""navbar navbar-expand-lg navbar-light fixed-top"" id=""mainNav"">
    <div class=""container"">
      <a class=""navbar-brand"" href=""index.html"">Start Bootstrap</a>
      <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        Menu
        <i class=""fas fa-bars""></i>
      </button>
      <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
        <ul class=""navbar-nav ml-auto"">
          <li class=""nav-item"">
            <a class=""nav-link"" href=""index.html"">Home</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""about.html"">About</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""post.html"">Sample Post</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""contact.html"">Contact</a>
          </li>
  ");
                WriteLiteral("      </ul>\n      </div>\n    </div>\n  </nav>\n\n  ");
                EndContext();
                BeginContext(1997, 12, false);
#line 55 "C:\Users\diox_\Desktop\Nueva carpeta\orchard\OrchardSite\OrchardSite\Pages\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2009, 1508, true);
                WriteLiteral(@"

  <!-- Footer -->
  <footer>
    <div class=""container"">
      <div class=""row"">
        <div class=""col-lg-8 col-md-10 mx-auto"">
          <ul class=""list-inline text-center"">
            <li class=""list-inline-item"">
              <a href=""#"">
                <span class=""fa-stack fa-lg"">
                  <i class=""fas fa-circle fa-stack-2x""></i>
                  <i class=""fab fa-twitter fa-stack-1x fa-inverse""></i>
                </span>
              </a>
            </li>
            <li class=""list-inline-item"">
              <a href=""#"">
                <span class=""fa-stack fa-lg"">
                  <i class=""fas fa-circle fa-stack-2x""></i>
                  <i class=""fab fa-facebook-f fa-stack-1x fa-inverse""></i>
                </span>
              </a>
            </li>
            <li class=""list-inline-item"">
              <a href=""#"">
                <span class=""fa-stack fa-lg"">
                  <i class=""fas fa-circle fa-stack-2x""></i>
                  <i class=""fab fa-github fa-stack-");
                WriteLiteral(@"1x fa-inverse""></i>
                </span>
              </a>
            </li>
          </ul>
          <p class=""copyright text-muted"">Copyright &copy; Your Website 2019</p>
        </div>
      </div>
    </div>
  </footer>

  <!-- Bootstrap core JavaScript -->
  <script src=""vendor/jquery/jquery.min.js""></script>
  <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

  <!-- Custom scripts for this template -->
  <script src=""js/clean-blog.min.js""></script>

");
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
            BeginContext(3524, 10, true);
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
