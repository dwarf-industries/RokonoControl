#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationNavigation/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67001d4ef7027d4a1420b362ed3e3523b497d616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Documentation_DocumentationNavigation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Documentation/DocumentationNavigation/Default.cshtml")]
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67001d4ef7027d4a1420b362ed3e3523b497d616", @"/Views/Shared/Components/Documentation/DocumentationNavigation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Documentation_DocumentationNavigation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationNavigation/Default.cshtml"
  
    var ProjectId = ViewData["ProjectId"] as int?;
    var defaultIteration = ViewData["DefaultIteration"] as int?;
    var CurrentUser = ViewData["User"];
    var UserRights = ViewData["GetChatRights"]as UserRights;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .ChatChannelIcon:before{
        content:'\e99a';
        font-family: e-icons;
        padding:3px;
        font-size: 13px;
    }
    .TreeNewItem:before{
        padding:3px;
        content:'\e7f9';
        font-family: e-icons;
        font-size: 13px;
    }
    .CategoryIcon:before{
        padding:3px;
        content:'\e714';
        font-family: e-icons;
        font-size: 13px;
    }
    .CategoryIcon:hover{
        color:rgb(230, 50, 111);
    }
    .TreeNewItem:hover{
        color:rgb(230, 50, 111);
    }
    .ChatChannelIcon:hover{
        color:rgb(230, 50, 111);
        
    }
    #documentation-treeview .e-list-parent .e-ul
    {
        padding: 0;
        margin:  0;
    } 
    #documentation-treeview .e-text-content
    {
        padding: 0;
    }

    #documentation-treeview  .e-text-content
    {
        text-align: initial;
    }
    #documentation-treeview .e-list-text
    {
        width: 80%;
    }
    #documentation-treeview  .e-gridheader
    {
        height:0px;
    ");
            WriteLiteral(@"    display: none;
    }

    #documentation-treeview .e-treecell
    {
        width: 100%;
    }
    .nodetext{
        font-family: ""Helvetica Neue"",Helvetica,Arial,sans-serif;
        padding: 2%;
        font-size: 16px;
        text-align: left;
        padding-left: 5px;
        cursor: pointer;
    }
    .nodetext:hover{
        background-color: #fff;
        border-color: #000;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.22);
    }
    .nodetextHeading{
        cursor: pointer;
    }
     .nodetextHeading:hover{
        background-color: #fff;
        border-color: #000;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.22);
    }
    .nodetextHeading
    {
        ont-family: ""Helvetica Neue"",Helvetica,Arial,sans-serif;
        padding: 2%;
        font-size: 18px;
        text-align: left;
    }
    .e-icons .e-treegridexpand
    {
        display: block;
    }

</style>
<div class=""row"" style=""margin:0;"">
    <div id=""DocumentationTreeViewHolder"">
");
            WriteLiteral("                <div id=\"documentation-treeview\"></div>\n    </div>\n</div>\n\n");
            WriteLiteral(@"<script id=""DocumentationGridRow"" type=""text/x-template"" >
<tr id=""ChatChannelRow_${isParent}_${internalId}"" >
    <td>
     ${if(isParent)}
        <div class=""nodetextHeading""  onclick=""Expand(${internalId})"">
            <div class=""row"" style=""padding:5px; margin:0;"" >
                <div class=""col-md-9"">
                    <span class=""CategoryIcon""></span><span class=""ChatTreeMainText"">${nodeText}</span>
                </div>
                <div class=""col-md-2""   >
                    <span onclick=""AddNewCategoryField(2,${internalId})"" class=""TreeNewItem""></span>
                </div>
            </div>
        </div>   
    ${else}
        <div class=""nodetext"" id=""ChatChannel_${internalId}"" onclick=""OpenChannel(${internalId})"">
            <span class=""ChatChannelIcon"" style=""padding-left:20px;""></span> <span class=""ChatTreeMainText"" >${nodeText}</span>
        </div>
    ${/if}
    </td>
</tr>
</script>
");
            WriteLiteral("\n<script>\nvar LastDataSource;\nvar DocumentationNavigation;\n$( document ).ready(function() {\n    var dtoNotifications = {\n        \"ProjectId\":");
#nullable restore
#line 163 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationNavigation/Default.cshtml"
               Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
         
    }
    $.ajax({
        type: 'POST',
        url: '/Documentation/GetNavigation',
        data: JSON.stringify(dtoNotifications),
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        success: function (response) {
            InitializeChatItems(response);
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    }); 
});
");
            WriteLiteral(@"
    var URL = location.href.replace(location.search, '');
    
     
    function InitializeChatItems(incomingData)
    {
        $(""#DocumentationTreeViewHolder"").html("""");
        $(""#DocumentationTreeViewHolder"").html(""<div id=\""documentation-treeview\""></div>"");
 
        console.log(incomingData);
        LastDataSource = incomingData;
        DocumentationNavigation = new ej.treegrid.TreeGrid({
            dataSource: incomingData,
            childMapping: 'nodeChild',
            treeColumnIndex: 0,
            rowSelected :Expand,
            rowTemplate:'#DocumentationGridRow',
            allowPaging: false,
            rowHeight: 83,
            columns: [
                { field: 'nodeText',  width: 220 },
              
            ]
        });
        DocumentationNavigation.appendTo('#documentation-treeview');
    }
     
    function OpenChannel(id)
    {
        
        $(""#DocumentationPageControl"").html("""");
        $(""#DocumentationPageControl"").load('/Documentation/DocumentationPage?i");
            WriteLiteral("d=\'+id+\'&&projectId=");
#nullable restore
#line 231 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationNavigation/Default.cshtml"
                                                                                              Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
        
    }
    function Expand(args)
    {
        console.log(LastDataSource);
        LastDataSource.forEach(x=>{
            var expand =false;
            if(x.internalId === args && x.isExpand === 1)
            {
                x.isExpand = 0;
                expand = false;
            }
            else
            {
                x.isExpand = 1;
                expand = true;
            }
            
            x.nodeChild.forEach(y=>{
                if(y.parentId === args)
                {
                    if(expand)
                    {
                        console.log(args);
                        console.log(y.parentId);
                        console.log(y.internalId);
                        $(""#ChatChannelRow_undefined_""+y.internalId).show();
                    }
                    else
                    {
                        console.log(args);
                        console.log(y.parentId);
                        console.log(y.internalId);
                  ");
            WriteLiteral("      $(\"#ChatChannelRow_undefined_\"+y.internalId).hide();\n                    }\n                }\n           });\n        });\n");
            WriteLiteral("    }\n</script>");
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
