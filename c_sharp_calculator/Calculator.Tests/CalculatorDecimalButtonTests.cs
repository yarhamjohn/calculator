using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class DecimalButtonClickTests : TestContext
    {
        [Theory]
        [InlineData(new[] { "." }, "0.", "")]
        [InlineData(new[] { "1", "." }, "1.", "")]
        [InlineData(new[] { "1", "+/-", "." }, "-1.", "")]
        [InlineData(new[] { "0", ".", "." }, "0.", "")]
        [InlineData(new[] { "0", ".", "1", "." }, "0.1", "")]
        [InlineData(new[] { "1", "=", "." }, "0.", "1 =")]
        public void ClickingDecimalButton_CorrectlySetsCalculationAndResult(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }
    }
}