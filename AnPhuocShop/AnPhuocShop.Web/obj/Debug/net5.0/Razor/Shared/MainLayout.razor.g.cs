#pragma checksum "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "712a2d8881f753caa66e6baff7167d421c218588"
// <auto-generated/>
#pragma warning disable 1591
namespace AnPhuocShop.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using AnPhuocShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using AnPhuocShop.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-2egs4vqnki");
            __builder.AddMarkupContent(3, @"<header b-2egs4vqnki><div class=""container"" b-2egs4vqnki><div class=""row"" b-2egs4vqnki><div class=""wrapper-right"" b-2egs4vqnki><a href=""https://www.facebook.com/AnPhuoc.PierreCardin.Official"" b-2egs4vqnki><img class=""icon-header"" src=""image/icon/fb.jpg"" b-2egs4vqnki></a> &nbsp;
                    <a href=""https://www.instagram.com/anphuoc.pierrecardin/"" b-2egs4vqnki><img class=""icon-header"" src=""image/icon/instagram.png"" b-2egs4vqnki></a> &nbsp;
                    <a href=""https://www.youtube.com/channel/UCTc-4zM5fRI4FrSKRjdwphw"" b-2egs4vqnki><img class=""icon-header"" src=""image/icon/ytb.png"" b-2egs4vqnki></a> &nbsp;
                    <a href=""https://zalo.me/1865611096449147467"" b-2egs4vqnki><img class=""icon-header"" src=""image/icon/zalo.png"" b-2egs4vqnki></a> &ensp;|
                    <span class=""oi oi-phone"" style=""color:white"" b-2egs4vqnki> 028.3938.1892</span></div>
                <div class=""logo"" b-2egs4vqnki><img src=""logo.png"" b-2egs4vqnki></div>
                <div class=""wrapper-left"" b-2egs4vqnki><div class=""search-box"" b-2egs4vqnki><form b-2egs4vqnki><input class=""sb-text"" type=""text"" placeholder=""...Nhập tìm kiếm..."" b-2egs4vqnki>
                            <input class=""sb-sbm"" type=""submit"" b-2egs4vqnki></form></div></div></div></div></header>

    ");
            __builder.AddMarkupContent(4, "<div class=\"wrapper\" b-2egs4vqnki><nav class=\"menu\" b-2egs4vqnki><ul class=\"clearfix\" b-2egs4vqnki><li b-2egs4vqnki><a href=\"https://localhost:44307/\" b-2egs4vqnki>Trang chủ</a></li>\r\n                <li b-2egs4vqnki><a href=\"#\" b-2egs4vqnki>AN PHUOC <span class=\"arrow\" b-2egs4vqnki>&#9660;</span></a>\r\n\r\n                    <ul class=\"sub-menu\" b-2egs4vqnki><li b-2egs4vqnki><a href=\"/AoSoMiNam\" b-2egs4vqnki>Áo sơ mi nam</a></li>\r\n                        <li b-2egs4vqnki><a href=\"/AoThunNam\" b-2egs4vqnki>Áo thun nam</a></li>\r\n                        <li b-2egs4vqnki><a href=\"/QuanNam\" b-2egs4vqnki>Quần nam</a></li>\r\n                        <li b-2egs4vqnki><a href=\"/AoKhoacNam\" b-2egs4vqnki>Áo khoác nam</a></li></ul></li>\r\n                <li b-2egs4vqnki><a href=\"#\" b-2egs4vqnki>AN PHUOC LADIES <span class=\"arrow\" b-2egs4vqnki>&#9660;</span></a>\r\n\r\n                    <ul class=\"sub-menu\" b-2egs4vqnki><li b-2egs4vqnki><a href=\"/AoSomiNu\" b-2egs4vqnki>Áo sơ mi nữ</a></li>\r\n                        <li b-2egs4vqnki><a href=\"/AoThunNam\" b-2egs4vqnki>Áo thun nữ</a></li>\r\n                        <li b-2egs4vqnki><a href=\"/QuanNu\" b-2egs4vqnki>Quần nữ</a></li>\r\n                        <li b-2egs4vqnki><a href=\"/AoKhoacNu\" b-2egs4vqnki>Áo khoác nữ</a></li></ul></li>\r\n                <li b-2egs4vqnki><a href=\"#\" b-2egs4vqnki>PHỤ KIỆN <span class=\"arrow\" b-2egs4vqnki>&#9660;</span></a>\r\n\r\n                    <ul class=\"sub-menu\" b-2egs4vqnki><li b-2egs4vqnki><a href=\"/Giaydep\" b-2egs4vqnki>Giày dép</a></li>\r\n                        <li b-2egs4vqnki><a href=\"/Vida\" b-2egs4vqnki>Ví da</a></li>\r\n                        <li b-2egs4vqnki><a href=\"/Thatlung\" b-2egs4vqnki>Thắc lưng</a></li></ul></li></ul></nav></div>\r\n    ");
            __builder.AddMarkupContent(5, "<marquee b-2egs4vqnki><h4 b-2egs4vqnki>Chào mừng bạn đến với Shop An Phước......!</h4></marquee>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddAttribute(8, "b-2egs4vqnki");
            __builder.AddContent(9, 
#nullable restore
#line 64 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    <br b-2egs4vqnki>\r\n    <br b-2egs4vqnki>\r\n    ");
            __builder.AddMarkupContent(11, "<footer class=\"footer\" b-2egs4vqnki><div class=\"main-footer\" b-2egs4vqnki><div class=\"footer-right\" b-2egs4vqnki><h2 style=\"color:red\" b-2egs4vqnki>AN PHUOC</h2>\r\n                <br b-2egs4vqnki>\r\n                <ul class=\"box\" b-2egs4vqnki><li b-2egs4vqnki>100/11-12 An Dương Vương, P.9, Q.5, TP. Hồ Chí Minh, Việt Nam</li></ul>\r\n                <br b-2egs4vqnki>\r\n                <ul b-2egs4vqnki><li b-2egs4vqnki>GPKD Số: 0301241545</li>\r\n                    <li b-2egs4vqnki>Ngày cấp: 26/04/1993GPKD Số: 0301241545</li>\r\n                    <li b-2egs4vqnki>Tư vấn mua hàng: +84.28 3938 1892</li>\r\n                    <li b-2egs4vqnki>Văn phòng: +84.28.3835.0059</li>\r\n                    <li b-2egs4vqnki>CSKH: +84.28.3830.7337</li>\r\n                    <li b-2egs4vqnki>Fax: +84.28.3835.0058</li>\r\n                    <li b-2egs4vqnki>Email: cskh@anphuoc.com.vn</li></ul></div>\r\n            <div class=\"footer-center\" b-2egs4vqnki><h2 b-2egs4vqnki>CHĂM SÓC KHÁCH HÀNG</h2>\r\n                <br b-2egs4vqnki>\r\n                <ul b-2egs4vqnki><li b-2egs4vqnki><a style=\"text-decoration:none; color:white\" href=\"#\" b-2egs4vqnki>Hướng dẫn mua hàng</a></li>\r\n                    <li b-2egs4vqnki><a style=\"text-decoration:none; color:white\" href=\"#\" b-2egs4vqnki>Hướng dẫn thanh toán</a></li>\r\n                    <li b-2egs4vqnki><a style=\"text-decoration:none; color:white\" href=\"#\" b-2egs4vqnki>Thời gian giao hàng</a></li>\r\n                    <li b-2egs4vqnki><a style=\"text-decoration:none; color:white\" href=\"#\" b-2egs4vqnki>Chính sách bảo mật</a></li>\r\n                    <li b-2egs4vqnki><a style=\"text-decoration:none; color:white\" href=\"#\" b-2egs4vqnki>Chính sách đổi hàng</a></li></ul></div>\r\n            <div class=\"footer-left\" b-2egs4vqnki><h2 b-2egs4vqnki>LIÊN KẾT VỚi CHÚNG TÔI</h2>\r\n                <br b-2egs4vqnki>\r\n                <div class=\"socials\" b-2egs4vqnki><a href=\"https://www.facebook.com/AnPhuoc.PierreCardin.Official\" b-2egs4vqnki><img src=\"image/icon/fb.jpg\" b-2egs4vqnki></a>\r\n\r\n                    <a href=\"https://www.youtube.com/channel/UCTc-4zM5fRI4FrSKRjdwphw\" b-2egs4vqnki><img src=\"image/icon/ytb.png\" b-2egs4vqnki></a>\r\n\r\n                    <a href=\"https://zalo.me/1865611096449147467\" b-2egs4vqnki><img src=\"image/icon/zalo.png\" b-2egs4vqnki></a>\r\n\r\n                    <a href=\"https://www.instagram.com/anphuoc.pierrecardin/\" b-2egs4vqnki><img src=\"image/icon/instagram.png\" b-2egs4vqnki></a></div>\r\n                <br b-2egs4vqnki>\r\n                <br b-2egs4vqnki>\r\n                <a href=\"http://www.online.gov.vn/Home/WebDetails/983?AspxAutoDetectCookieSupport=1\" b-2egs4vqnki><img src=\"image/icon/bct.png\" style=\"width:auto; height:50px\" b-2egs4vqnki></a></div></div>\r\n        <div class=\"footer-bottom\" style=\"display:block; text-align:center; border:solid white\" b-2egs4vqnki><p b-2egs4vqnki>Copyright © 2020 - 2021 An Phước.</p></div></footer>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
