#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicFeedbackSettings/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca82c732f2896ef844fb3643d8ae3390dc63e271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PublicFeedbackSettings_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PublicFeedbackSettings/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca82c732f2896ef844fb3643d8ae3390dc63e271", @"/Views/Shared/Components/PublicFeedbackSettings/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PublicFeedbackSettings_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicFeedbackSettings/Default.cshtml"
  
    var KeySettings = ViewData["ProjectKeyFeedback"] as AssociatedProjectApiKeys;
    var ProjectId = ViewData["ProjectId"] as int?;
    var value = ViewData["RuleValueFeedbackPage"] as int?;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .e-input-picture:before {
        content: '\e30d';
        font-family: e-icons;
    }
    
    .e-input-calendar:before {
        content:'\e901';
        font-family: e-icons;
        font-size: 13px;
    }

</style>

<div class=""col-lg-12 control-section"">
    <div class=""row"">
        <div class=""control_wrapper"">
            <div class=""col-md-6"">
                <label for=""EnableFeedbacks"" style=""padding:2%; min-width:303px;"">Enable Feedback</label>
                <input id=""EnableFeedbacks"" onchange=""FeedbacksHandlerChanged()"" type=""checkbox"" />
            </div>
            <div class=""col-md-6"">
                <div class=""e-input-group e-float-icon-left"">
                    <span class=""e-input-group-icon e-input-picture"" onclick=""CopyToClipboardFeedback()""></span>
                    <div class=""e-input-in-wrap"">
                        <input class=""e-input"" id=""InputFeedback"" type=""text"" placeholder=""Enable Public Bug Reporting""");
            BeginWriteAttribute("value", " value=\"", 1170, "\"", 1200, 1);
#nullable restore
#line 32 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicFeedbackSettings/Default.cshtml"
WriteAttributeValue("", 1178, KeySettings.ApiSecret, 1178, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled/>
                    </div>
                </div>
            </div>

        </div>
    </div>
      <div class=""row"">
        <div class=""control_wrapper"">
            <div id=""feedbackGrid""></div>
        </div>
    </div>
</div>


<script>
    var EnableFeedbacks;
    EnableFeedbacks = new ejs.buttons.Switch({ checked: ");
#nullable restore
#line 49 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicFeedbackSettings/Default.cshtml"
                                                   Write(value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" });\n    EnableFeedbacks.appendTo(\'#EnableFeedbacks\');\n    var FeedbackChecked = 0;\n     if(");
#nullable restore
#line 52 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicFeedbackSettings/Default.cshtml"
   Write(value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" === 1)
        $(""#InputFeedback"").prop( ""disabled"", false )
    else
        $(""#InputFeedback"").prop( ""disabled"", true )

    var messagesDto=
    {
        ""id"":id,
    }
    $.ajax({
        type: 'POST',
        url: '/ApiKeySettings/GetAllFeedback',
        data: JSON.stringify(messagesDto),
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        
        success: function (response) {
            InitPublicFeedback(response);
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    });
    
    function FeedbacksHandlerChanged()
    {
        if (EnableFeedbacks.properties.checked === true)
        {
            FeedbackChecked= 1;
            $(""#InputFeedback"").prop( ""disabled"", false )
        }
        else
        {
            FeedbackChecked = 0;
            $(""#InputFeedback"").prop( ""disabled"", true )

        }
          var dto = {
            ""ProjectId"":");
#nullable restore
#line 90 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/PublicFeedbackSettings/Default.cshtml"
                   Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            ""RuleName"": ""FeedbackPage"",
            ""Value"": FeedbackChecked
        }
        $.ajax({
            type: 'POST',
            url: '/ApiKeySettings/EnableProjectFeature',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                alert(""Feature enabled, please save you api key to authorize the connection on the front end of your application."");
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
    }


    function InitPublicFeedback(data)
    {
        feedbackGrid = new ej.grids.Grid({
            dataSource: data,
            height: 335,
            editSettings: {allowAdding: true, mode: 'Normal', newRowPosition: 'Bottom' },
            actionBegin: feedbackGridBegin,
            allowPaging: false,
            width: 'auto',
            columns: [
                { headerText: 'Name'");
            WriteLiteral(@", width: 150, textAlign: 'Center', field: 'senderName' },
                { headerText: 'Message', width: 300, field: 'messageContent', textAlign: 'Left' }
            ]
        });
        feedbackGrid.appendTo('#feedbackGrid');
    }
    function feedbackGridBegin(args) {
        if (args.requestType === 'save') {
            chatGrid.dataSource.shift();// Remove the newly added record from first position 
            chatGrid.dataSource.push(args.data)// Push the newly added record in data source 
            chatGrid.refresh(); // refresh the Grid.
            $(""#ChatMessageBar"").children()[0].innerHTML = """";
        }
    }

    function CopyToClipboardFeedback()
    {
        var copyText =  document.getElementById(""InputFeedback"");
        copyText.select();
        copyText.setSelectionRange(0, 99999); /*For mobile devices*/

        /* Copy the text inside the text field */
        document.execCommand(""copy"");
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
