#pragma checksum "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6f4a071fe100a60084c556a2deafc16391b7b00"
// <auto-generated/>
#pragma warning disable 1591
namespace karnekaj123.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using karnekaj123;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using karnekaj123.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Syncfusion.EJ2.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Syncfusion.EJ2.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\_Imports.razor"
using Syncfusion.EJ2.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.EJ2.Blazor.Buttons.EjsButton>(5);
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\Pages\Counter.razor"
                     IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Content", "Click me");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Tomi\Downloads\karnekaj123\karnekaj123\karnekaj123\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
