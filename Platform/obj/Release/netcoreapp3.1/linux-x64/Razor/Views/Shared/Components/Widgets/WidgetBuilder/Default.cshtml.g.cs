#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83b471a8beae53c7e4c3eb78988b9e45a9bec743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Widgets_WidgetBuilder_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml")]
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b471a8beae53c7e4c3eb78988b9e45a9bec743", @"/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Widgets_WidgetBuilder_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml"
  
    var ProjectId = ViewData["ProjectId"] as int?;
    var DashboardId = ViewData["DashboardId"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .TopGridContainer{
        color: inherit;
        display: table-row;
        outline: none;
        text-decoration: none;
        transition: background 80ms linear;
    }
  

    .bolt-list-cell:last-child {
        border-right: 1px solid transparent;
    }
    .bolt-list-cell:first-child {
        border-left: 1px solid transparent;
    }
    .bolt-list-cell {
        border-top: 1px solid transparent;
        border-bottom: 1px solid transparent;
        color: inherit;
        display: table-cell;
        overflow: hidden;
        padding: 0;
        position: relative;
        text-align: left;
        text-decoration: none;
         
    }

    .bolt-list-cell {
        color: inherit;
        text-align: left;
     }
    .dashboards-widget-inline-catalog .widget-catalog-entry{
        min-height: 120px;
        padding-left: 20px;
        padding-right: 20px;
        padding-top: 10px;
        padding-bottom: 10px;
    }

    .flex-row {
        display: flex;
        flex-direction: r");
            WriteLiteral(@"ow;
    }

    .dashboards-widget-inline-catalog .widget-catalog-entry .widget-catalog-image{
        border: 1px solid;
        border-top-color: currentcolor;
        border-right-color: currentcolor;
        border-bottom-color: currentcolor;
        border-left-color: currentcolor;
        border-color: rgba(218,218,218,1);
        border-color: rgba(var(--palette-neutral-10,218, 218, 218),1);
    }
    .bolt-list-cell {
        color: inherit;
        text-align: left;
     }
  .bolt-list.bolt-list {
    border-collapse: separate;
}

.dashboards-widget-inline-catalog .widget-catalog-entry .widget-details .widget-description{
    word-wrap: break-word;
    white-space: normal;
    overflow: hidden;
}

.dashboards-widget-inline-catalog .widget-catalog-entry .widget-details .widget-description{
    width: 56px;
}
.widget-details{
    width: 46vh;
}

#ControlListGrid .e-columnheader{
    display: none;
}

.bolt-list-cell:hover{
    background-color: rgb(248, 248, 248);
}


.bolt-list-cell:active{
    backgro");
            WriteLiteral(@"und-color: #1c86c8;
    color:white;
}
 
 
</style>

<div class=""row"" id=""SelectControl"">
        <div class=""control-section"">
        <div class=""content-wrapper"">
            <div id=""ControlListGrid"" style=""width: auto;height: 87vh;overflow-y: scroll;"">
            </div>
        </div>
     </div>
   
</div>
<div class=""row"" id=""ControlSettings"">

</div>
<script id=""widgetsTemplate"" type=""text/x-template"">
  <tr   class=""widget-row bolt-list-row first-row"" >
      <td class=""bolt-list-cell"" data-column-index=""0"" onclick=""ControlSelected(${id},${customSettings})"">
          <div class=""bolt-list-cell-content flex-row"">
                <div class=""widget-catalog-entry flex flex-noshrink flex-column"">
                    <div class=""flex-row"">
                        <div class=""widget-catalog-image bolt-image-wrapper"" style=""width: 100px; height: 100px;"">
                        <img alt="""" class=""bolt-image flex-noshrink contain"" src=""https://kristifor.visualstudio.com/_static/Widgets/CatalogIcons/assigne");
            WriteLiteral(@"dToMe.png""></div>
                        <div class=""widget-details"">
                            <div class=""widget-name-container"">
                                <div class=""widget-name fontSizeL text-ellipsis"">${controlName} </div>
                            </div>
                        <div class=""widget-description fontSizeM text-ellipsis""> <p style=""word-wrap:break-word;"" >${controlDescription}</p></div>
                    </div>
                </div>
            </div>
        </div>
    </td>
  </tr>
</script>

<script>
    var Phase;
    var argument;
    var Components = [];
    var Control;
    $.ajax({
        type: 'GET',
        url: '/Accounts/GetWidgetComponents?projectId=");
#nullable restore
#line 139 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml"
                                                 Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        
        success: function (response) {
            InitializeControlList(response);
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    });
    function InitializeControlList(data)
    {
        var ControlListGrid = new ej.grids.Grid({
            dataSource: data,
            rowTemplate: '#widgetsTemplate',
            columns: [
                { field: 'controlName', headerText: 'Control Name', width: 120, textAlign: 'Right' },
                { field: 'description', headerText: 'Description', width: 120, textAlign: 'Right' },
 
            ]
        });
        ControlListGrid.appendTo('#ControlListGrid');
    }

    function ControlSelected(args, customSettings)
    {
        argument = args;
        console.log(argument);
        if(customSettings == 0)
        {
            SaveControlChanges();
        }
        else
        {
            $(""#ModalContent""");
            WriteLiteral(").load(\"/Widget/LoadControlSettings?id=\"+argument+\"&&projectId=");
#nullable restore
#line 174 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml"
                                                                                       Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&dashboard=");
#nullable restore
#line 174 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml"
                                                                                                             Write(DashboardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\n         }\n    }\n\n    function SaveControlChanges()\n    {\n        var dto = {\n            \"ProjectId\": ");
#nullable restore
#line 181 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml"
                    Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            \"Id\": ");
#nullable restore
#line 182 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml"
             Write(DashboardId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            ""WorkItemType"" : argument,
            ""Phase"" : Phase
        }
        console.log(dto);
        $.ajax({
            type: 'POST',
            url: '/Widget/AppendWidget',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                console.log(response);
                AddNewDashboardPanel(response.associatedUserDashboardPremade[0].id, response.id);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
    }
</script>");
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
