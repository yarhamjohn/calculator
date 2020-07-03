using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class SignButtonClickTests : TestContext
    {
        [Theory]
        [InlineData(new[] { "+/-" }, "0", "")]
        [InlineData(new[] { "0", "+/-" }, "0", "")]
        [InlineData(new[] { "1", "+/-" }, "-1", "")]
        [InlineData(new[] { "1", ".", "+/-" }, "-1.", "")]
        [InlineData(new[] { "1", ".", "2", "+/-" }, "-1.2", "")]
        [InlineData(new[] { "1", "+/-", "+/-" }, "1", "")]
        [InlineData(new[] { "1", "+/-", ".", "+/-" }, "1.", "")]
        [InlineData(new[] { "1", "+/-", ".", "2", "+/-" }, "1.2", "")]
        [InlineData(new[] { "1", "-", "2", "=", "+/-" }, "1", "negate(-1)")]
        public void ClickingSignButton_CorrectlySetsCalculationAndResult(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }
    }
}