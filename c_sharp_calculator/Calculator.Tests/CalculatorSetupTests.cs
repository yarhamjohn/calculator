using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class CalculatorPageSetupTests : TestContext
    {
        [Fact]
        public void CalculatorIsInitialized_ToCorrectDefaults()
        {
            var cut = RenderComponent<CalculatorPage>();

            Assert.Equal("Calculator", cut.Find("h1").InnerHtml.Trim());
            Assert.Equal("", Utils.GetCalculation(cut));
            Assert.Equal("0", Utils.GetResult(cut));
        }
    }
}