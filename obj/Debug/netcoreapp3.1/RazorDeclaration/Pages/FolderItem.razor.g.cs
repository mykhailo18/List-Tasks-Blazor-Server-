#pragma checksum "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db43a24ce8f17cb2736326a0e414e10a71846e3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 5 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
using TaskLists.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
using TaskLists.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/folder")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/folder/{Id:int}")]
    public partial class FolderItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\misha\Desktop\TaskLists\TaskLists\Pages\FolderItem.razor"
      
    [Parameter]
    public int Id { get; set; } = -1;

    public static Item newItem = new Item() { Date = DateTime.Now, Time = DateTime.Now, IsNotificationTelegram = true };
    private Folder folder;

    private Item itemClick;
    private string styleForContextMenuItem = string.Empty;
    private bool hideOrShowItem = false;

    AuthenticationState authState;
    System.Security.Claims.ClaimsPrincipal user;

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("materializeMethods");
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    [JSInvokable("setDate")]
    public static async void SetDate(string instances)
    {
        newItem.Date = DateTime.Parse(instances);
    }
    [JSInvokable("setTime")]
    public static async void SetTime(string hour, string minutes)
    {
        newItem.Time = new DateTime(2000, 1, 1, Int32.Parse(hour), Int32.Parse(minutes), 0);
    }
    private async Task<DateTime> GetDate()
    {
        string s = await JSRuntime.InvokeAsync<string>("getDate");
        DateTime a = new DateTime();
        DateTime.TryParse(s, out a);
        await JSRuntime.InvokeVoidAsync("alert(getDate);");
        return a;
    }

    protected async override Task OnInitializedAsync()
    {
        authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        user = authState.User;
        if (user.Identity.Name == null) return;
        folder = await Service.GetFolderAndItemsAsync(Id, user.Identity.Name);
    }

    private async Task RefreshFolder()
    {
        folder = await Service.GetFolderAndItemsAsync(Id, user.Identity.Name);
    }
    private void HideContextMenuItem(MouseEventArgs args)
    {
        hideOrShowItem = false;
    }
    private void OnRightClickItem(MouseEventArgs args, Item item)
    {
        if (args.Button == 2)
        {
            itemClick = item;
            styleForContextMenuItem = $"top: {args.ClientY}px; left:{args.ClientX}px;";
            hideOrShowItem = true;
        }
    }

    private void EditItem(MouseEventArgs args, Item item)
    {
        item.StatusModel = StatusModel.Edit;
        hideOrShowItem = false;

    }
    private async void DeleteItem(MouseEventArgs args, Item item)
    {
        await Service.DeleteItem(item);
        hideOrShowItem = false;
        await RefreshFolder();
    }
    private async void SaveItem(MouseEventArgs args, Item item)
    {
        await Service.EditItem(item);
        item.StatusModel = StatusModel.Static;
    }




    private async Task NewItem()
    {
        bool result = await Service.AddItem(newItem, Id);
        if (result)
        {
            newItem = new Item() { Date = DateTime.Now, Time = DateTime.Now, IsNotificationTelegram = true };
            await RefreshFolder();
        }
    }

    public async override Task SetParametersAsync(ParameterView parameters)
    {
        IReadOnlyDictionary<string, object> dic = parameters.ToDictionary();
        if (Id != dic["Id"] as int?)
        {
            await base.SetParametersAsync(parameters);
            await RefreshFolder();
        }

        await base.SetParametersAsync(parameters);
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