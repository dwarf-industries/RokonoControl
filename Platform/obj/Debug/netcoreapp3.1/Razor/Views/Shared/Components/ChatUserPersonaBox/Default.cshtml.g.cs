#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5269f49aaa6145b1899f905e127449cb636f83d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ChatUserPersonaBox_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5269f49aaa6145b1899f905e127449cb636f83d2", @"/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ChatUserPersonaBox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
  
    var channelRights = ViewData["UserAdministrativeRights"] as bool?;   
    var InputName = Guid.NewGuid().ToString(); 
    var UserId = ViewData["UserId"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
 .ChipTag{
    background: red;
    border-radius: 15px;
    padding: 4px;
    color: white;
 }
 .ChipTag:hover{
    background: red;
    border-radius: 15px;
    padding: 4px;
    color: white;
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.22);
 }

.ChipCloseBtn:before{
    content:'\e7e9';
    font-family: e-icons;
    padding:3px;
    font-size: 13px;
}
.AddNewRoleTag{
    cursor: pointer;
}
.AddNewRoleTag:before
{
    content:'\e823';
    font-family: e-icons;
    padding:3px;
    font-size: 13px;
    cursor: pointer;
}
.AddNewRoleTag:hover{
    color: red;
}
</style>

<div class=""row"">
    <input");
            BeginWriteAttribute("id", " id=\"", 787, "\"", 802, 1);
#nullable restore
#line 45 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
WriteAttributeValue("", 792, InputName, 792, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  style=""margin: 5px;""/>
</div>
<div class=""row"" style=""text-align: center;"">
    <span class=""AddNewRoleTag"">New Role</span>
</div>
<div class=""row"" style=""padding: 15px;"">
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""Del");
            WriteLiteral(@"etingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>
    <span class=""ChipTag"">Owner <span onclick=""DeletingTag(1)"" class=""ChipCloseBtn"" ></span></span>

</div>
<div class=""row"">
    <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 100%;"" onclick=""CloseChatUserPreview()"">Close</button>
</div>
<script>
var UserControlChatInput = new ej.inputs.TextBox({
    placeholder: ""What's on your m");
            WriteLiteral("ind\",\n    floatLabelType: \'Auto\'\n});\nUserControlChatInput.appendTo(\'#");
#nullable restore
#line 77 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
                           Write(InputName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\n\n\n");
            WriteLiteral("\nfunction DeletingTag(id)\n{\n    console.log(id);\n}\n</script>\n\n");
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