#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454572fb5f8cd8473ee6d89d22ceb86a637e2cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Documentation_DocumentationPage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454572fb5f8cd8473ee6d89d22ceb86a637e2cbf", @"/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Documentation_DocumentationPage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
  
    var PagesData = ViewData["PageData"] as  List<AssociatedDocumentationCategoryPage>;
    var Category = ViewData["CategoryId"] as int?;
    var ProjectId = ViewData["ProjectId"] as int?;
    var UserRights = ViewData["UserRights"] as UserRights;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #DocumentationPageControl img{
        width: 100%;
    }
    #DocumentationPageControl .row{
        padding: 20px;
    }
    .DocumentationMaxHeight{
        max-height: 83vh;
        overflow-y: auto;
    }

    .DocumentationMaxHeight html {
    scroll-behavior: smooth;
    }
    .SideLinkHolder{
        padding-left: 20px;
        padding-right: 20px;
        padding-top: 3px;
        padding-bottom: 3px;

        border-bottom: #e3165b 2px solid;
    }
    .SideLink{

        font-size: 18px;
        color: #797979;
    }
    .SideLink:hover{
        cursor: pointer;
        color:#e3165b;
    }
</style>
<div class=""row"">
    <div class=""col-md-9 DocumentationMaxHeight"">
");
#nullable restore
#line 42 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
         if(PagesData != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
             foreach (var currentPage in PagesData)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"DocumentationSection\"");
            BeginWriteAttribute("id", " id=\"", 1108, "\"", 1136, 2);
            WriteAttributeValue("", 1113, "Current_", 1113, 8, true);
