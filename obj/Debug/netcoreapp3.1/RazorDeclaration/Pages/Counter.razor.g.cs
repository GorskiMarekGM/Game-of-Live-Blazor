#pragma checksum "C:\Marek\WSB\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5750f6a3269151a246233038535bc4867d9a57e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
       
    private int currentCount = 0;
    private Data.BioUnit u;
    private Data.Environment e = new Data.Environment(30,30);
    private string theRadio ="";
    private int cyclesPerTime = 0;
    private string option = "";
    private string title = "Add pattern...";
    private string penta ="";

    private void IncrementCount()
    {
        currentCount++;
        e.nextConwayStep();
    }

    private void ClickRadio(ChangeEventArgs args){
        theRadio = args.Value.ToString();
        currentCount++;
    }

    private void PatternManagement(){
        if(title=="Add pattern..."){
            title = "Add pattern(-)";
            penta = "Add pattern pentadecathlon";
        }else{
            title="Add pattern...";
            penta ="";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
