using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class SignButtonClickTests : TestContext
    {
        [Fact]
        public void ClickingSignButton_DoesNotChangeResult_IfResultIsZero()
        {
            var cut = RenderComponent<CalculatorPage>();

            cut.Find($"button[id='+/-']").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal("0", Utils.GetResult(cut));
        }

        [Theory]
        [InlineData(new[] { "1" }, "-1")]
        [InlineData(new[] { "1", "." }, "-1.")]
        [InlineData(new[] { "1", ".", "2" }, "-1.2")]
        public void ClickingSignButton_ConvertsPositiveResultToNegative(string[] setupButtons, string expected)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            cut.Find($"button[id='+/-']").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal(expected, Utils.GetResult(cut));
        }

        [Theory]
        [InlineData(new[] { "1", "+/-" }, "1")]
        [InlineData(new[] { "1", "+/-", "." }, "1.")]
        [InlineData(new[] { "1", "+/-", ".", "2" }, "1.2")]
        public void ClickingSignButton_ConvertsNegativeResultToPositive(string[] setupButtons, string expected)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            cut.Find($"button[id='+/-']").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal(expected, Utils.GetResult(cut));
        }
    }
}