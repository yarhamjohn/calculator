using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    /// <summary>
    /// These tests are written entirely in C#.
    /// Learn more at https://bunit.egilhansen.com/docs/
    /// </summary>
    public class CounterCSharpTests : TestContext
    {
        [Fact]
        public void PageContainsHeader()
        {
            // Arrange
            var cut = RenderComponent<CalculatorPage>();

            // Assert that content of the header is the title of the correct page
            cut.Find("h1").MarkupMatches("<h1>Calculator</h1>");
        }

        [Fact]
        public void ClickingButtonAddsDigit()
        {
            // Arrange
            var cut = RenderComponent<CalculatorPage>();

            // Act - click button 2 to add digit to input
            cut.Find("button[id=2]").Click();

            // Assert that the number 2 was in the input
            cut.Find("h3").MarkupMatches("<h3>2</h3>");
        }

        [Fact]
        public void ClickingTwoButtonAddsTwoDigit()
        {
            // Arrange
            var cut = RenderComponent<CalculatorPage>();

            // Act - click button 2 and 3 to add digits
            cut.Find("button[id=2]").Click();
            cut.Find("button[id=3]").Click();

            // Assert that the numbers 2 and 3 were in the input
            cut.Find("h3").MarkupMatches("<h3>23</h3>");
        }
    }
}