
using Bunit;
using Calculator.Pages;

namespace Calculator.Tests
{
    public static class Utils
    {
        public static string GetResult(IRenderedComponent<CalculatorPage> cut)
        {
            return cut.Find("div[id=result]").InnerHtml.Trim();
        }

        public static string GetCalculation(IRenderedComponent<CalculatorPage> cut)
        {
            return cut.Find("div[id=calculation]").InnerHtml.Trim();
        }
    }
}