#pragma checksum "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f03c115c895acdd279f7d120cd86bcb617abfb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhanCa_Index), @"mvc.1.0.view", @"/Views/PhanCa/Index.cshtml")]
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
#line 1 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f03c115c895acdd279f7d120cd86bcb617abfb1", @"/Views/PhanCa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_PhanCa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeShop.Models.PhanCaView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PhanCa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThemPhanCa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #4e73df; width: 10%; margin-left: 2%; border: 1px solid #4e73df;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--để nó hiểu những biến trong viewmodel-->\r\n");
#nullable restore
#line 6 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml"; //dùng lại layout ở share


#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n<td>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f03c115c895acdd279f7d120cd86bcb617abfb14785", async() => {
                WriteLiteral("Tạo Mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</td>
<br>
<!-- end search  -->
<!--begin table-->
<table class=""table table-striped"" style="" width: 96%; margin-left: 2%; border: 1px solid #dee2e6;"">
    <thead>
        <tr>
            <th scope=""col"">Mã NV</th>
            <th scope=""col"">Hệ Số Lương</th>
            <th scope=""col"">Số Giờ</th>
            <th scope=""col""></th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
         if (Model.PhanCa != null) 
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
             foreach (var item in Model.PhanCa)//tạo vòng lặp để duyệt từng phần tử trong viewbag để show ra
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 36 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
           Write(item.MaNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
           Write(item.HeSoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
           Write(item.SoGio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n               \r\n            </td>\r\n            <td>\r\n                <button id=\"xoaPhanCa\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\" class=\"btn btn-block btn-danger\" data-id=\"");
#nullable restore
#line 43 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
                                                                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button>\r\n        </tr>\r\n");
#nullable restore
#line 45 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n");
#nullable restore
#line 54 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
                                                                                     
    var prevDisabled = !Model.PhanCa.HasPreviousPage ? "disabled" : "";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
                                                                                  
    var nextDisabled = !Model.PhanCa.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f03c115c895acdd279f7d120cd86bcb617abfb19550", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1974, "btn", 1974, 3, true);
            AddHtmlAttributeValue(" ", 1977, "btn-default", 1978, 12, true);
#nullable restore
#line 60 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
AddHtmlAttributeValue(" ", 1989, prevDisabled, 1990, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
              WriteLiteral(Model.PhanCa.PageIndex -1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f03c115c895acdd279f7d120cd86bcb617abfb112093", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2172, "btn", 2172, 3, true);
            AddHtmlAttributeValue(" ", 2175, "btn-default", 2176, 12, true);
#nullable restore
#line 63 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
AddHtmlAttributeValue(" ", 2187, nextDisabled, 2188, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "E:\CoffeeShop\CoffeeShop\CoffeeShop\Views\PhanCa\Index.cshtml"
              WriteLiteral(Model.PhanCa.PageIndex +1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!--Thẻ show lên xác nhận xóa hay không-->
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Thông báo</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bạn có chắc chắn muốn xóa?
            </div>
            <div class=""modal-footer"" id=""footer-del"">
                
            </div>
        </div>
    </div>
</div>
<!--Kết thúc thẻ xác nhận không có gì đặc biệt-->
<!--end table-->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script type=""");
            WriteLiteral(@"text/javascript"">//viết jquery, do xài cái model để xác nhận có muốn xóa hay không thì mình không lấy mã trực tiếp như cái sửa được nên phải viết thêm cái này 
    $(""button#xoaPhanCa"").click(function ()//tạo sự kiên click cho cái button ở trên theo cú pháp của jquery: ""tenthe#mã thẻ""
    {
        var id = $(this).data(""id"");//gán ID đã được lưu vào data-id ở trên để gán vào biến id
        var obj = '<a class=""btn btn-success"" href=""https://localhost:44359/PhanCa/XoaPhanCaData/' + id + '"">Có</a>'
            + '<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Không</button>';//tạo biến obj để lưu lại cái html mình cần xuất ra, cái này tui không quá rõ
        $(""div#footer-del"").html(obj);//gọi cái thẻ div có mã là footer-del để chèn phần html zo
    });
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeShop.Models.PhanCaView> Html { get; private set; }
    }
}
#pragma warning restore 1591