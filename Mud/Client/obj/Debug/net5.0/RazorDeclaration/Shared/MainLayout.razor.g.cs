// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Mud.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using Mud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using Mud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "c:\Users\rubns\Documents\mud\Test-elements-blazor\Mud\Client\Shared\MainLayout.razor"
       
    bool _drawerOpen = true;
    protected override void OnInitialized()
    {
        currentTheme = defaultTheme;
    }

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    void DarkMode()
    {
        if (currentTheme == defaultTheme)
        {
            currentTheme = darkTheme;
        }
        else
        {
            currentTheme = defaultTheme;
        }
    }

    MudTheme currentTheme = new MudTheme();
    MudTheme defaultTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#272c34"
        }
    };

    MudTheme darkTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Primary = "#B21925",
            Secondary = Colors.Green.Accent4,
            AppbarBackground = "#B21925",
            AppbarText = "#FFFF"
        }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
