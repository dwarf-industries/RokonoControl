#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicDisscussionBoard/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac7a4281bf2843867da5e85978cf546c07e4752f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PublicDisscussionBoard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PublicDisscussionBoard/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7a4281bf2843867da5e85978cf546c07e4752f", @"/Views/Shared/Components/PublicDisscussionBoard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PublicDisscussionBoard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicDisscussionBoard/Default.cshtml"
  
    var ProjectId = ViewData["ProjectId"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link href=""https://cdn.quilljs.com/1.3.6/quill.snow.css"" rel=""stylesheet"">
<!-- Main Quill library -->
<script src=""//cdn.quilljs.com/1.3.6/quill.js""></script>
<script src=""//cdn.quilljs.com/1.3.6/quill.min.js""></script>
<div class=""col-lg-12 control-section"">
    <div class=""row"">
        <div class=""content-wrapper"">
            <div id=""chatGrid""></div>
        </div>
    </div>
    <div class=""row"">
        <div class=""content-wrapper"">
            <input id=""sName"" />
        </div>
    </div>
    <div class=""row"">
        <div class=""content-wrapper"">
            <div class=""position-relative form-group"" style=""width:100%;"">
                    <label for=""ChatMessageBar""");
            BeginWriteAttribute("class", " class=\"", 745, "\"", 753, 0);
            EndWriteAttribute();
            WriteLiteral(@">Add a comment</label>
                    <div name=""ChatMessageBar"" id=""ChatMessageBar"" class=""form-control""></div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""content-wrapper"">
            <button  onclick=""SendMessage()"" id=""SendMsgBtn"" style=""width:100%;""> <i class=""fas fa-save""></i> Send</button>
        </div>
    </div>
</div>

<script>
    var chatGrid;
    var messagesDto = {
        ""Id"": ");
#nullable restore
#line 39 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicDisscussionBoard/Default.cshtml"
         Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    }
    var ChatMessageBar;
    var sName = new ej.inputs.TextBox({
        placeholder: 'First Name',
        floatLabelType: 'Auto'
    });
    sName.appendTo('#sName');
    var SendMsgBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    SendMsgBtn.appendTo('#SendMsgBtn');
    ChatMessageBar = new Quill('#ChatMessageBar', {
        theme: 'snow'
    });
    $.ajax({
            type: 'POST',
            url: '/OutboundDetails/GetPublicDiscussions',
            data: JSON.stringify(messagesDto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            
            success: function (response) {
                InitalizeChatDiscussion(response);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
    });
    function InitalizeChatDiscussion(data)
    {
        chatGrid = new ej.grids.Grid({
            dataSource: data,
            height: 335,
            editSettings: {allo");
            WriteLiteral(@"wAdding: true, mode: 'Normal', newRowPosition: 'Bottom' },
            actionBegin: ChatActionBegin,
            allowPaging: false,
            width: 'auto',
            columns: [
                { headerText: 'Name', field: ""senderName"", width: 150, textAlign: 'Center' },
                { headerText: 'Message', width: 300, field: 'messageContent', textAlign: 'Left' }
            ]
        });
        chatGrid.appendTo('#chatGrid');
    }
    
    function ChatActionBegin(args) {
        if (args.requestType === 'save') {
            chatGrid.dataSource.shift();// Remove the newly added record from first position 
            chatGrid.dataSource.push(args.data)// Push the newly added record in data source 
            chatGrid.refresh(); // refresh the Grid.
            $(""#ChatMessageBar"").children()[0].innerHTML = """";
        }

     
    }

    function SendMessage()
    {
        var messagesDto= {
            ""ProjectId"":");
#nullable restore
#line 97 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicDisscussionBoard/Default.cshtml"
                   Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            ""SenderName"": $(""#sName"").val(),
            ""MessageContent"": $(""#ChatMessageBar"").children()[0].innerHTML
        }
        console.log(messagesDto);
        if($(""#sName"").val() && $(""#ChatMessageBar"").children()[0].innerHTML)
        {
            $.ajax({
                type: 'POST',
                url: '/OutboundDetails/AddNewPublicMessage',
                data: JSON.stringify(messagesDto),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                
                success: function (response) {
                    console.log(response);

                    chatGrid.addRecord(response);
                    chatGrid.refresh(); // refresh the Grid.
                },
                error: function (xhr, status, error) {
                    console.log(error);
                }
            });
        }
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
