#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NotificationPanel/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6c1e322f6f32cea15faaa28fdeb1e19af53cdf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NotificationPanel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NotificationPanel/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6c1e322f6f32cea15faaa28fdeb1e19af53cdf2", @"/Views/Shared/Components/NotificationPanel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NotificationPanel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NotificationPanel/Default.cshtml"
  
    var UserId = ViewData["UserId"] as int?;
    var Notifications = ViewData["Notificiations"] as List<Notifications>;
    var ProjectId = ViewData["ProjectId"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"" class=""cssStyles"">

  
    .PM:before {
        font-family: ""e-icons"" !important;
        content: '\e75e';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .AI:before {
        font-family: ""e-icons"" !important;
        content: '\e315';
        color: #1f248c;
        width: 30px;
        height: 30px;
    }
    .CW:before {
        font-family: ""e-icons"" !important;
        content: '\e30d';
        color: #4e8c1f;
        width: 30px;
        height: 30px;
    }
    .UW:before {
        font-family: ""e-icons"" !important;
        content: '\e93c';
        color: #1f8c71;
    }
    .CloseBtn:before {
        font-family: ""e-icons"" !important;
        content: '\ea7f';
        color: #bd1e33;
    }
    .CloseBtn:hover {
        font-family: ""e-icons"" !important;
        font-size: 20px;
        content: '\ea7f';
        color: #1c86c8;
    }
    
    .photo img {
        width: 100px;
        height: 100px;
        border-radius: 50px;
        box-shadow: ");
            WriteLiteral("inset 0 0 1px #e0e0e0, inset 0 0 14px rgba(0,0,0,0.2);\n    }\n    \n    ");
            WriteLiteral("@media screen and (max-width: 600px) and (min-width: 320px) {\n        .photo img {\n            width: 50px;\n            height: 50px;\n        }\n    }\n    \n    ");
            WriteLiteral(@"@media screen and (max-width: 800px) and (min-width: 600px) {
        .photo img {
            width: 70px;
            height: 70px;
        }
    }
    
    .photo,
    .details {
        border-color: #e0e0e0;
        border-style: solid;
    }
    
    .photo {
        border-width: 1px 0px 0px 0px;
        text-align: center;
        width: 50px;
    }
    
    .details {
        border-width: 1px 0px 0px 0px;
        padding-left: 18px;
    }

    .e-bigger .details {
        padding-left: 25px;
    }

    .e-device .details {
        padding-left: 8px;
    }
    
    .details > table {
        width: 100%;
    }
    
    .CardHeader {
        font-weight: 600;
    }
    
 
     

.e-grid .e-gridheader  {
  background-color: #fff;
  border-bottom-color: #e0e0e0;
  border-top-color: #e0e0e0;
  color: rgba(0, 0, 0, 0.54);
  padding: 0 !important;

}

   ");
            WriteLiteral(@"@font-face {
        font-family: 'Toast_icons';
        src: url(data:application/x-font-ttf;charset=utf-8;base64,AAEAAAAKAIAAAwAgT1MvMj0gSRkAAAEoAAAAVmNtYXDnM+eRAAABsAAAAEpnbHlmzVnmlwAAAhgAAAZAaGVhZBEYIl8AAADQAAAANmhoZWEHlgN3AAAArAAAACRobXR4LvgAAAAAAYAAAAAwbG9jYQnUCGIAAAH8AAAAGm1heHABHQBcAAABCAAAACBuYW1lfUUTYwAACFgAAAKpcG9zdAxfTDgAAAsEAAAAggABAAADUv9qAFoEAAAAAAAD6AABAAAAAAAAAAAAAAAAAAAADAABAAAAAQAACcU5MF8PPPUACwPoAAAAANcI7skAAAAA1wjuyQAAAAAD6APoAAAACAACAAAAAAAAAAEAAAAMAFAABwAAAAAAAgAAAAoACgAAAP8AAAAAAAAAAQPqAZAABQAAAnoCvAAAAIwCegK8AAAB4AAxAQIAAAIABQMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAUGZFZABA5wDnCgNS/2oAWgPoAJYAAAABAAAAAAAABAAAAAPoAAAD6AAAA+gAAAPoAAAD6AAAA+gAAAPoAAAD6AAAA+gAAAPoAAAD6AAAAAAAAgAAAAMAAAAUAAMAAQAAABQABAA2AAAABAAEAAEAAOcK//8AAOcA//8AAAABAAQAAAABAAIAAwAEAAUABgAHAAgACQAKAAsAAAAAAAAAQgB8AMIA4gEcAZQCBgJwAo4DAAMgAAAAAwAAAAADlAOUAAsAFwAjAAABFwcXNxc3JzcnBycFDgEHLgEnPgE3HgEFHgEXPgE3LgEnDgEBTXh4L3h4L3h4L3h4AbwDt4qKtwMDt4qKt/0eBeuxsesFBeuxsesCbHh4L3h4L3h4L3h4p4q3AwO3ioq3AwO3irHrBQXrsbHrBQXrAAAAAwAAAAADlAOUAAUAE");
            WriteLiteral(@"QAdAAABJwcXAScXDgEHLgEnPgE3HgEFHgEXPgE3LgEnDgEBr2UylwEbMqADt4qKtwMDt4qKt/0eBeuxsesFBeuxsesBrGQylgEcMqKKtwMDt4qKtwMDt4qx6wUF67Gx6wUF6wAAAAAFAAAAAAOUA5cABQARAB0AIQAlAAABFzcnNSMFDgEHLgEnPgE3HgEFHgEXPgE3LgEnDgElFzcnBRc3JwHKxiCnPwFOA6V8fKUDA6V8fKX9aATToJ/UBATUn5/UAh7ANsD9fja/NQGedzNj29F8pAMDpHx8pQMDpXyf1AQE1J+g0wQE0/GhQKGhQKFAAAQAAAAAA74DfgADAAcACgANAAAlMzUjNTM1IwEhCQEhAQHLUlJSUgFj/YwBOv42A5T+NuZUUqf+igIc/ZADFgAEAAAAAAOUA5QAAwAHABMAHwAAATM1IzUzNSMFDgEHLgEnPgE3HgEFHgEXPgE3LgEnDgEBylRUVFQBbgO3ioq3AwO3ioq3/R4F67Gx6wUF67Gx6wEk+lNT0Iq3AwO3ioq3AwO3irHrBQXrsbHrBQXrAAAAAAcAAAAAA+gDMQALABUAJQAuADcAQQBLAAABFhcVITUmJz4BMxYFFhcVITU+ATcWJQYHFSE1LgEjIgYHLgEjIgEWFAYiJjQ2MgUWFAYiJjQ2MiUGFBYXPgE0JiIFBhQWFz4BNCYiA1xEBP6sAxUeRiRX/qxEBP45BIlXV/7xZQsD6AvKUypvMzNvKlMCKxozTTMzTP6CGTNMNDRMAQItWUREWlqI/jstWkREWVmIAWMbFjc3IBgKDwQcGxY3NxY3BAQjJUt7e0tKFxgYFwEMGU01NU0zGhlNNTVNMxYthloCAlqGWy4thloCAlqGWwAAAAQAAAAAA5wCxwAIABQANABFAAABFBYyNjQmIgYXDgEHLgEnPgE3HgEfAQcOAQ8BNz4BNS4BJw4BBxQWHwEnLgEvATc+ATc2FiUOAQ8BFx4BNz4BPwEnJiciAb8fLR4eLR+wAkU0NEUBA");
            WriteLiteral(@"UU0NEX8BgEemG0FBB8kAlZBQFcBKyUCCkeVTAYBH76RVMP+3bDPBwcKZclcu/AGCwrM2AoBxxYfHy0eHhc0RQEBRTQ1RQEBRSgEARpWGAECFUIoQVcCAldBLEYUAQEIQkAGASJsBwFCoRbFFAoJW0sBCo8LCgztAQAAAAIAAAAAA4ADbAA4AEEAAAEEJCcmDgEWFx4BHwEVFAYHDgEnJg4BFhcWNjc2Fx4BBx4BFzc+ASc2JicmJzUzPgE3PgEnJicjIiUUFjI2NCYiBgNM/tz+pwwMGxEDDAaMfAcSETKEQw8WBg8Og80hNSg4JwICEw0FDhECAjFJEBICPYhKDQgGChQCB/5dMUgxMUgxAuB/ZRcIAxgbCQdHEQGTGi8TOVgKAw8dFwMNuDUFHTGDCA0QAQECFQ8Mnz8LCasJKiUHGg0SATMkMDBJMDAAAAAAAgAAAAAC/QMkAAMADQAAAQchJxMeATMhMjY3EyEC2x3+bB0kBCQZAQQZJARH/ewDBuDg/fcZICAZAicAAwAAAAACzwPoACwAQwBPAAABERQfARYfAzMVHgE7ATI2NRE0JisBNTEWOwEyNjQmJyMiJi8BLgErAQ4BAxUzNTQ2NzMeARcVMzUuAScjIgcjESM1HgEXPgE3LgEnDgEBVQEBAwQCCAjXARENOg0REQ2zDROVExoaE2UQGAQfAxAKYg0RPR8RDZcNEQEeASIalxANAR8CTTo6TQEBTTo6TQJ8/nYEBQIGBAIFArYNERENARENEUoNGicZARMPfQoNARH98Hl5DREBARENeXkaIgEIAe3FOk0CAk06Ok0BAU0AAAAAAgAAAAAC5gMyAAkAEQAAJRQWMyEyNjURITcjFSE1IycjASApHgEaHin+WFBuAeR+JLD8HigoHgGfeT09HgAAAAAAEgDeAAEAAAAAAAAAAQAAAAEAAAAAAAEAEgABAAEAAAAAAAIABwATAAEAAAAAAAMAEgAaAAEAAAAAAAQAEgAsAAEAAAAAAAUACwA+AAEAA");
            WriteLiteral(@"AAAAAYAEgBJAAEAAAAAAAoALABbAAEAAAAAAAsAEgCHAAMAAQQJAAAAAgCZAAMAAQQJAAEAJACbAAMAAQQJAAIADgC/AAMAAQQJAAMAJADNAAMAAQQJAAQAJADxAAMAAQQJAAUAFgEVAAMAAQQJAAYAJAErAAMAAQQJAAoAWAFPAAMAAQQJAAsAJAGnIEZpbmFsIFRvYXN0IE1ldHJvcFJlZ3VsYXJGaW5hbCBUb2FzdCBNZXRyb3BGaW5hbCBUb2FzdCBNZXRyb3BWZXJzaW9uIDEuMEZpbmFsIFRvYXN0IE1ldHJvcEZvbnQgZ2VuZXJhdGVkIHVzaW5nIFN5bmNmdXNpb24gTWV0cm8gU3R1ZGlvd3d3LnN5bmNmdXNpb24uY29tACAARgBpAG4AYQBsACAAVABvAGEAcwB0ACAATQBlAHQAcgBvAHAAUgBlAGcAdQBsAGEAcgBGAGkAbgBhAGwAIABUAG8AYQBzAHQAIABNAGUAdAByAG8AcABGAGkAbgBhAGwAIABUAG8AYQBzAHQAIABNAGUAdAByAG8AcABWAGUAcgBzAGkAbwBuACAAMQAuADAARgBpAG4AYQBsACAAVABvAGEAcwB0ACAATQBlAHQAcgBvAHAARgBvAG4AdAAgAGcAZQBuAGUAcgBhAHQAZQBkACAAdQBzAGkAbgBnACAAUwB5AG4AYwBmAHUAcwBpAG8AbgAgAE0AZQB0AHIAbwAgAFMAdAB1AGQAaQBvAHcAdwB3AC4AcwB5AG4AYwBmAHUAcwBpAG8AbgAuAGMAbwBtAAAAAAIAAAAAAAAACgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADAECAQMBBAEFAQYBBwEIAQkBCgELAQwBDQAFRXJyb3IHU3VjY2VzcwVBbGFybQdXYXJuaW5nBEluZm8HTWVldGluZwVCbGluawdTdHJldGNoA1NpcANTaXQFVHJhc2gAAAAA) format('truetype');
        font-weight: no");
            WriteLiteral(@"rmal;
        font-style: normal;
      }
    
      #toast_types button {
        margin: 5px;
        min-width: 160px;
        max-width: 160px;
      }

      .toast-icons {
        font-family: 'Toast_icons' !important;
        speak: none;
        font-size: 55px;
        font-style: normal;
        font-weight: normal;
        font-variant: normal;
        text-transform: none;
        line-height: 1;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
      }
    
      #toast_type .e-toast-icon.e-icons {
        height: auto;
        font-size: 30px;
      }
    
      .toast-icons.e-success::before {
        content: ""\e701"";
      }
    
      .toast-icons.e-error::before {
        content: ""\e700"";
      }
    
      .toast-icons.e-info::before {
        content: ""\e704"";
      }
    
      .toast-icons.e-warning::before {
        content: ""\e703"";
      }
</style>
<script id=""currentTemplate"" type=""text/x-template"">
    <tr id=""ID_${id}"">
        <td class=""ph");
            WriteLiteral(@"oto"">
            <span class=""${notificationTypeNavigation.icon}"">

            </span>
        </td>
        <td class=""details"">
            <table class=""CardTable"">
               
                <tbody>
                    
                    <tr>
                        <td style=""text-align:justify; max-width:85px;""> ${content} </td>
                        <td style=""text-align:center;""><span onclick=""RemoveNotification(${id})"" class=""CloseBtn""></span></td>

                    </tr>
                </tbody>
            </table>
        </td>
    </tr>
</script>
 
        <div  id=""NotificationGridWrapper"">
            <div id=""NotificationHolderGrid"" style=""padding:0px;""></div>
        </div>
        

<div class=""col-lg-12 control-section toast-type-section"">
  <div class=""e-sample-resize-container"">
    <div id=""toast_type"">
    </div>
    <div id=""toast_types"">
      <div>
      
      </div>
       
    </div>
  </div>
</div>
  


<script>

    var toasts = [];
    var toastObj;
    var dto = ");
            WriteLiteral("{\n        \"ProjectId\": ");
#nullable restore
#line 209 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NotificationPanel/Default.cshtml"
                Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        
    }
    console.log(dto);
    $.ajax({
        type: 'POST',
        url: '/Notification/GetUserNotifications',
        data: JSON.stringify(dto),
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        success: function (response) {
            InitiliazeNotificationGrid(response);
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    });

    function InitiliazeNotificationGrid(data)
    {

        data.forEach(x=>{
            var currentData;
            if(x.notificationType === 1)
               currentData = {
                    title: ""Personal Message"",
                    content: x.content, 
                    cssClass: 'e-toast-info',
                    icon: 'PM'
                };
            if(x.notificationType === 2)
                currentData = {
                    title: ""Assigned Item"",
                    content: x.content, 
                    cssClass: 'e-toast-success',
              ");
            WriteLiteral(@"      icon: 'AI'
                };

            if(x.notificationType === 3)
                 currentData ={
                    title: ""Created Work Item"",
                    content: x.content, 
                    cssClass: 'e-toast-warning',
                    icon: 'CW'
                };
            if(x.notificationType === 4)
                currentData ={
                    title: ""Updated Work Item"",
                    content: x.content, 
                    cssClass: 'e-toast-danger',
                    icon: 'UW'
                };

            toasts.push(currentData);
        });
        console.log(toasts);
        InitializeToast();
        console.log(data);
        $(""#NotificationGridWrapper"").html("""");
        $(""#NotificationGridWrapper"").html(""<div id=\""NotificationHolderGrid\""></div>"");
        var grid = new ej.grids.Grid({
            dataSource: data,
            rowTemplate: '#currentTemplate',
            height: $(""#sidebar-treeview"").height,
            width: 'auto',
    ");
            WriteLiteral(@"        columns: [
                { headerText: 'Type', textAlign: 'Center', field: 'notificationTypeNavigation.notificationType' },
                { headerText: 'Notification Content', field: 'content', textAlign: 'Left' }
            ]
        });
        grid.appendTo('#NotificationHolderGrid');
    }


    function RemoveNotification(id)
    {
        console.log(id);
        $(""#ID_""+id).remove();
        var countA =  $(""#NotificationCount"").html();
        var newCount = parseInt(countA) -1;
        $(""#NotificationCount"").html(newCount);
        var dto = {
            ""Id"": id
            
        }
        $.ajax({
        type: 'POST',
            url: '/Notification/NotificationRead',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
    }
    //Toas");
            WriteLiteral(@"t initialization 
    function InitializeToast()
    {
        toastObj = new ej.notifications.Toast({
            position: {
                X: 'Right'
            }, target: document.body,
            close: onclose,
            beforeOpen: onBeforeOpen
        });
        toastObj.appendTo('#toast_type');

        toasts.forEach(x=>{
            toastObj.show(x);
        });
    }
    
    function ShowAlert(text)
    {
        toastObj.show(
        {
            title: ""Error"",
            content: text, 
            cssClass: 'e-toast-danger',
            icon: 'e-error toast-icons' 
        });

    }
    setTimeout(function () {
       
    }, 200);
 
    function ShowNotification(data)
    {
        toastObj.show(data);
    }

    function onclose (e){
        if (e.toastContainer.childElementCount === 0 ) {
            document.getElementById('hideTosat').style.display = 'none';
        }
     }
   
    function onBeforeOpen (){
        document.getElementById('hideTosat').style.display = 'inline-b");
            WriteLiteral("lock\';\n     }\n\n    document.getElementById(\'hideTosat\').onclick = function () {\n        toastObj.hide(\'All\');\n    };\n   \n   \n</script>");
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
