#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/OutboundComponents/PublicFeedback/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fca4912ab6d807977cb25c69b48557bfefdf5c94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OutboundComponents_PublicFeedback_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OutboundComponents/PublicFeedback/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca4912ab6d807977cb25c69b48557bfefdf5c94", @"/Views/Shared/Components/OutboundComponents/PublicFeedback/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_OutboundComponents_PublicFeedback_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/OutboundComponents/PublicFeedback/Default.cshtml"
   
     var ProjectId = ViewData["ProjectId"] as int?;
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""https://cdn.quilljs.com/1.3.6/quill.snow.css"" rel=""stylesheet"">
<!-- Main Quill library -->
<script src=""//cdn.quilljs.com/1.3.6/quill.js""></script>
<script src=""//cdn.quilljs.com/1.3.6/quill.min.js""></script>
<style>
    .sliderwrap .label-text {
        font-weight: 500;
    }
    
    .content-wrapper {
        width: 80%;
        margin: 0 auto;
        min-width: 185px;
    }

    .sliderwrap {
        margin-top: 40px;
    }

    #default .e-handle,
    #out .e-handle,
    .bootstrap #out .e-handle,
    .bootstrap #default .e-handle,
    .fabric #out .e-handle,
    .fabric #default .e-handle,
    .highcontrast #out .e-handle,
    .highcontrast #default .e-handle {
        background-color: #ffd939;
        border-color: #ffd939;
        z-index: 1;
    }

    .e-bigger .content-wrapper {
        width: 80%;
    }

    .sliderwrap label {
        padding-bottom: 26px;
        font-size: 13px;
        font-weight: 500;
        margin-top: 15px;
    }

    .userselect {
        -webkit-user-sel");
            WriteLiteral(@"ect: none;
        /* Safari 3.1+ */
        -moz-user-select: none;
        /* Firefox 2+ */
        -ms-user-select: none;
        /* IE 10+ */
        user-select: none;
        /* Standard syntax */
    }



    .e-slider-tooltip.e-tooltip-wrap.e-popup.e-slider-tooltip .e-tip-content,
    .e-slider-tooltip.e-tooltip-wrap.e-popup.e-material-range .e-tip-content.e-material-tooltip-show {
        color: #333;
    }

    .e-tooltip-cutomization.e-slider-tooltip.e-tooltip-wrap.e-popup .e-arrow-tip-inner{
        color: #ffd939;
    }

    .e-tooltip-cutomization.e-slider-tooltip.e-tooltip-wrap.e-popup .e-arrow-tip-outer {
        border-top-color: #ffd939;
    }

    .e-tooltip-cutomization.e-slider-tooltip.e-tooltip-wrap.e-popup .e-arrow-tip-outer {
        border-bottom-color: #ffd939;
    }

    .e-slider-container .e-slider#default .e-range,
    .e-slider-container .e-slider#out .e-range {
        background-color: #e3165b;
        z-index: unset;
    }
    .e-tooltip-cutomization.e-slider-tooltip.e-toolti");
            WriteLiteral(@"p-wrap.e-popup.e-material-default.e-slider-horizontal-after,
    .e-tooltip-cutomization.e-slider-tooltip.e-tooltip-wrap.e-popup.e-material-default.e-slider-horizontal-before,
    .e-tooltip-cutomization.e-slider-tooltip.e-tooltip-wrap.e-popup {
        background-color: #ffd939;
        border-color: #ffd939;
    }

    .bootstrap .e-tooltip-cutomization.e-slider-tooltip.e-tooltip-wrap.e-popup .e-arrow-tip-outer {
        border-top-color: #ffd939;
    }
 
    .bootstrap .e-tooltip-cutomization.e-slider-tooltip.e-tooltip-wrap.e-popup .e-arrow-tip-inner {
        color: #ffd939;
    }
</style>


<div class=""col-lg-12 control-section"">
    <div class=""content-wrapper"">
         
        <div class=""sliderwrap"">
            <label class=""labeltext userselect"">
                <span class=""label-text"">Rate your feedback score</span>
            </label>
            <div id=""out""></div>
        </div>
    </div>
</div>
<div class=""col-lg-12 control-section"">
    <div class=""row"">
        <div class=""content-wrapp");
            WriteLiteral("er\">\n            <input id=\"sFeedbackUser\" />\n        </div>\n    </div>\n</div>\n<div class=\"col-lg-12 control-section\">\n    <div class=\"row\">\n        <div class=\"position-relative form-group\" style=\"width:100%;\" ><label for=\"Feedback\"");
            BeginWriteAttribute("class", " class=\"", 3364, "\"", 3372, 0);
            EndWriteAttribute();
            WriteLiteral(@">Feedback</label><div name=""Feedback"" style=""min-height:400px;"" id=""Feedback"" class=""form-control""></div></div>
    </div>
</div>
<div class=""col-lg-12 control-section text-center"">
    <button id=""sendFeedback"" onclick=""PostFeedback()"" style=""text-align:center;""><i class=""fas fa-plus""></i> Submit</a>
</div>
<script>
var RepoSteps;
var sendFeedback = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
sendFeedback.appendTo('#sendFeedback');
var sFeedbackUser = new ej.inputs.TextBox({
        placeholder: 'First Name',
        floatLabelType: 'Auto'
    });
    sFeedbackUser.appendTo('#sFeedbackUser');
$( document ).ready(function() {

    RepoSteps = new Quill('#Feedback', {
        theme: 'snow'
    });
    var minRangeObj = new ej.inputs.Slider({
        value: 5,
        type: 'MinRange'
    });
    minRangeObj.appendTo('#out');

});


function PostFeedback()
{
     var messagesDto= {
            ""ProjectId"":");
#nullable restore
#line 151 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/OutboundComponents/PublicFeedback/Default.cshtml"
                   Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            ""SenderName"": $(""#sFeedbackUser"").val(),
            ""MessageContent"": $(""#Feedback"").children()[0].innerHTML
        }
        console.log(messagesDto);
        if($(""#sFeedbackUser"").val() && $(""#Feedback"").children()[0].innerHTML)
        {
            $.ajax({
                type: 'POST',
                url: '/OutboundDetails/LeaveFeedback',
                data: JSON.stringify(messagesDto),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                
                success: function (response) {
                    window.location=document.referrer;

                },
                error: function (xhr, status, error) {
                    console.log(error);
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