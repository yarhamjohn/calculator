using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class EqualsButtonClickTests : TestContext
    {
        [Theory]
        [InlineData(new[] { "=" }, "0", "0 =")]
        [InlineData(new[] { "1", "=" }, "1", "1 =")]
        [InlineData(new[] { "1", "+/-", "=" }, "-1", "-1 =")]
        [InlineData(new[] { ".", "=" }, "0", "0 =")]
        [InlineData(new[] { ".", "1", "=" }, "0.1", "0.1 =")]
        [InlineData(new[] { "1", ".", "=" }, "1", "1 =")]
        [InlineData(new[] { "1", ".", "2", "=" }, "1.2", "1.2 =")]
        [InlineData(new[] { "1", ".", "2", "+/-", "=" }, "-1.2", "-1.2 =")]
        [InlineData(new[] { "=", "=" }, "0", "0 =")]
        [InlineData(new[] { "1", "=", "=" }, "1", "1 =")]
        [InlineData(new[] { "1", "=", "2", "=" }, "2", "2 =")]
        [InlineData(new[] { "1", "+", "=" }, "2", "1 + 1 =")]
        public void ClickingEqualsButton_CorrectlySetsCalculationAndResult(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }

        //TODO: Test pressing equals after pressing equals when a sum is involved repeats the sum with the new result
    }
}