#pragma checksum "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\CounterRazorTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4047162ed3ad5be255cafb4bf510052c8d4751e2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Calculator.Tests
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 2 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 3 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 4 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#line 6 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Bunit;

#line default
#line hidden
#line 7 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Bunit.Mocking.JSInterop;

#line default
#line hidden
#line 8 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\_Imports.razor"
using Xunit;

#line default
#line hidden
    public partial class CounterRazorTest : TestComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 38 "c:\repos\calculator\c_sharp_calculator\Calculator.Tests\CounterRazorTest.razor"
 
    public void Test(Fixture fixture)
    {
        // Arrange
        var cut = fixture.GetComponentUnderTest<Counter>();

        // Act - click button to increment counter
        cut.Find("button").Click();

        // Assert that the counter was incremented
        var expected = fixture.GetFragment();
        cut.Find("p").MarkupMatches(expected);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
