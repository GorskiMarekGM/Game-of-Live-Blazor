#pragma checksum "C:\Marek\WSB\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a243470f4c7595e8b10c9881246429ed515ad1"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Game of Live</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " and current radio ");
            __builder.AddContent(5, 
#nullable restore
#line 5 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                                   theRadio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<hr>\r\n");
#nullable restore
#line 7 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
  
    //initial pattern
    if(currentCount == 0){
       /* e.live(3,3);
        e.live(3,4);
        e.live(2,3);
        e.live(2,4);

        e.live(6,5);
        e.live(5,6);
        e.live(6,6);*/
        e.put_pattern(6,6,"pentadecathlon");
    }


#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "environment");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 23 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
     for(var i=0; i< @e.total_of_rows(); i++){

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 25 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
             for(var j=0; j< @e.total_of_cols(); j++){
               if(true){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "                    <td class=\"cell dead\"></td>\r\n");
#nullable restore
#line 28 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "                    <td class=\"cell dead\"></td>\r\n");
#nullable restore
#line 32 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 35 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenElement(18, "p");
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "radio");
            __builder.AddAttribute(22, "name", "myradiobtn");
            __builder.AddAttribute(23, "checked", 
#nullable restore
#line 39 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   theRadio.Equals("step")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "value", "step");
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 41 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(26, " Step by step\r\n\r\n    ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "radio");
            __builder.AddAttribute(29, "name", "myradiobtn");
            __builder.AddAttribute(30, "checked", 
#nullable restore
#line 44 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   theRadio.Equals("many")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "value", "many");
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 46 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(33, " Several steps\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "style", "display:" + (
#nullable restore
#line 49 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                      theRadio.Equals("many")?"":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.AddMarkupContent(38, "<h5>Cycles specification</h5>\r\n    Number of Cycles\r\n    ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                  cyclesPerTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cyclesPerTime = __value, cyclesPerTime));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(42, " (internal value: ");
            __builder.AddContent(43, 
#nullable restore
#line 52 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                                     cyclesPerTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "))\r\n    <br>\r\n    ");
            __builder.OpenElement(45, "select");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   option

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => option = __value, option));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", "1");
            __builder.AddContent(51, "1 st ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "option");
            __builder.AddAttribute(54, "value", "2");
            __builder.AddContent(55, "2 st ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", "3");
            __builder.AddContent(59, "3 st ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    <br>\r\n    Our option is ");
            __builder.AddContent(62, 
#nullable restore
#line 60 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   option

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n<hr>\r\n");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "class", "btn btn-primary");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(68, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n");
            __builder.AddMarkupContent(70, "<a class=\"btn btn-primary\" href=\"https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life\" target=\"_blank\">\r\n    Look for Patterns in Wikipedia\r\n\r\n</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
       
    private int currentCount = 0;
    private Data.BioUnit u;
    private Data.Environment e = new Data.Environment(30,30);
    private string theRadio ="";
    private int cyclesPerTime = 0;
    private string option = "";

    private void IncrementCount()
    {
        currentCount++;
        e.nextConwayStep();
    }

    private void ClickRadio(ChangeEventArgs args){
        theRadio = args.Value.ToString();
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
