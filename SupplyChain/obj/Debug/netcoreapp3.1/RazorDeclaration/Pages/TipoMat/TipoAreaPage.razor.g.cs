#pragma checksum "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c14be6a49de858a31a3376902b1233c03013bca"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SupplyChain.Pages.TipoMat
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using SupplyChain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using SupplyChain.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using System.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using Syncfusion.Blazor.BarcodeGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using SupplyChain.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using SupplyChain.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\a4344\Desktop\SupplyChain\SUPPLYCHAIN\Pages\TipoMat\TipoAreaPage.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tipoarea/list")]
    public partial class TipoAreaPage : TipoAreaPageBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomHttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
