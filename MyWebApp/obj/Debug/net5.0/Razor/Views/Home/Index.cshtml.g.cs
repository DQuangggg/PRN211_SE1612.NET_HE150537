#pragma checksum "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e608398ba363a8d1f862845f4228ca24b246cf54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\_ViewImports.cshtml"
using MyWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\_ViewImports.cshtml"
using MyWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e608398ba363a8d1f862845f4228ca24b246cf54", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f1673a5f2983d73e81002570cb059c9cd4e88c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebApp.Models.HomeModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Razor Syntax</h3>\r\n");
#nullable restore
#line 11 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
  
    var greeting = "Welcome";
    var weekDay = DateTime.Now.DayOfWeek;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
  
    var pro = new { ProdcutID = 1, ProductName = "Car" };

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>ProductID : ");
#nullable restore
#line 17 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
              Write(pro.ProdcutID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>ProductName : ");
#nullable restore
#line 18 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
                Write(pro.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 19 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
  Write(greeting);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 20 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
  Write(weekDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    <h2>Using View Bag </h2>\r\n    <h3 style=\"color:red\">");
#nullable restore
#line 26 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
                     Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <p>ProductID : ");
#nullable restore
#line 27 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
              Write(ViewBag.Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>ProductName : ");
#nullable restore
#line 28 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
                Write(ViewBag.Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>Brand :  ");
#nullable restore
#line 29 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
           Write(ViewBag.Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>Price :  ");
#nullable restore
#line 30 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
           Write(ViewBag.Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p> \r\n  \r\n\r\n");
            WriteLiteral("    <h3>Using Temp Data</h3>\r\n    <ul>\r\n");
#nullable restore
#line 36 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
     foreach (var data in TempData["StudentData"] as List<string>)
    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 38 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
       Write(data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 39 "C:\Users\ADMIN\Documents\GitHub\PRN211_HE150537\MyWebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebApp.Models.HomeModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
