#pragma checksum "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4c9988a33c52c1f816d46542bb8f96f2e62d02e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Gallery), @"mvc.1.0.view", @"/Views/Book/Gallery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Gallery.cshtml", typeof(AspNetCore.Views_Book_Gallery))]
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
#line 1 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#line 2 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#line 3 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c9988a33c52c1f816d46542bb8f96f2e62d02e", @"/Views/Book/Gallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebfb66dd7688adb2b874a32236680b170c920090", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Gallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GalleryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/books/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/product/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
  
    ViewData["Title"] = "GalleryN";
    Layout = "_LayoutN";

#line default
#line hidden
            BeginContext(95, 281, true);
            WriteLiteral(@"
<!-- Start Bradcaump area -->
<div class=""ht__bradcaump__area bg-image--6"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""bradcaump__inner text-center"">
                    <h2 class=""bradcaump-title"">");
            EndContext();
            BeginContext(377, 17, false);
#line 13 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(394, 262, true);
            WriteLiteral(@"</h2>
                    <nav class=""bradcaump-content"">
                        <a class=""breadcrumb_item"" href=""index.html"">Home</a>
                        <span class=""brd-separetor"">/</span>
                        <span class=""breadcrumb_item active"">");
            EndContext();
            BeginContext(657, 17, false);
#line 17 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                                        Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(674, 637, true);
            WriteLiteral(@"</span>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Bradcaump area -->
<!-- Start Shop Page -->
<div class=""page-shop-sidebar left--sidebar bg--white section-padding--lg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-12 order-2 order-lg-1 md-mt-40 sm-mt-40"">
                <div class=""shop__sidebar"">
                    <aside class=""wedget__categories poroduct--cat"">
                        <h3 class=""wedget__title"">Product Categories</h3>
                        <ul>
                            <li>");
            EndContext();
            BeginContext(1311, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f014db8770947418783ea53060e3441", async() => {
                BeginContext(1329, 9, true);
                WriteLiteral("All Books");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1342, 35, true);
            WriteLiteral("</li>\r\n                            ");
            EndContext();
            BeginContext(1378, 61, false);
#line 35 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                       Write(await Html.PartialAsync("_CategorySideBar", Model.Categories));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 359, true);
            WriteLiteral(@"
                        </ul>
                    </aside>
                    <aside class=""wedget__categories pro--range"">
                        <h3 class=""wedget__title"">Filter by price</h3>
                        <div class=""content-shopby"">
                            <div class=""price_filter s-filter clear"">
                                ");
            EndContext();
            BeginContext(1798, 813, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8a135109f3747b885db17e8b5937d58", async() => {
                BeginContext(1828, 776, true);
                WriteLiteral(@"
                                    <div id=""slider-range""></div>
                                    <div class=""slider__range--output"">
                                        <div class=""price__output--wrap"">
                                            <div class=""price--output"">
                                                <span>Price :</span><input type=""text"" id=""amount"" readonly="""">
                                            </div>
                                            <div class=""price--filter"">
                                                <a href=""#"">Filter</a>
                                            </div>
                                        </div>
                                    </div>
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2611, 1648, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </aside>
                    <aside class=""wedget__categories poroduct--tag"">
                        <h3 class=""wedget__title"">Product Tags</h3>
                        <ul>
                            <li><a href=""#"">Biography</a></li>
                            <li><a href=""#"">Business</a></li>
                            <li><a href=""#"">Cookbooks</a></li>
                            <li><a href=""#"">Health & Fitness</a></li>
                            <li><a href=""#"">History</a></li>
                        </ul>
                    </aside>
                </div>
            </div>
            <div class=""col-lg-9 col-12 order-1 order-lg-2"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""shop__list__wrapper d-flex flex-wrap flex-md-nowrap justify-content-between"">
                            <div class=""shop__list nav justify-conten");
            WriteLiteral(@"t-center"" role=""tablist"">
                                <a class=""nav-item nav-link active"" data-toggle=""tab"" href=""#nav-grid"" role=""tab""><i class=""fa fa-th""></i></a>
                                <a class=""nav-item nav-link"" data-toggle=""tab"" href=""#nav-list"" role=""tab""><i class=""fa fa-list""></i></a>
                            </div>
                            <p>Showing 1–12 of 40 results</p>
                            <div class=""orderby__wrapper"">
                                <span>Sort By</span>
                                <select class=""shot__byselect"">
                                    ");
            EndContext();
            BeginContext(4259, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb4054db086465da6d55fc176e3362a", async() => {
                BeginContext(4267, 15, true);
                WriteLiteral("Default sorting");
                EndContext();
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
            EndContext();
            BeginContext(4291, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4329, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c5907024bbd4aa6a03484d0eae9b83d", async() => {
                BeginContext(4337, 9, true);
                WriteLiteral("HeadPhone");
                EndContext();
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
            EndContext();
            BeginContext(4355, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4393, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9223b98c8b4249f3bf01fc8aaeee3eb9", async() => {
                BeginContext(4401, 9, true);
                WriteLiteral("Furniture");
                EndContext();
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
            EndContext();
            BeginContext(4419, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4457, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "637f50f1203e4dbe80b8e7e2888e8469", async() => {
                BeginContext(4465, 9, true);
                WriteLiteral("Jewellery");
                EndContext();
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
            EndContext();
            BeginContext(4483, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4521, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f0b9c8e009246d2903327807efc52b6", async() => {
                BeginContext(4529, 8, true);
                WriteLiteral("Handmade");
                EndContext();
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
            EndContext();
            BeginContext(4546, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4584, 21, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a09469b1fd944e8da0baa30c68450d99", async() => {
                BeginContext(4592, 4, true);
                WriteLiteral("Kids");
                EndContext();
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
            EndContext();
            BeginContext(4605, 355, true);
            WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""tab__container"">
                    <div class=""shop-grid tab-pane fade show active"" id=""nav-grid"" role=""tabpanel"">
                        <div class=""row"">
");
            EndContext();
#line 96 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                             foreach (var item in Model.Books)
                            {

#line default
#line hidden
            BeginContext(5055, 329, true);
            WriteLiteral(@"                                <!-- Start Single Product -->
                                <div class=""product product__style--3 col-lg-4 col-md-4 col-sm-6 col-12"">
                                    <div class=""product__thumb"">
                                        <a class=""first__img"" href=""single-product.html""><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5384, "\"", 5402, 1);
#line 101 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
WriteAttributeValue("", 5390, item.ImgUrl, 5390, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5403, 128, true);
            WriteLiteral(" alt=\"product image\"></a>\r\n                                        <a class=\"second__img animation1\" href=\"single-product.html\">");
            EndContext();
            BeginContext(5531, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a0b29b26f004738abe6317b1f8e18b9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5583, 408, true);
            WriteLiteral(@"</a>
                                        <div class=""hot__box"">
                                            <span class=""hot-label"">BEST SALLER</span>
                                        </div>
                                    </div>
                                    <div class=""product__content content--center"">
                                        <h4><a href=""single-product.html"">");
            EndContext();
            BeginContext(5992, 9, false);
#line 108 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                                                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6001, 126, true);
            WriteLiteral("</a></h4>\r\n                                        <ul class=\"prize d-flex\">\r\n                                            <li>");
            EndContext();
            BeginContext(6128, 10, false);
#line 110 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(6138, 73, true);
            WriteLiteral("</li>\r\n                                            <li class=\"old_prize\">");
            EndContext();
            BeginContext(6212, 15, false);
#line 111 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                                             Write(item.PriceOffer);

#line default
#line hidden
            EndContext();
            BeginContext(6227, 1891, true);
            WriteLiteral(@"</li>
                                        </ul>
                                        <div class=""action"">
                                            <div class=""actions_inner"">
                                                <ul class=""add_to_links"">
                                                    <li><a class=""cart"" href=""cart.html""><i class=""bi bi-shopping-bag4""></i></a></li>
                                                    <li><a class=""wishlist"" href=""wishlist.html""><i class=""bi bi-shopping-cart-full""></i></a></li>
                                                    <li><a class=""compare"" href=""#""><i class=""bi bi-heart-beat""></i></a></li>
                                                    <li><a data-toggle=""modal"" title=""Quick View"" class=""quickview modal-view detail-link"" href=""#productmodal""><i class=""bi bi-search""></i></a></li>
                                                </ul>
                                            </div>
                                        </di");
            WriteLiteral(@"v>
                                        <div class=""product__hover--content"">
                                            <ul class=""rating d-flex"">
                                                <li class=""on""><i class=""fa fa-star-o""></i></li>
                                                <li class=""on""><i class=""fa fa-star-o""></i></li>
                                                <li class=""on""><i class=""fa fa-star-o""></i></li>
                                                <li><i class=""fa fa-star-o""></i></li>
                                                <li><i class=""fa fa-star-o""></i></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <!-- End Single Product -->
");
            EndContext();
#line 135 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                            }

#line default
#line hidden
            BeginContext(8149, 625, true);
            WriteLiteral(@"                        </div>
                        <ul class=""wn__pagination"">
                            <li class=""active""><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li><a href=""#"">4</a></li>
                            <li><a href=""#""><i class=""zmdi zmdi-chevron-right""></i></a></li>
                        </ul>
                    </div>
                    <div class=""shop-grid tab-pane fade"" id=""nav-list"" role=""tabpanel"">
                        <div class=""list__view__wrapper"">
");
            EndContext();
#line 147 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                             foreach (var item in Model.Books)
                            {

#line default
#line hidden
            BeginContext(8869, 271, true);
            WriteLiteral(@"                                <!-- Start Single Product -->
                                <div class=""list__view"">
                                    <div class=""thumb"">
                                        <a class=""first__img"" href=""single-product.html""><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 9140, "\"", 9158, 1);
#line 152 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
WriteAttributeValue("", 9146, item.ImgUrl, 9146, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9159, 129, true);
            WriteLiteral(" alt=\"product images\"></a>\r\n                                        <a class=\"second__img animation1\" href=\"single-product.html\">");
            EndContext();
            BeginContext(9288, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ff831b7e55642dd9f52926cb93b3fc5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9343, 183, true);
            WriteLiteral("</a>\r\n                                    </div>\r\n                                    <div class=\"content\">\r\n                                        <h2><a href=\"single-product.html\">");
            EndContext();
            BeginContext(9527, 9, false);
#line 156 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                                                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(9536, 782, true);
            WriteLiteral(@"</a></h2>
                                        <ul class=""rating d-flex"">
                                            <li class=""on""><i class=""fa fa-star-o""></i></li>
                                            <li class=""on""><i class=""fa fa-star-o""></i></li>
                                            <li class=""on""><i class=""fa fa-star-o""></i></li>
                                            <li class=""on""><i class=""fa fa-star-o""></i></li>
                                            <li><i class=""fa fa-star-o""></i></li>
                                            <li><i class=""fa fa-star-o""></i></li>
                                        </ul>
                                        <ul class=""prize__box"">
                                            <li>$");
            EndContext();
            BeginContext(10319, 10, false);
#line 166 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                            Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(10329, 75, true);
            WriteLiteral("</li>\r\n                                            <li class=\"old__prize\">$");
            EndContext();
            BeginContext(10405, 15, false);
#line 167 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                                               Write(item.PriceOffer);

#line default
#line hidden
            EndContext();
            BeginContext(10420, 97, true);
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                        <p>");
            EndContext();
            BeginContext(10518, 12, false);
#line 169 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                      Write(item.Details);

#line default
#line hidden
            EndContext();
            BeginContext(10530, 568, true);
            WriteLiteral(@"</p>
                                        <ul class=""cart__action d-flex"">
                                            <li class=""cart""><a href=""cart.html"">Add to cart</a></li>
                                            <li class=""wishlist""><a href=""cart.html""></a></li>
                                            <li class=""compare""><a href=""cart.html""></a></li>
                                        </ul>

                                    </div>
                                </div>
                                <!-- End Single Product -->
");
            EndContext();
#line 179 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                            }

#line default
#line hidden
            BeginContext(11129, 162, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- End Shop Page -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GalleryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
