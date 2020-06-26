using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class DecimalButtonClickTests : TestContext
    {
        [Fact]
        public void ClickingDecimalButton_AppendsToResult_IfResultIsZero()
        {
            var cut = RenderComponent<CalculatorPage>();

            cut.Find($"button[id='.']").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal("0.", Utils.GetResult(cut));
        }

        [Fact]
        public void ClickingDecimalButton_AppendsToResult_IfResultIsAPositiveInteger()
        {
            var cut = RenderComponent<CalculatorPage>();
            cut.Find($"button[id=1]").Click();

            cut.Find($"button[id='.']").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal("1.", Utils.GetResult(cut));
        }

        [Fact]
        public void ClickingDecimalButton_AppendsToResult_IfResultIsANegativeInteger()
        {
            var cut = RenderComponent<CalculatorPage>();
            cut.Find($"button[id=1]").Click();
            cut.Find($"button[id='+/-']").Click();

            cut.Find($"button[id='.']").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal("-1.", Utils.GetResult(cut));
        }

        [Theory]
        [InlineData(new[] { "0", "." }, "0.")]
        [InlineData(new[] { "0", ".", "1" }, "0.1")]
        public void ClickingDecimalButton_DoesNotAppendToResult_IfResultContainsDecimal(string[] setupButtons, string expected)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            cut.Find($"button[id='.']").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal(expected, Utils.GetResult(cut));
        }
    }
}