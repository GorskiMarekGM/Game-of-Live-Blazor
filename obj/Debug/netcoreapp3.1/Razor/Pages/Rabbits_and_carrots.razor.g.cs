#pragma checksum "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f6a5b3f297adbc8a8a6e49800662e733752fc3"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
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
#nullable restore
#line 2 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rabbits_and_carrots")]
    public partial class Rabbits_and_carrots : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Rabbit and Carrots</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<hr>\r\n");
#nullable restore
#line 8 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
  
    //initial pattern
    if(currentCount == 0){
        u = new Data.Rabbit(3,3,e);
        e.insert(3,3,u);
        u = new Data.Rabbit(3,4,e);
        e.insert(3,4,u);
        u = new Data.Rabbit(3,5,e);
        e.insert(3,5,u);
        u = new Data.Rabbit(2,5,e);
        e.insert(2,5,u);
        u = new Data.Rabbit(1,4,e);
        e.insert(1,4,u);

        u = new Data.Carrot(11,14,e);
        e.insert(11,14,u);
        u = new Data.Carrot(12,15,e);
        e.insert(12,15,u);
        u = new Data.Carrot(13,14,e);
        e.insert(13,14,u);
        u = new Data.Carrot(0,0,e);
        e.insert(0,0,u);

        int count1 = e.neighbors(2,4).Count();
        int count2 = e.neighbors(13,14).Count();
        int count3 = e.neighbors(1,1).Count();
        Console.WriteLine("Neighbors");
        Console.WriteLine(count1);
        Console.WriteLine(count2);
        Console.WriteLine(count3);
    }


#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "environment");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 42 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
     for(var i=0; i< @e.total_of_rows(); i++){

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 44 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
             for(var j=0; j< @e.total_of_cols(); j++){
                if(e.bioUnit(i,j)!=null){

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                    ");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "class", "cell");
            __builder.AddAttribute(14, "style", "background-color:" + (
#nullable restore
#line 46 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
                                                              e.bioUnit(i,j).myColor()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 47 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "                    <td class=\"cell dead\"></td>\r\n");
#nullable restore
#line 51 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 54 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n<hr>\r\n");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Next");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Marek\WSB\blazorserver01\Pages\Rabbits_and_carrots.razor"
       
    private int currentCount = 0;

    private Data.Environment e = new Data.Environment(40,40);

    private Data.BioUnit u;

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
