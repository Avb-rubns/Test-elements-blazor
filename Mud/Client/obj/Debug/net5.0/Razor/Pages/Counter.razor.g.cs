#pragma checksum "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2338c408ff50b4fe051205844df1420742bec174"
// <auto-generated/>
#pragma warning disable 1591
namespace Mud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using Mud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using Mud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rubns\source\repos\Mud\Mud\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(2);
                __builder2.AddAttribute(3, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.Mud.Client.Pages.Counter.TypeInference.CreateMudSlider_0(__builder3, 5, 6, 
#nullable restore
#line 7 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                        1

#line default
#line hidden
#nullable disable
                    , 7, 
#nullable restore
#line 7 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                20

#line default
#line hidden
#nullable disable
                    , 8, 
#nullable restore
#line 7 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                               true

#line default
#line hidden
#nullable disable
                    , 9, 
#nullable restore
#line 7 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                           1

#line default
#line hidden
#nullable disable
                    , 10, 
#nullable restore
#line 7 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                                           papers

#line default
#line hidden
#nullable disable
                    , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => papers = __value, papers)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(13);
                __builder2.AddAttribute(14, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudSelect<Justify>>(16);
                    __builder3.AddAttribute(17, "Label", "Justify");
                    __builder3.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Justify>(
#nullable restore
#line 10 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                            justification

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Justify>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Justify>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => justification = __value, justification))));
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.Mud.Client.Pages.Counter.TypeInference.CreateMudSelectItem_1(__builder4, 21, 22, 
#nullable restore
#line 11 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                  Justify.FlexStart

#line default
#line hidden
#nullable disable
                        , 23, (__builder5) => {
                            __builder5.AddContent(24, "Flex Start");
                        }
                        );
                        __builder4.AddMarkupContent(25, "\r\n            ");
                        __Blazor.Mud.Client.Pages.Counter.TypeInference.CreateMudSelectItem_2(__builder4, 26, 27, 
#nullable restore
#line 12 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                  Justify.FlexEnd

#line default
#line hidden
#nullable disable
                        , 28, (__builder5) => {
                            __builder5.AddContent(29, "Flex End");
                        }
                        );
                        __builder4.AddMarkupContent(30, "\r\n            ");
                        __Blazor.Mud.Client.Pages.Counter.TypeInference.CreateMudSelectItem_3(__builder4, 31, 32, 
#nullable restore
#line 13 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                  Justify.Center

#line default
#line hidden
#nullable disable
                        , 33, (__builder5) => {
                            __builder5.AddContent(34, "Center");
                        }
                        );
                        __builder4.AddMarkupContent(35, "\r\n            ");
                        __Blazor.Mud.Client.Pages.Counter.TypeInference.CreateMudSelectItem_4(__builder4, 36, 37, 
#nullable restore
#line 14 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                  Justify.SpaceAround

#line default
#line hidden
#nullable disable
                        , 38, (__builder5) => {
                            __builder5.AddContent(39, "Space Around");
                        }
                        );
                        __builder4.AddMarkupContent(40, "\r\n            ");
                        __Blazor.Mud.Client.Pages.Counter.TypeInference.CreateMudSelectItem_5(__builder4, 41, 42, 
#nullable restore
#line 15 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                  Justify.SpaceBetween

#line default
#line hidden
#nullable disable
                        , 43, (__builder5) => {
                            __builder5.AddContent(44, "Space Between");
                        }
                        );
                        __builder4.AddMarkupContent(45, "\r\n            ");
                        __Blazor.Mud.Client.Pages.Counter.TypeInference.CreateMudSelectItem_6(__builder4, 46, 47, 
#nullable restore
#line 16 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                  Justify.SpaceEvenly

#line default
#line hidden
#nullable disable
                        , 48, (__builder5) => {
                            __builder5.AddContent(49, "Space Evenly");
                        }
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(51);
                __builder2.AddAttribute(52, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(54);
                    __builder3.AddAttribute(55, "Justify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 20 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                          justification

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 21 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
             for (int i = 0; i < papers; i++)
            {
                int localindex = i;
                Console.WriteLine(localindex);

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudItem>(57);
                        __builder4.AddAttribute(58, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                              breaks[localindex]

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudPaper>(60);
                            __builder5.AddAttribute(61, "Class", "d-flex align-center justify-center mud-width-full py-8");
                            __builder5.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(63, "table");
                                __builder6.OpenElement(64, "tr");
                                __builder6.OpenElement(65, "td");
                                __builder6.OpenComponent<MudBlazor.MudIconButton>(66);
                                __builder6.AddAttribute(67, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                          Icons.Material.Filled.KeyboardArrowUp

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(68, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                                                                          (()=>UpdateBreaks(localindex,1))

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(69, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 30 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                                                                                                                  Size.Small

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(70, "\r\n                            ");
                                __builder6.OpenElement(71, "tr");
                                __builder6.OpenElement(72, "td");
                                __builder6.OpenComponent<MudBlazor.MudText>(73);
                                __builder6.AddAttribute(74, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 35 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                   Typo.h6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(75, "Style", "margin:2px 4px 2px 4px;");
                                __builder6.AddAttribute(76, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 35 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                                                                   Align.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(78, 
#nullable restore
#line 35 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                                                                                  breaks[localindex]

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(79, "\r\n                            ");
                                __builder6.OpenElement(80, "tr");
                                __builder6.OpenElement(81, "td");
                                __builder6.OpenComponent<MudBlazor.MudIconButton>(82);
                                __builder6.AddAttribute(83, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                          Icons.Material.Filled.KeyboardArrowDown

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(84, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                                                                            (()=>UpdateBreaks(localindex,-1))

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(85, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 40 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
                                                                                                                                                     Size.Small

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 46 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\rubns\source\repos\Mud\Mud\Client\Pages\Counter.razor"
      

    int _papers = 7;
    int papers { get { return _papers; } set { UpdatePapers(value); } }

    int[] breaks = new int[7] { 3, 4, 2, 3, 3, 2, 4 };

    Justify justification = Justify.FlexStart;

    void UpdatePapers(int value)
    {

        int[] newbreaks = Enumerable.Repeat(3, value).ToArray();

        for (int i = 0; i < newbreaks.Length; i++)
        {
            if (i < breaks.Length)
            {
                newbreaks[i] = breaks[i];
            }
        }

        breaks = newbreaks;

        _papers = value;

        StateHasChanged();
    }

    void UpdateBreaks(int index, int changeamount)
    {
        List<int> newbreaks = breaks.ToList();

        newbreaks[index] = newbreaks[index] += changeamount;

        breaks = newbreaks.ToArray();

        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Mud.Client.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudSlider_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, T __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, T __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudSlider<T>>(seq);
        __builder.AddAttribute(__seq0, "Min", __arg0);
        __builder.AddAttribute(__seq1, "Max", __arg1);
        __builder.AddAttribute(__seq2, "Immediate", __arg2);
        __builder.AddAttribute(__seq3, "Step", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591