#pragma checksum "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc5eab9dc88a20b757561a373a77f1b720f6de3"
// <auto-generated/>
#pragma warning disable 1591
namespace SupplyChain.Pages.ABM.ProTarea
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using SupplyChain.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using System.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using Syncfusion.Blazor.BarcodeGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using SupplyChain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sc/protarea/list")]
    public partial class ProTareaPage : SupplyChain.Pages.ProTareax.ProTareaxPageBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-lg-12 control-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "content-wrapper");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __Blazor.SupplyChain.Pages.ABM.ProTarea.ProTareaPage.TypeInference.CreateSfGrid_0(__builder, 6, 7, 
#nullable restore
#line 25 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                     true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 25 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                              true

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 25 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 25 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
            , 11, 
#nullable restore
#line 25 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                                                  true

#line default
#line hidden
#nullable disable
            , 12, 
#nullable restore
#line 26 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                             pts

#line default
#line hidden
#nullable disable
            , 13, 
#nullable restore
#line 26 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                    true

#line default
#line hidden
#nullable disable
            , 14, 
#nullable restore
#line 26 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 26 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 27 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                  true

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 27 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                     true

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 27 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                           true

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 27 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                           Toolbaritems

#line default
#line hidden
#nullable disable
            , 20, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSelectionSettings>(21);
                __builder2.AddAttribute(22, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.SelectionType>(
#nullable restore
#line 28 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                             Syncfusion.Blazor.Grids.SelectionType.Multiple

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<Protarea>>(24);
                __builder2.AddAttribute(25, "OnToolbarClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.ClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 29 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                             ClickHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "OnActionBegin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<Protarea>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<Protarea>>(this, 
#nullable restore
#line 29 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                          ActionBegin

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridFilterSettings>(28);
                __builder2.AddAttribute(29, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.FilterType>(
#nullable restore
#line 30 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                           Syncfusion.Blazor.Grids.FilterType.CheckBox

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridGroupSettings>(31);
                __builder2.AddAttribute(32, "ShowGroupedColumn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(34);
                __builder2.AddAttribute(35, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditMode>(
#nullable restore
#line 32 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                     EditMode.Dialog

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
#nullable restore
#line 34 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                          
                            var pt = (context as Protarea);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(40, @"<ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist""><li class=""nav-item""><a class=""nav-link active"" id=""pills-home-tab"" data-toggle=""pill"" href=""#pills-Generalidades"" role=""tab"" aria-controls=""pills-home"" aria-selected=""true"">Modelos</a></li></ul>
                            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "class", "tab-content");
                    __builder3.AddAttribute(43, "id", "pills-tabContent");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "tab-pane fade show active");
                    __builder3.AddAttribute(46, "id", "pills-Generalidades");
                    __builder3.AddAttribute(47, "role", "tabpanel");
                    __builder3.AddAttribute(48, "aria-labelledby", "pills-home-tab");
                    __builder3.OpenElement(49, "div");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "form-row");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "form-group col-md-6");
                    __builder3.AddMarkupContent(54, "<label class=\"e-float-text e-label-top\">Tarea:</label>\r\n                                                ");
                    __Blazor.SupplyChain.Pages.ABM.ProTarea.ProTareaPage.TypeInference.CreateSfNumericTextBox_1(__builder3, 55, 56, "Codigo", 57, 
#nullable restore
#line 47 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                                      Disabled

#line default
#line hidden
#nullable disable
                    , 58, 
#nullable restore
#line 47 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                             pt.TAREAPROC

#line default
#line hidden
#nullable disable
                    , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pt.TAREAPROC = __value, pt.TAREAPROC)), 60, () => pt.TAREAPROC);
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n\r\n                                            ");
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "class", "form-group col-md-6");
                    __builder3.AddMarkupContent(64, "<label class=\"e-float-text e-label-top\">Descripcion:</label>\r\n                                                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(65);
                    __builder3.AddAttribute(66, "ID", "Descripcion");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                           pt.DESCRIP

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pt.DESCRIP = __value, pt.DESCRIP))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => pt.DESCRIP));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\r\n                                        ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "class", "form-row");
                    __builder3.OpenElement(73, "div");
                    __builder3.AddAttribute(74, "class", "form-group col-md-6");
                    __builder3.AddMarkupContent(75, "<label class=\"e-float-text e-label-top\">Observaciones:</label>\r\n                                                ");
                    __Blazor.SupplyChain.Pages.ABM.ProTarea.ProTareaPage.TypeInference.CreateSfNumericTextBox_2(__builder3, 76, 77, "Codigo", 78, 
#nullable restore
#line 59 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                                     Disabled

#line default
#line hidden
#nullable disable
                    , 79, 
#nullable restore
#line 59 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                             pt.OBSERVAC

#line default
#line hidden
#nullable disable
                    , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pt.OBSERVAC = __value, pt.OBSERVAC)), 81, () => pt.OBSERVAC);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(83);
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(85);
                    __builder3.AddAttribute(86, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                       nameof(Protarea.TAREAPROC)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "HeaderText", "Tarea");
                    __builder3.AddAttribute(88, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 71 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(89, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 71 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "Width", "200");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(92);
                    __builder3.AddAttribute(93, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 72 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                       nameof(Protarea.DESCRIP)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(94, "HeaderText", "Descripcion");
                    __builder3.AddAttribute(95, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 72 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                    TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "Width", "200");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(98);
                    __builder3.AddAttribute(99, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                       nameof(Protarea.OBSERVAC)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "HeaderText", "Observaciones");
                    __builder3.AddAttribute(101, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 73 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                                                                                                       TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "Width", "200");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 103, (__value) => {
#nullable restore
#line 26 "E:\SupplyChain\SUPPLYCHAIN\Pages\ABM\ProTarea\ProTareaPage.razor"
                          Grid = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
            __builder.AddMarkupContent(105, @"<style>
    .form-group.col-md-6 {
        width: 200px;
    }

    label.e-float-text {
        position: relative;
        padding-left: 0;
        top: 10%;
    }

    .e-input-group.e-control-wrapper.customClass {
        color: black;
        background-color: lightblue;
    }
</style>
");
            __builder.AddMarkupContent(106, @"<style>
    #DropArea {
        padding: 50px 25px;
        margin: 30px auto;
        border: 1px solid #c3c3c3;
        text-align: center;
        width: 20%;
        display: inline-flex;
    }

    .e-file-select,
    .e-file-drop {
        display: none;
    }

    body .e-upload-drag-hover {
        outline: 2px dashed brown;
    }

    #uploadfile {
        width: 60%;
        display: inline-flex;
        margin-left: 5%;
    }
</style>


");
            __builder.AddMarkupContent(107, "<style>\r\n    #target {\r\n        height: 500px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomHttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
namespace __Blazor.SupplyChain.Pages.ABM.ProTarea.ProTareaPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Collections.Generic.IEnumerable<TValue> __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, global::System.Boolean __arg8, int __seq9, global::System.Boolean __arg9, int __seq10, global::System.Boolean __arg10, int __seq11, global::System.Boolean __arg11, int __seq12, global::System.Object __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment __arg13, int __seq14, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg14)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "AllowReordering", __arg0);
        __builder.AddAttribute(__seq1, "ShowColumnChooser", __arg1);
        __builder.AddAttribute(__seq2, "ShowColumnMenu", __arg2);
        __builder.AddAttribute(__seq3, "AllowResizing", __arg3);
        __builder.AddAttribute(__seq4, "EnablePersistence", __arg4);
        __builder.AddAttribute(__seq5, "DataSource", __arg5);
        __builder.AddAttribute(__seq6, "AllowExcelExport", __arg6);
        __builder.AddAttribute(__seq7, "AllowRowDragAndDrop", __arg7);
        __builder.AddAttribute(__seq8, "AllowGrouping", __arg8);
        __builder.AddAttribute(__seq9, "AllowSorting", __arg9);
        __builder.AddAttribute(__seq10, "AllowPaging", __arg10);
        __builder.AddAttribute(__seq11, "AllowFiltering", __arg11);
        __builder.AddAttribute(__seq12, "Toolbar", __arg12);
        __builder.AddAttribute(__seq13, "ChildContent", __arg13);
        __builder.AddComponentReferenceCapture(__seq14, (__value) => { __arg14((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateSfNumericTextBox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ID", __arg0);
        __builder.AddAttribute(__seq1, "Enabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateSfNumericTextBox_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ID", __arg0);
        __builder.AddAttribute(__seq1, "Enabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
