#pragma checksum "C:\repos\calculator\c_sharp_calculator\Calculator\Pages\CalculatorPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1b4ee1aad875a1d745fbf1ab62aed671448bed0"
// <auto-generated/>
#pragma warning disable 1591
namespace Calculator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\repos\calculator\c_sharp_calculator\Calculator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\repos\calculator\c_sharp_calculator\Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\repos\calculator\c_sharp_calculator\Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\repos\calculator\c_sharp_calculator\Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\repos\calculator\c_sharp_calculator\Calculator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\repos\calculator\c_sharp_calculator\Calculator\_Imports.razor"
using Calculator;

#line default
#line hidden
#line 7 "C:\repos\calculator\c_sharp_calculator\Calculator\_Imports.razor"
using Calculator.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculator")]
    public partial class CalculatorPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Calculator</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, 
#line 6 "C:\repos\calculator\c_sharp_calculator\Calculator\Pages\CalculatorPage.razor"
         currentInput()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#line 7 "C:\repos\calculator\c_sharp_calculator\Calculator\Pages\CalculatorPage.razor"
     foreach (var digit in @digits)
            {

#line default
#line hidden
            __builder.AddContent(6, "               ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "id", 
#line 9 "C:\repos\calculator\c_sharp_calculator\Calculator\Pages\CalculatorPage.razor"
                           digit

#line default
#line hidden
            );
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 9 "C:\repos\calculator\c_sharp_calculator\Calculator\Pages\CalculatorPage.razor"
                                             () => addToInput(@digit)

#line default
#line hidden
            ));
            __builder.AddContent(10, 
#line 9 "C:\repos\calculator\c_sharp_calculator\Calculator\Pages\CalculatorPage.razor"
                                                                         digit

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#line 10 "C:\repos\calculator\c_sharp_calculator\Calculator\Pages\CalculatorPage.razor"
            }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, 
#line 12 "C:\repos\calculator\c_sharp_calculator\Calculator\Pages\CalculatorPage.razor"
    getResult()

#line default
#line hidden
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 14 "C:\repos\calculator\c_sharp_calculator\Calculator\Pages\CalculatorPage.razor"
       
    List<int> digits = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

    List<string> inputs = new List<string>();

    void addToInput(int digit)
    {
        inputs.Add(digit.ToString());
    }

    string currentInput()
    {
        return string.Join("", inputs);
    }

    decimal getResult()
    {
        var calculation = currentInput();
        if (calculation.Count() == 0)
        {
            return 0;
        }

        return Convert.ToDecimal(currentInput());
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
