using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class CalculatorNumberButtonClickTests : TestContext
    {
        [Theory]
        [InlineData(new[] { "1" }, "1", "")]
        [InlineData(new[] { "1", "2" }, "12", "")]
        [InlineData(new[] { "1", "+/-", "0" }, "-10", "")]
        [InlineData(new[] { "1", ".", "2" }, "1.2", "")]
        [InlineData(new[] { "1", "=", "2" }, "2", "1 =")]
        [InlineData(new[] { "1", "+", "2" }, "2", "1 +")]
        public void ClickingNumberButton_CorrectlySetsCalculationAndResult(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }
    }
}