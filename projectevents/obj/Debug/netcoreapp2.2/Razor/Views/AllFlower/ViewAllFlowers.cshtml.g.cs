#pragma checksum "D:\Project-Events\projectevents\projectevents\projectevents\Views\AllFlower\ViewAllFlowers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ee6ec1c08202cd446f9040b601290eca7e7cc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllFlower_ViewAllFlowers), @"mvc.1.0.view", @"/Views/AllFlower/ViewAllFlowers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AllFlower/ViewAllFlowers.cshtml", typeof(AspNetCore.Views_AllFlower_ViewAllFlowers))]
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
#line 1 "D:\Project-Events\projectevents\projectevents\projectevents\Views\_ViewImports.cshtml"
using projectevents;

#line default
#line hidden
#line 2 "D:\Project-Events\projectevents\projectevents\projectevents\Views\_ViewImports.cshtml"
using projectevents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ee6ec1c08202cd446f9040b601290eca7e7cc7", @"/Views/AllFlower/ViewAllFlowers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00d2d6fec79dc449d350a996f52054159e79a8a", @"/Views/_ViewImports.cshtml")]
    public class Views_AllFlower_ViewAllFlowers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Project-Events\projectevents\projectevents\projectevents\Views\AllFlower\ViewAllFlowers.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(59, 3146, true);
            WriteLiteral(@"<link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />
<script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap4.min.js ""></script>
<div class=""container"">
    <br />
    <div style=""width:90%; margin:0 auto;"">
        <table id=""myTable"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>FlowerID</th>
                    <th>FlowerName</th>
                    <th>FlowerCost</th>
                    <th>Createdate</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
            </thead>
        </table>
    </div>
    <script>
        $(document).ready(function ()
        {
         ");
            WriteLiteral(@"   $(""#myTable"").DataTable({
                ""processing"": true, // for show progress bar
                ""serverSide"": true, // for process server side
                ""filter"": true, // this is for disable filter (search box)
                ""orderMulti"": false, // for disable multiple column at once
                ""ajax"": {
                    ""url"": ""/AllFlower/LoadFlowerData"",
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""columnDefs"":
                [{
                    ""targets"": [0],
                    ""visible"": false,
                    ""searchable"": false
                }],
                ""aoColumnDefs"": [{
                    ""bSortable"": false,
                    ""aTargets"": [4,5]
                }],
                ""columns"": [
                    { ""data"": ""FlowerID"", ""name"": ""FlowerID"", ""autoWidth"": true },
                    { ""data"": ""FlowerName"", ""name"": ""FlowerName"", ""autoWidth"": true },
      ");
            WriteLiteral(@"              { ""data"": ""FlowerCost"", ""name"": ""FlowerCost"", ""autoWidth"": true },
                    { ""data"": ""Createdate"", ""name"": ""Createdate"", ""autoWidth"": true },
                    {
                        ""render"": function (data, type, full, meta)
                        { return '<a class=""btn btn-info"" href=""/Flower/Edit/' + full.FlowerID + '"">Edit</a>'; }
                    },
                    {
                        data: null, render: function (data, type, row)
                        {
                            return ""<a href='#' class='btn btn-danger' onclick=DeleteData('"" + row.FlowerID + ""'); >Delete</a>"";
                        }
                    },
                ]

            });
        });


        function DeleteData(ID)
        {
            if (confirm(""Are you sure you want to delete ...?""))
            {
                DeleteFlower(ID);
            }
            else
            {
                return false;
            }
        }
");
            WriteLiteral("\n\r\n        function DeleteFlower(FlowerID)\r\n    {\r\n            var url = \'");
            EndContext();
            BeginContext(3206, 17, false);
#line 83 "D:\Project-Events\projectevents\projectevents\projectevents\Views\AllFlower\ViewAllFlowers.cshtml"
                  Write(Url.Content("~/"));

#line default
#line hidden
            EndContext();
            BeginContext(3223, 460, true);
            WriteLiteral(@"' + ""Flower/Delete"";

            $.post(url, { ID: FlowerID }, function (data)
                {
                    if (data)
                    {
                        oTable = $('#myTable').DataTable();
                        oTable.draw();
                    }
                    else
                    {
                        alert(""Something Went Wrong!"");
                    }
                });
    }

    </script>
</div>");
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
