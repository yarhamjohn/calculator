using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    /// <summary>
    /// These tests are written entirely in C#.
    /// Learn more at https://bunit.egilhansen.com/docs/
    /// </summary>
    public class CalculatorPageSetupTests : TestContext
    {
        [Fact]
        public void CalculatorIsInitialized_ToCorrectDefaults()
        {
            var cut = RenderComponent<CalculatorPage>();

            cut.Find("h1").InnerHtml.Equals("Calculator");
            cut.Find("div[id=calculation]").InnerHtml.Equals("");
            cut.Find("div[id=result]").InnerHtml.Equals("0");
        }
    }

    public class CalculatorNumberButtonClickTests : TestContext
    {
        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("2", "2")]
        [InlineData("3", "3")]
        [InlineData("4", "4")]
        [InlineData("5", "5")]
        [InlineData("6", "6")]
        [InlineData("7", "7")]
        [InlineData("8", "8")]
        [InlineData("9", "9")]
        public void ClickingNumberButton_ReplacesResult_IfResultIsZero(string actual, string expected)
        {
            var cut = RenderComponent<CalculatorPage>();

            cut.Find($"button[id={actual}]").Click();

            cut.Find("div[id=result]").InnerHtml.Equals(expected);
            cut.Find("div[id=calculation]").InnerHtml.Equals("");
        }

        [Theory]
        [InlineData("0", "10")]
        [InlineData("1", "11")]
        [InlineData("2", "12")]
        [InlineData("3", "13")]
        [InlineData("4", "14")]
        [InlineData("5", "15")]
        [InlineData("6", "16")]
        [InlineData("7", "17")]
        [InlineData("8", "18")]
        [InlineData("9", "19")]
        public void ClickingNumberButton_AppendsToResult_IfResultIsAPositiveNumber(string actual, string expected)
        {
            var cut = RenderComponent<CalculatorPage>();

            cut.Find("button[id=1]").Click();
            cut.Find($"button[id={actual}]").Click();

            cut.Find("div[id=result]").InnerHtml.Equals(expected);
            cut.Find("div[id=calculation]").InnerHtml.Equals("");
        }

        [Theory]
        [InlineData("0", "-10")]
        [InlineData("1", "-11")]
        [InlineData("2", "-12")]
        [InlineData("3", "-13")]
        [InlineData("4", "-14")]
        [InlineData("5", "-15")]
        [InlineData("6", "-16")]
        [InlineData("7", "-17")]
        [InlineData("8", "-18")]
        [InlineData("9", "-19")]
        public void ClickingNumberButton_AppendsToResult_IfResultIsANegativeNumber(string actual, string expected)
        {
            var cut = RenderComponent<CalculatorPage>();

            cut.Find("button[id=1]").Click();
            cut.Find("button[id='+/-']").Click();
            cut.Find($"button[id={actual}]").Click();

            cut.Find("div[id=result]").InnerHtml.Equals(expected);
            cut.Find("div[id=calculation]").InnerHtml.Equals("");
        }
    }
}