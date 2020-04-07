#pragma checksum "C:\Users\misha\Desktop\TaskLists\TaskLists\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8836828b2bc59942f28520f68633ecf38d9bfdb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TaskLists.Shared
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
#line 2 "C:\Users\misha\Desktop\TaskLists\TaskLists\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\misha\Desktop\TaskLists\TaskLists\Shared\NavMenu.razor"
using TaskLists.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\misha\Desktop\TaskLists\TaskLists\Shared\NavMenu.razor"
using TaskLists.Pages;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\misha\Desktop\TaskLists\TaskLists\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private Folder folderClick;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
    private Folder folderNew = new Folder() { StatusModel = StatusModel.New };
    private List<Folder> folders = new List<Folder>();
    private bool hideOrShow = false;

    private string styleForContextMenu = string.Empty;

    protected async override Task OnInitializedAsync()
    {
        try
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity.Name == null) return;
            folders = Service.GetFolders(user.Identity.Name).ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            await JSRuntime.InvokeVoidAsync("addEventToggle");
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    private void Close(MouseEventArgs e)
    {
        return;
    }

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private async Task AddFolder(MouseEventArgs e)
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        bool result = await Service.AddFolder(folderNew, user.Identity.Name);
        if (result)
        {
            folders = Service.GetFolders(user.Identity.Name).ToList();
            folders.ForEach(a => a.StatusModel = StatusModel.Static);
            folderNew = new Folder() { StatusModel = StatusModel.New };
        }
    }
    private void OnRightClick(MouseEventArgs args, Folder folder)
    {
        if (args.Button == 2)
        {
            folderClick = folder;
            styleForContextMenu = $"top: {args.ClientY}px; left:{args.ClientX}px;";
            hideOrShow = true;
        }
    }
    private void HideContextMenu(MouseEventArgs args)
    {
        hideOrShow = false;
    }
    private void EditFolder(MouseEventArgs args, Folder folder)
    {
        folder.StatusModel = StatusModel.Edit;
        hideOrShow = false;

    }
    private async void DeleteFolder(MouseEventArgs args, Folder folder)
    {
        await Service.DeleteFolder(folder);
        hideOrShow = false;
        folders.Remove(folder);
    }
    private async void SaveFolder(MouseEventArgs args, Folder folder)
    {
        await Service.EditFolder(folder);
        folder.StatusModel = StatusModel.Static;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskLists.Data.ItemService Service { get; set; }
    }
}
#pragma warning restore 1591