#nullable restore
#line 46 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
WriteAttributeValue("", 1121, currentPage.Id, 1121, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\n");
#nullable restore
#line 47 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                     if(UserRights.Documentation == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\" style=\"display:flex;\">\n                            <hr/>\n                                <button class=\"btn btn-primary e-control e-btn e-lib e-outline e-primary\" style=\"width: 50%; margin:1%;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1451, "\"", 1495, 3);
            WriteAttributeValue("", 1461, "OpenEditPageModal(", 1461, 18, true);
#nullable restore
#line 51 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
WriteAttributeValue("", 1479, currentPage.Id, 1479, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1494, ")", 1494, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit page</button>\n                                <button class=\"btn btn-primary e-control e-btn e-lib e-outline e-primary\" style=\"width: 50%;margin:1%;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1651, "\"", 1688, 3);
            WriteAttributeValue("", 1661, "DeletePage(", 1661, 11, true);
#nullable restore
#line 52 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
WriteAttributeValue("", 1672, currentPage.Id, 1672, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1687, ")", 1687, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete page</button>\n                            <hr/>\n                        </div>\n");
#nullable restore
#line 55 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"DocumentationBody\">\n                         ");
#nullable restore
#line 57 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                    Write(Html.Raw(await @GetDocumentationPageContent(currentPage.Content)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n");
#nullable restore
#line 60 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
         if(UserRights.Documentation == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
                <hr/>
                    <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 100%;"" onclick=""OpenNewPageModal(0)"">Add new page</button>
                <hr/>
            </div>
");
#nullable restore
#line 69 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <div class=\"col-md-3 DocumentationMaxHeight\">\n");
#nullable restore
#line 72 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
         if(PagesData != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
             foreach (var quickLink in PagesData)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row SideLinkHolder\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2584, "\"", 2613, 2);
            WriteAttributeValue("", 2591, "#Current_", 2591, 9, true);
#nullable restore
#line 77 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
WriteAttributeValue("", 2600, quickLink.Id, 2600, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"SideLink\"> ");
#nullable restore
#line 77 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                                                                   Write(quickLink.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </div>\n");
#nullable restore
#line 79 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n<div id=\"NewPageModalHodler\">\n \n</div>\n\n");
#nullable restore
#line 87 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
  
    async Task<string> GetDocumentationPageContent(string data)
    {
        var getTableMarkdowns =  GetStrBetweenTags(data,"#opentable","#closetable");
        if(string.IsNullOrEmpty(getTableMarkdowns))
        {
            return data;
        }
        getTableMarkdowns = getTableMarkdowns.Replace("</p>","");
        getTableMarkdowns = getTableMarkdowns.Replace("<p>","");
        
        var result = await Task.Run(() => Component.InvokeAsync("TableBuilder", getTableMarkdowns));
        
        var currentResult = ReplaceMarkdown(data,"#opentable","#closetable");
        var bindingResult = string.Empty;
        if(currentResult.Item1 == null && currentResult.Item2 == null)
        {
            return GetString(result);
        }
        else
        {
            bindingResult += currentResult.Item1;
            bindingResult += GetString(result);
            bindingResult += currentResult.Item2;
            //System.Console.WriteLine(result.Result);
        }
        return bindingResult;
    }
    string GetStrBetweenTags(string value, string startTag, string endTag)
    {
        if (value.Contains(startTag) && value.Contains(endTag))
        {
            int index = value.IndexOf(startTag) + startTag.Length;
            return value.Substring(index, value.IndexOf(endTag) - index);
        }
        
        return null;
    }
    (string, string) ReplaceMarkdown(string value, string startTag, string endTag)
    {
        if (value.Contains(startTag) && value.Contains(endTag))
        {
            int index = value.IndexOf(startTag);
            var endIndex =value.IndexOf(endTag);
            var markdown = string.Empty;
            if(endIndex >= value.Length)
               markdown = value.Substring(index, value.Length-1);
            else
                markdown = value.Substring(index,value.IndexOf(endTag)+endTag.Length - index);

            value = value.Replace(markdown, "____");
            var result = value.Split("____");
            if(result == null)
            {
                return (null,null);
            }
            return (result[0],result[1]);
        }
        
        return (null,null);
    }
    string GetString(Microsoft.AspNetCore.Html.IHtmlContent content)
    {
        using (var writer = new System.IO.StringWriter())
        {        
            content.WriteTo(writer,System.Text.Encodings.Web.HtmlEncoder.Default);
            return writer.ToString();
        } 
    }   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""https://cdn.quilljs.com/1.3.6/quill.snow.css"" rel=""stylesheet"">
<!-- Main Quill library -->
<script src=""//cdn.quilljs.com/1.3.6/quill.js""></script>
<script src=""//cdn.quilljs.com/1.3.6/quill.min.js""></script>

<script>
    function OpenNewPageModal()
    {
        $(""#NewPageModalHodler"").html("""");
        $(""#NewPageModalHodler"").load(""/Documentation/GetPageModal?id=0&&category=");
#nullable restore
#line 166 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                                                                             Write(Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&projectId=");
#nullable restore
#line 166 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                                                                                                  Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""")
        .ajaxSuccess(x => {
            console.log(""Success"")
        });
        
    }

    function OpenEditPageModal(id)
    {
        console.log(id);
        $(""#NewPageModalHodler"").html("""");
        $(""#NewPageModalHodler"").load(""/Documentation/GetPageModal?id=""+id+""&&category=");
#nullable restore
#line 177 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                                                                                  Write(Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&projectId=");
#nullable restore
#line 177 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                                                                                                       Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""")
        .ajaxSuccess(x => {
            console.log(""Success"")
        });
        
    }
    function DeletePage(id)
    {
        $(""#DocumentationPageControl"").html("""");

        var data = {
            ""Id"": id
            
        }
        $.ajax({
            type: 'POST',
            url: '/Documentation/DeletePage',
            data: JSON.stringify(data),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                $(""#DocumentationPageControl"").load('/Documentation/DocumentationPage?id='+");
#nullable restore
#line 198 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                                                                                      Write(Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("+\'&&projectId=");
#nullable restore
#line 198 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml"
                                                                                                             Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\n\n            },\n            error: function (xhr, status, error) {\n                console.log(error);\n            }\n        }); \n     \n    }\n  \n</script>");
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
