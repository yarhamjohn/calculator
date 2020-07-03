using Xunit;
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public class ClearButtonClickTests : TestContext
    {
        [Theory]
        [InlineData(new[] { "C" }, "0", "")]
        [InlineData(new[] { "1", "C" }, "0", "")]
        [InlineData(new[] { ".", "C" }, "0", "")]
        [InlineData(new[] { "=", "C" }, "0", "")]
        [InlineData(new[] { "+/-", "C" }, "0", "")]
        [InlineData(new[] { "1", "2", "C" }, "0", "")]
        [InlineData(new[] { "1", "+/-", "C" }, "0", "")]
        [InlineData(new[] { "1", ".", "C" }, "0", "")]
        [InlineData(new[] { "1", ".", "2", "C" }, "0", "")]
        [InlineData(new[] { "1", ".", "2", "+/-", "C" }, "0", "")]
        [InlineData(new[] { "1", "=", "C" }, "0", "")]
        [InlineData(new[] { "1", "=", "2", "C" }, "0", "")]
        [InlineData(new[] { "1", "=", "2", "=", "C" }, "0", "")]
        public void ClickingClearButton_CorrectlySetsCalculationAndResult(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }

        [Theory]
        [InlineData(new[] { "CE" }, "0", "")]
        [InlineData(new[] { "1", "CE" }, "0", "")]
        [InlineData(new[] { ".", "CE" }, "0", "")]
        [InlineData(new[] { "=", "CE" }, "0", "0 =")]
        [InlineData(new[] { "+/-", "CE" }, "0", "")]
        [InlineData(new[] { "1", "2", "CE" }, "0", "")]
        [InlineData(new[] { "1", "+/-", "CE" }, "0", "")]
        [InlineData(new[] { "1", ".", "CE" }, "0", "")]
        [InlineData(new[] { "1", ".", "2", "CE" }, "0", "")]
        [InlineData(new[] { "1", ".", "2", "+/-", "CE" }, "0", "")]
        [InlineData(new[] { "1", "=", "CE" }, "0", "1 =")]
        [InlineData(new[] { "1", "=", "2", "CE" }, "0", "1 =")]
        [InlineData(new[] { "1", "=", "2", "=", "CE" }, "0", "2 =")]
        [InlineData(new[] { "1", "+", "CE" }, "0", "1 +")]
        public void ClickingClearEntryButton_CorrectlySetsCalculationAndResult(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }

        [Theory]
        [InlineData(new[] { "<-" }, "0", "")]
        [InlineData(new[] { "1", "<-" }, "0", "")]
        [InlineData(new[] { ".", "<-" }, "0", "")]
        [InlineData(new[] { "=", "<-" }, "0", "0 =")]
        [InlineData(new[] { "+/-", "<-" }, "0", "")]
        [InlineData(new[] { "1", "2", "<-" }, "1", "")]
        [InlineData(new[] { "1", "+/-", "<-" }, "0", "")]
        [InlineData(new[] { "1", ".", "<-" }, "1", "")]
        [InlineData(new[] { "1", ".", "2", "<-" }, "1.", "")]
        [InlineData(new[] { "1", ".", "2", "+/-", "<-" }, "-1.", "")]
        [InlineData(new[] { "1", "=", "<-" }, "1", "1 =")]
        [InlineData(new[] { "1", "=", "2", "<-" }, "0", "1 =")]
        [InlineData(new[] { "1", "=", "2", "=", "<-" }, "2", "2 =")]
        [InlineData(new[] { "1", "+", "<-" }, "1", "1 +")]
        public void ClickingDeleteButton_CorrectlySetsCalculationAndResult(string[] setupButtons, string expectedResult, string expectedCalculation)
        {
            var cut = RenderComponent<CalculatorPage>();
            foreach (var button in setupButtons) { cut.Find($"button[id='{button}']").Click(); }

            Assert.Equal(expectedCalculation, Utils.GetCalculation(cut));
            Assert.Equal(expectedResult, Utils.GetResult(cut));
        }
    }
}