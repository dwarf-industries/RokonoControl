#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fe3bd6bc7c6c12d0bdbf4dc868ffd857e0e3397"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Notes_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Notes/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe3bd6bc7c6c12d0bdbf4dc868ffd857e0e3397", @"/Views/Shared/Components/Notes/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Notes_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
  
    var Notes = ViewData["Notes"] as List<UserNotes>;
    var ProjectId = ViewData["ProjectId"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <style>

.e-icons {
    font-family: ""e-icons"" !important;
}

.Note {
    padding: 40px;
    cursor: move;
    z-index: 10;
    position: absolute;
    width: 200px;
    height: 200px;
    background-color:orange; 
    overflow: hidden;
}
.Icon-FullScreen::before
{
    font-family: ""e-icons"" !important;
    content: '\e342';
    font-size: large;
    cursor: pointer;

}
.Icon-Edit::before
{
    font-family: ""e-icons"" !important;
    content: '\e81e';
    font-size: large;

    cursor: pointer;

}
.Icon-Delete::before
{
    font-family: ""e-icons"" !important;
    content: '\e84e';
    font-size: large;
    cursor: pointer;

}
.NoteEditor{
    position: absolute;
    width:100%;
    min-height:100%;
    background:#fff;
    padding:2%;
}
    </style>
    <link href=""https://cdn.quilljs.com/1.3.6/quill.snow.css"" rel=""stylesheet"">
<!-- Main Quill library -->
<script src=""//cdn.quilljs.com/1.3.6/quill.js""></script>
<script src=""//cdn.quilljs.com/1.3.6/quill.min.js""></script>
<div id=""NotesOverlay""  style=""positi");
            WriteLiteral(@"on: absolute; z-index:55; background:#64424221;width:100%;height:100%; display: none;"">
    <div class=""row"">
        <button  type=""button"" id=""NewNote"" class=""btn btn-primary"" style=""margin-top:2px; width:100%"" onclick=""AddNewNote(true)"">New note</button>
    </div>
    <div class=""row"" id=""NotesHolder"">
");
#nullable restore
#line 64 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
         foreach(var note in Notes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 1504, "\"", 1522, 2);
            WriteAttributeValue("", 1509, "Note_", 1509, 5, true);
#nullable restore
#line 66 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 1514, note.Id, 1514, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1523, "\"", 1635, 12);
            WriteAttributeValue("", 1531, "Background-Color:", 1531, 17, true);
#nullable restore
#line 66 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 1548, note.NoteBackground, 1548, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1568, ";", 1568, 1, true);
            WriteAttributeValue(" ", 1569, "Color:", 1570, 7, true);
#nullable restore
#line 66 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 1576, note.NoteForeground, 1576, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1596, ";", 1596, 1, true);
            WriteAttributeValue(" ", 1597, "top:", 1598, 5, true);
#nullable restore
#line 66 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 1602, note.TopPos, 1602, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1614, ";", 1614, 1, true);
            WriteAttributeValue(" ", 1615, "left:", 1616, 6, true);
#nullable restore
#line 66 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 1621, note.LeftPos, 1621, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1634, ";", 1634, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1636, "\"", 1687, 5);
            WriteAttributeValue("", 1646, "DragEnableNote(\'Note_", 1646, 21, true);
#nullable restore
#line 66 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 1667, note.Id, 1667, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1675, "\',", 1675, 2, true);
#nullable restore
#line 66 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue(" ", 1677, note.Id, 1678, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1686, ")", 1686, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"Note\">\n                <div class=\"row\">\n                    <div class=\"col-md-8\">\n                        <span>");
#nullable restore
#line 69 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
                         Write(note.DateOfMessage.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                    <div class=\"col-md-4\">\n                        <span class=\"Icon-FullScreen\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1986, "\"", 2060, 9);
            WriteAttributeValue("", 1996, "OpenFullScreen(\'", 1996, 16, true);
#nullable restore
#line 72 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 2012, note.TopPos, 2012, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2024, "\',", 2024, 2, true);
            WriteAttributeValue(" ", 2026, "\'", 2027, 2, true);
#nullable restore
#line 72 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 2028, note.LeftPos, 2028, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2041, "\',", 2041, 2, true);
            WriteAttributeValue(" ", 2043, "\'Note_", 2044, 7, true);
#nullable restore
#line 72 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 2050, note.Id, 2050, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2058, "\')", 2058, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n\n                        </span>\n                        <span class=\"Icon-Edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2143, "\"", 2243, 10);
            WriteAttributeValue("", 2153, "ChangeNoteContent(", 2153, 18, true);
#nullable restore
#line 75 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 2171, note.Id, 2171, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2179, ",\'", 2179, 2, true);
#nullable restore
#line 75 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 2181, note.Content, 2181, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2194, "\',\'", 2194, 3, true);
#nullable restore
#line 75 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 2197, note.NoteBackground, 2197, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2217, "\',", 2217, 2, true);
            WriteAttributeValue(" ", 2219, "\'", 2220, 2, true);
#nullable restore
#line 75 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 2221, note.NoteForeground, 2221, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2241, "\')", 2241, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n\n                        </span>\n                        <span class=\"Icon-Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2328, "\"", 2358, 3);
            WriteAttributeValue("", 2338, "DeleteNote(", 2338, 11, true);
#nullable restore
#line 78 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
WriteAttributeValue("", 2349, note.Id, 2349, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2357, ")", 2357, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">

                        </span>
                    </div>
                </div>
                <div class=""row"" style=""text-align: justify; word-break: break-all;"">
                    <div style=""overflow: hidden;display: -webkit-box;-webkit-line-clamp: 3;-webkit-box-orient: vertical; padding:2%;"">
                        ");
#nullable restore
#line 85 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
                   Write(Html.Raw(@note.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 89 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
   
</div>
<div id=""NoteEditor"" class=""NoteEditor"" style=""display: none; z-index:22;"">
    <div class=""row"" style=""padding:2%;"">
        <div class=""col-md-4"">
            <div id=""picker"" class=""col-xs-12 col-sm-12 col-lg-6 col-md-6"">
                <h4>Background Color</h4>
                <input id=""BackgroundColorPicker"" type=""color"">
            </div>
        </div>
        <div class=""col-md-4"">
            <div id=""picker"" class=""col-xs-12 col-sm-12 col-lg-6 col-md-6"">
                <h4>Font Color</h4>
                <input id=""ForegroundColorPicker"" type=""color"">
            </div>
        </div>
        <div class=""col-md-4"">
              <div id=""ExampleNote"" style=""padding: 2%;""   style=""width:100%; background-color:orange; color:white;"">
                <div class=""row"">
                    <div class=""col-md-8"">
                        <span>");
#nullable restore
#line 111 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
                         Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <div class=""col-md-4"">
                        <span class=""Icon-FullScreen"" >

                        </span>
                    </div>
                </div>
                <div class=""row"" style=""text-align: justify; word-break: break-all;"">
                    <p id=""ExampleNoteText"" style=""overflow: hidden;display: -webkit-box;-webkit-line-clamp: 7;-webkit-box-orient: vertical; padding:5%;"">
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker in");
            WriteLiteral("cluding versions of Lorem Ipsum.\n                    </p>\n                </div>\n            </div>\n        </div>\n    </div>\n    <Div class=\"row\">\n        <div class=\"position-relative form-group\" style=\"width:100%;\" ><label for=\"NoteEditorText\"");
            BeginWriteAttribute("class", " class=\"", 4981, "\"", 4989, 0);
            EndWriteAttribute();
            WriteLiteral(@">Repo Steps</label><div name=""NoteEditorText"" id=""NoteEditorText"" class=""form-control""></div></div>
    </Div>
    <div class=""row"" style=""display: inline-flex;width:100%;"">
        <button  type=""button"" id=""SaveNote"" class=""btn btn-primary"" style=""margin-top:2px; width:100%"" onclick=""AcceptChanges()"">Save Note</button>
        <button  type=""button"" id=""CancelNote"" class=""btn btn-primary"" style=""margin-top:2px; width:100%"" onclick=""CancelChanges()"">Cancel</button>
    </div>
</div>


<script>
    ej.base.enableRipple(true);
    var selectedNote;
    var NoteId;
    var lastTop;
    var latLeft;
    var isOpen = false;
    var lastNote;
    var CurrentContent;
    var CurrentColor;
    var CurrentFontColor;
    var CurrentId;
    var IsNew = false;
    var BackgroundColorPicker = new ej.inputs.ColorPicker({
        mode: 'Picker',
        modeSwitcher: false,
        inline: true,
        showButtons: false,
        change: BackgroundChange
    });
    BackgroundColorPicker.appendTo('#BackgroundColorPicker')");
            WriteLiteral(@";

    var ForegroundColorPicker = new ej.inputs.ColorPicker({
        mode: 'Picker',
        modeSwitcher: false,
        inline: true,
        showButtons: false,
        change: ForegroundChange
    });
    ForegroundColorPicker.appendTo('#ForegroundColorPicker');
     
       
     
    var NoteEditorText = new Quill('#NoteEditorText', {
            theme: 'snow'
    });


    NoteEditorText.on('text-change', function(delta, oldDelta, source) {
        $(""#ExampleNoteText"").html( $(""#NoteEditorText"").children()[0].innerHTML);
    });
    var BackgroundColor = ""#fff"";
    var FontColor = ""#fff"";
    var notesSatus = false;
    var SaveNote = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    SaveNote.appendTo('#SaveNote');
    var CancelNote = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    CancelNote.appendTo('#CancelNote');
    var NotesBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    NotesBtn.appendTo('#NotesBtn');
    var NewNote =");
            WriteLiteral(@" new ej.buttons.Button({  isPrimary: true });
    NewNote.appendTo('#NewNote');


    function ShowNotes()
    {
        if(notesSatus === false)
        {
            $(""#NotesOverlay"").show();
            notesSatus = true;
        }
        else
        {
            $(""#NotesOverlay"").hide();
            notesSatus = false;
        }
    }


function ChangeNoteContent(id, content, background, fontColor)
{
    CurrentContent = content;
    CurrentColor = background;
    CurrentFontColor = fontColor;
    CurrentId = id;
    AddNewNote(false);
}

function AddNewNote(condition)
{
    IsNew = condition;
    $(""#NoteEditor"").show();
    $(""#NotesOverlay"").hide();
    if(condition === false)
    {
        $(""#NoteEditorText"").children()[0].innerHTML = CurrentContent;
    }

}
function DragEnableNote(id, noteId)
{
    NoteId = noteId;
    selectedNote = document.getElementById(id);
    dragElement(selectedNote);

}


function dragElement(elmnt) {
  var pos1 = 0, pos2 = 0, pos3 = 0, pos4 = 0;
  if (document.getEle");
            WriteLiteral(@"mentById(elmnt.id)) {
    // if present, the header is where you move the DIV from:
    document.getElementById(elmnt.id).onmousedown = dragMouseDown;
  } else {
    // otherwise, move the DIV from anywhere inside the DIV:
    elmnt.onmousedown = dragMouseDown;
  }

  function dragMouseDown(e) {
    e = e || window.event;
    e.preventDefault();
    // get the mouse cursor position at startup:
    pos3 = e.clientX;
    pos4 = e.clientY;
    document.onmouseup = closeDragElement;
    // call a function whenever the cursor moves:
    document.onmousemove = elementDrag;
  }

  function elementDrag(e) {
    e = e || window.event;
    e.preventDefault();
    // calculate the new cursor position:
    pos1 = pos3 - e.clientX;
    pos2 = pos4 - e.clientY;
    pos3 = e.clientX;
    pos4 = e.clientY;
    // set the element's new position:
    elmnt.style.top = (elmnt.offsetTop - pos2) + ""px"";
    elmnt.style.left = (elmnt.offsetLeft - pos1) + ""px"";
  }

  function closeDragElement(e) {
    console.log(selectedNote.styl");
            WriteLiteral(@"e.top);
    console.log(selectedNote.style.left);

    var dto = {
            ""NoteId"" :NoteId,
            ""Top"" :selectedNote.style.top,
            ""Left"": selectedNote.style.left
        }
    $.ajax({
    type: 'POST',
        url: '/Notification/ChangeNotePosition',
        data: JSON.stringify(dto),
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        success: function (response) {
            
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    });
    //console.log(selectedNote.css(""left""));

    // stop moving when mouse button is released:
    document.onmouseup = null;
    document.onmousemove = null;
  }
}

function BackgroundChange(args) {
    BackgroundColor = args.currentValue.rgba;
    console.log(args.currentValue.rgba);
    $('#ExampleNote').css('background-color', args.currentValue.rgba);
}
function ForegroundChange(args) {
    FontColor = args.currentValue.rgba;
    $('#ExampleNote').css('color', arg");
            WriteLiteral(@"s.currentValue.rgba);
}

function AcceptChanges()
{
    if(IsNew == true)
        InsertNewNote();
    else
        EditNote();
}
function EditNote()
{
    var dto = {
        ""Content"" : $(""#NoteEditorText"").children()[0].innerHTML,
        ""Background"": BackgroundColor,
        ""FontColor"": FontColor,
        ""NoteId"" : CurrentId
    }
    $.ajax({
    type: 'POST',
        url: '/Notification/EditNote',
        data: JSON.stringify(dto),
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        success: function (response) {
            location.reload(); 
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    });
}
function InsertNewNote()
{
       var dto = {
            ""ProjectId"" : ");
#nullable restore
#line 341 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/Notes/Default.cshtml"
                     Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            ""Content"" : $(""#NoteEditorText"").children()[0].innerHTML,
            ""Background"": BackgroundColor,
            ""FontColor"": FontColor,
            
        }
        $.ajax({
        type: 'POST',
            url: '/Notification/AddNewNote',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                location.reload(); 
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
}


function DeleteNote(id)
{
    ShowLoader();
    var dto = {
        ""NoteId"":id
    }
    $.ajax({
    type: 'POST',
        url: '/Notification/DeleteNote',
        data: JSON.stringify(dto),
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        success: function (response) {
            location.reload(); 
        },
        error: function (xhr, status, error) {
            console.lo");
            WriteLiteral(@"g(error);
        }
    });
}
function OpenFullScreen(top,left,id)
{
    console.log(""in"");
    if(isOpen == false)
    {
        lastNote = document.getElementById(id);
        lastTop = top;
        lastLeft = left;
        lastNote.style.left = 0;
        lastNote.style.top = 0;
        lastNote.style.width = '100%';
        lastNote.style.height = '100%';
        isOpen = true;
    }
    else
    {
        console.log(""out"");
        lastNote.style.width = '200px';
        lastNote.style.height = '200px';
        lastNote.style.top = lastTop;
        lastNote.style.left = lastLeft;
      
        isOpen = false;
    }
}
function CancelChanges()
{
    $(""#NoteEditor"").hide();
    $(""#NotesOverlay"").show();
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
