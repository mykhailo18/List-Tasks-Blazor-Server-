#pragma checksum "c:\Users\misha\source\repos\TaskLists\TaskLists\Components\AddFolderComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41781468808e1ab4871a5aa3ed68b97c37bab719"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TaskLists.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\misha\source\repos\TaskLists\TaskLists\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\misha\source\repos\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\misha\source\repos\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\misha\source\repos\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\misha\source\repos\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\misha\source\repos\TaskLists\TaskLists\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\misha\source\repos\TaskLists\TaskLists\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\misha\source\repos\TaskLists\TaskLists\_Imports.razor"
using TaskLists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\misha\source\repos\TaskLists\TaskLists\_Imports.razor"
using TaskLists.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\Users\misha\source\repos\TaskLists\TaskLists\Components\AddFolderComponent.razor"
using TaskLists.Data;

#line default
#line hidden
#nullable disable
    public partial class AddFolderComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "c:\Users\misha\source\repos\TaskLists\TaskLists\Components\AddFolderComponent.razor"
      
    private Folder folder = new Folder();

    private async Task AddFolder()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        await Service.AddFolder(folder, user.Identity.Name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskLists.Data.ItemService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591