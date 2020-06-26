using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class CalculatorAdditionButtonClickTests : TestContext
    {
        [Theory]
        [InlineData(new[] { "+" }, "0", "0 +")]
        [InlineData(new[] { ".", "+" }, "0", "0 +")]
        [InlineData(new[] { "1", "+" }, "1", "1 +")]
        [InlineData(new[] { "1", "+/-", "+" }, "-1", "-1 +")]
        [InlineData(new[] { "1", "+", "+" }, "1", "1 +")]
        [InlineData(new[] { "1", "-", "+" }, "1", "1 +")]
        [InlineData(new[] { "1", "x", "+" }, "1", "1 +")]
        [InlineData(new[] { "1", "÷", "+" }, "1", "1 +")]
        [InlineData(new[] { "1", "=", "+" }, "1", "1 +")]
        [InlineData(new[] { "1", "+", "=", "+" }, "2", "2 +")]
        [InlineData(new[] { "1", "+", "2", "+" }, "3", "1 + 2 +")]
        public void ClickingAdditionButton_CorrectlySetsCalculationAndResult(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }
    }
}