#pragma checksum "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f1e10db1012dc7c08e7a7cb6723f0e31b538e3d"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskLists.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using TaskLists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\misha\Desktop\TaskLists\TaskLists\_Imports.razor"
using TaskLists.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
using TaskLists.Data;

#line default
#line hidden
#nullable disable
    public partial class AddFolderComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin: 0;");
            __builder.AddAttribute(2, "class", "container-fluid row justify-content-center flex-row");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "placeholder", "Назва папки");
            __builder.AddAttribute(7, "class", "form-control col-lg-10");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                                           folder.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => folder.Name = __value, folder.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "col-lg-1 form-control");
            __builder.AddAttribute(13, "style", "background-color:" + " " + (
#nullable restore
#line 5 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                                             folder.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                     folder.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => folder.Color = __value, folder.Color));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 6 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                            Color.Black

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "style", "background-color:" + " " + (
#nullable restore
#line 6 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                    Color.Black

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(20, "Black");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 7 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                            Color.Blue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "style", "background-color:" + " " + (
#nullable restore
#line 7 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                   Color.Blue

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(25, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 8 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                            Color.Green

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "style", "background-color:" + " " + (
#nullable restore
#line 8 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                    Color.Green

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(30, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 9 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                            Color.Orange

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "style", "background-color:" + " " + (
#nullable restore
#line 9 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                     Color.Orange

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(35, "Orange");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", 
#nullable restore
#line 10 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                            Color.Pink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "style", "background-color:" + " " + (
#nullable restore
#line 10 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                   Color.Pink

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(40, "Pink");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", 
#nullable restore
#line 11 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                            Color.Purple

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "style", "background-color:" + " " + (
#nullable restore
#line 11 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                     Color.Purple

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(45, "Purple");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", 
#nullable restore
#line 12 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                            Color.White

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(49, "style", "background-color:" + " " + (
#nullable restore
#line 12 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                    Color.White

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(50, "White");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", 
#nullable restore
#line 13 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                            Color.Yellow

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "style", "background-color:" + " " + (
#nullable restore
#line 13 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                     Color.Yellow

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(55, "Yellow");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "submit");
            __builder.AddAttribute(60, "value", "+");
            __builder.AddAttribute(61, "class", "btn btn-primary col-lg-1 text-center");
            __builder.AddAttribute(62, "style", "padding:0;");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
                                                                                                                 OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\AddFolderComponent.razor"
      
    [Parameter]
    public Folder folder {get;set;}

    [Parameter]
    public EventCallback<MouseEventArgs> OnClickCallback { get; set; }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
