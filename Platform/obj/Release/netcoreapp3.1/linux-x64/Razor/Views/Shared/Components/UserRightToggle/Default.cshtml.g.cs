#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edcd87ebf6789f09195a96c908009997efc11a21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserRightToggle_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserRightToggle/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edcd87ebf6789f09195a96c908009997efc11a21", @"/Views/Shared/Components/UserRightToggle/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserRightToggle_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
  
    var ControlName = ViewData["ControlName"] as string;
    var IsEnabled =   ViewData["IsEnabled"] as int?; 
    var ProjectId = ViewData["ProjectId"] as int?;
    var IsFeatureEnabled = ViewData["Enabled"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n <div>\n    <label");
            BeginWriteAttribute("for", " for=\"", 241, "\"", 259, 1);
#nullable restore
#line 9 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
WriteAttributeValue("", 247, ControlName, 247, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"padding:2%; min-width:303px;\"> Enable/Disables ");
#nullable restore
#line 9 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
                                                                               Write(ControlName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n");
#nullable restore
#line 10 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
     if(IsEnabled == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input");
            BeginWriteAttribute("id", " id=\"", 380, "\"", 397, 1);
#nullable restore
#line 12 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
WriteAttributeValue("", 385, ControlName, 385, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\"");
            BeginWriteAttribute("onchange", " onchange=\"", 414, "\"", 453, 3);
            WriteAttributeValue("", 425, "CheckChanged(\'", 425, 14, true);
#nullable restore
#line 12 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
WriteAttributeValue("", 439, ControlName, 439, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 451, "\')", 451, 2, true);
            EndWriteAttribute();
            WriteLiteral("  />\n");
#nullable restore
#line 13 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input");
            BeginWriteAttribute("id", " id=\"", 494, "\"", 511, 1);
#nullable restore
#line 16 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
WriteAttributeValue("", 499, ControlName, 499, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\"");
            BeginWriteAttribute("onchange", " onchange=\"", 528, "\"", 567, 3);
            WriteAttributeValue("", 539, "CheckChanged(\'", 539, 14, true);
#nullable restore
#line 16 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
WriteAttributeValue("", 553, ControlName, 553, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 565, "\')", 565, 2, true);
            EndWriteAttribute();
            WriteLiteral(" disabled />\n");
#nullable restore
#line 17 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<script>\n    var someRight;\n");
#nullable restore
#line 21 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
     if(IsFeatureEnabled == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     ");
            WriteLiteral("   var active = true;\n");
#nullable restore
#line 24 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("      ");
            WriteLiteral("  var active = false;\n");
#nullable restore
#line 27 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n    someRight = new ejs.buttons.Switch({ checked: active });\n    someRight.appendTo(\'#");
#nullable restore
#line 30 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
                    Write(ControlName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\n\n    function CheckChanged(args)\n    {\n        var arg = args;\n        console.log($(\"#\"+args).is(\':checked\'));\n        if(active)\n            active = 0;\n        else\n            active = 1;\n        \n        var dto = {\n            \"projectId\" : ");
#nullable restore
#line 42 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/UserRightToggle/Default.cshtml"
                     Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            ""Phase"" : args,
            ""Id"" : active    
        }
      
        console.log(dto);
        $.ajax({
            type: 'POST',
            url: '/Accounts/ChangeNotificationRight',
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