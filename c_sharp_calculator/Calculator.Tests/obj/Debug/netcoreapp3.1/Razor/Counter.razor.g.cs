#pragma checksum "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d8dc70fea2f78c2a5c64c1622077beeb977b61"
// <auto-generated/>
#pragma warning disable 1591
namespace Calculator.Tests
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Bunit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Bunit.Mocking.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Xunit;

#line default
#line hidden
#nullable disable
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\n    Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\Counter.razor"
                    currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\Counter.razor"
       
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
