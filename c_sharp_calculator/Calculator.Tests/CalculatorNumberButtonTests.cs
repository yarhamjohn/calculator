using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class CalculatorNumberButtonClickTests : TestContext
    {
        [Fact]
        public void ClickingNumberButton_ReplacesResult_IfResultIsZero()
        {
            var cut = RenderComponent<CalculatorPage>();

            cut.Find($"button[id=1]").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal("1", Utils.GetResult(cut));
        }

        [Fact]
        public void ClickingNumberButton_AppendsToResult_IfResultIsAPositiveNumber()
        {
            var cut = RenderComponent<CalculatorPage>();
            cut.Find("button[id=1]").Click();

            cut.Find($"button[id=2]").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal("12", Utils.GetResult(cut));
        }

        [Fact]
        public void ClickingNumberButton_AppendsToResult_IfResultIsANegativeNumber()
        {
            var cut = RenderComponent<CalculatorPage>();
            cut.Find("button[id=1]").Click();
            cut.Find("button[id='+/-']").Click();

            cut.Find($"button[id=0]").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal("-10", Utils.GetResult(cut));
        }

        [Fact]
        public void ClickingNumberButton_AppendsResult_IfResultEndsWithDecimal()
        {
            var cut = RenderComponent<CalculatorPage>();
            cut.Find($"button[id=1]").Click();
            cut.Find($"button[id='.']").Click();

            cut.Find($"button[id=2]").Click();

            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal("1.2", Utils.GetResult(cut));
        }
    }
}