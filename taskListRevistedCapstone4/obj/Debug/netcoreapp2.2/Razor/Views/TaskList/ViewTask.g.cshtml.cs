#pragma checksum "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\TaskList\ViewTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff15f6f1af59d490f90d88f011cf458c00d1aba2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskList_ViewTask), @"mvc.1.0.view", @"/Views/TaskList/ViewTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TaskList/ViewTask.cshtml", typeof(AspNetCore.Views_TaskList_ViewTask))]
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
#line 1 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\_ViewImports.cshtml"
using taskListRevistedCapstone4;

#line default
#line hidden
#line 2 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\_ViewImports.cshtml"
using taskListRevistedCapstone4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff15f6f1af59d490f90d88f011cf458c00d1aba2", @"/Views/TaskList/ViewTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33510b06b1234986e9fa38a130b6012128306c01", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskList_ViewTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserTask>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\TaskList\ViewTask.cshtml"
  
    ViewData["Title"] = "ViewTask";

#line default
#line hidden
            BeginContext(46, 21, true);
            WriteLiteral("\r\n<h1>ViewTask</h1>\r\n");
            EndContext();
            BeginContext(97, 19, true);
            WriteLiteral("<div class=\"row\">\r\n");
            EndContext();
#line 9 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\TaskList\ViewTask.cshtml"
     foreach (var task in Model)
    {

#line default
#line hidden
            BeginContext(157, 48, true);
            WriteLiteral("        <div class=\"col-md-6\">\r\n            <h5>");
            EndContext();
            BeginContext(206, 9, false);
#line 12 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\TaskList\ViewTask.cshtml"
           Write(task.Task);

#line default
#line hidden
            EndContext();
            BeginContext(215, 24, true);
            WriteLiteral("</h5>\r\n            <h6> ");
            EndContext();
            BeginContext(240, 12, false);
#line 13 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\TaskList\ViewTask.cshtml"
            Write(task.DueDate);

#line default
#line hidden
            EndContext();
            BeginContext(252, 32, true);
            WriteLiteral("</h6>\r\n            complete?:<p>");
            EndContext();
            BeginContext(285, 13, false);
#line 14 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\TaskList\ViewTask.cshtml"
                    Write(task.Complete);

#line default
#line hidden
            EndContext();
            BeginContext(298, 20, true);
            WriteLiteral("</p>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 318, "\"", 357, 2);
            WriteAttributeValue("", 325, "/TaskList/DeleteTask?Id=", 325, 24, true);
#line 15 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\TaskList\ViewTask.cshtml"
WriteAttributeValue("", 349, task.Id, 349, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(358, 98, true);
            WriteLiteral(">\r\n                <input type=\"submit\" value=\"Delete Task\" />\r\n            </a>\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\TaskList\ViewTask.cshtml"
    }

#line default
#line hidden
            BeginContext(463, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(472, 38, false);
#line 21 "C:\Users\zeL\grandCircus\labs\grandRepo\taskListRevistedCapstone4\taskListRevistedCapstone4\Views\TaskList\ViewTask.cshtml"
Write(Html.ActionLink("Add Task", "AddTask"));

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserTask>> Html { get; private set; }
    }
}
#pragma warning restore 1591
