using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class EqualsButtonClickTests : TestContext
    {
        [Theory]
        [InlineData(new string[0], "0", "0 =")]
        [InlineData(new[] { "1", "2", "3" }, "123", "123 =")]
        [InlineData(new[] { "1", "2", "3", "+/-" }, "-123", "-123 =")]
        public void ClickingEqualsButton_WhenResultIsAnInteger_CorrectlySetsCalculation(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            cut.Find($"button[id='=']").Click();

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }

        [Theory]
        [InlineData(new[] { ".", "1" }, "0.1", "0.1 =")]
        [InlineData(new[] { "1", ".", "2" }, "1.2", "1.2 =")]
        [InlineData(new[] { "1", ".", "2", "+/-" }, "-1.2", "-1.2 =")]
        public void ClickingEqualsButton_WhenResultIsACompletedDecimal_CorrectlySetsCalculation(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            cut.Find($"button[id='=']").Click();

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }

        [Theory]
        [InlineData(new[] { "." }, "0", "0 =")]
        [InlineData(new[] { "1", "." }, "1", "1 =")]
        public void ClickingEqualsButton_WhenResultHasATrailingDecimal_CorrectlySetsCalculation(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            cut.Find($"button[id='=']").Click();

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }
    }
}