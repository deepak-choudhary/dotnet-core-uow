#pragma checksum "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76e24398ae53c6f5399e9082bc2bd9d412ede789"
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
#line 1 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\_ViewImports.cshtml"
using unitofwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
using unitofwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e24398ae53c6f5399e9082bc2bd9d412ede789", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1236881882a9b3bbbe540f7cea99379760378c7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            WriteLiteral(@"
<table style=""width:1200px"">
    <tr>
        <td width=""50%"">

            <p><b>User List</b></p>

            <table rules=""all"" border=""1"" frame=""box"" id=""tbluser"">
                <tr>
                    <th>User Id</th>
                    <th>User Name</th>
                    <th>Delete</th>

                </tr>
");
#nullable restore
#line 22 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
                 foreach (User us in Model.User)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 25 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
                       Write(us.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
                       Write(us.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><input type=\"button\" value=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 682, "\"", 721, 3);
            WriteAttributeValue("", 692, "deleteuser(\'", 692, 12, true);
#nullable restore
#line 27 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 704, us.UserId, 704, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 714, "\',this)", 714, 7, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer;\" /></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 30 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </td>
        <td width=""50%"">
            <p><b>Product List</b></p>

            <table rules=""all"" border=""1"" frame=""box"" id=""tblproduct"">
                <tr>
                    <th>Product Id</th>
                    <th>Product Name</th>
                    <th>Delete</th>

                </tr>
");
#nullable restore
#line 43 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
                 foreach (Product pro in Model.Product)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 46 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
                       Write(pro.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
                       Write(pro.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><input type=\"button\" value=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1414, "\"", 1460, 3);
            WriteAttributeValue("", 1424, "deleteproduct(\'", 1424, 15, true);
#nullable restore
#line 48 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 1439, pro.ProductId, 1439, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1453, "\',this)", 1453, 7, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer;\" /></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 51 "D:\DotNetCore\unitOfWorkProj\unitofwork\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </td>
    </tr>
</table>

<script type=""text/javascript"">
    function deleteuser(userid, ctrl) {
        if (confirm(""Do you want to delete this user?"")) {



            $.ajax({
                url: ""Home/deleteuser"",
                data: { userid: userid }, // parameter map
                type: ""POST"", // data has to be Posted
                timeout: 120000,
                dataType: ""json"",
                success: function (result) {

                    if (result == ""1"") {
                        $(ctrl).closest('tr').remove();
                    }
                },
                error: function (xhr, status) {

                }
            });
        }
    }



    function deleteproduct(productid, ctrl) {
        if (confirm(""Do you want to delete this product?"")) {



            $.ajax({
                url: ""Home/deleteproduct"",
                data: { productid: productid }, // parameter map
                type: ""POST");
            WriteLiteral(@""", // data has to be Posted
                timeout: 120000,
                dataType: ""json"",
                success: function (result) {
                    if (result == ""1"") {
                        $(ctrl).closest('tr').remove();
                    }
                },
                error: function (xhr, status) {

                }
            });
        }
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591