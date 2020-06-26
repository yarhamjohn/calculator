using System;

namespace Calculator.Pages
{
    public class Button
    {
        public string DisplayText { get; set; }

        public Button(int digit)
        {
            DisplayText = digit.ToString();
        }

        public Button(string character)
        {
            DisplayText = character;
        }

        public Button(CalculatorAction calculatorAction)
        {
            switch (calculatorAction)
            {
                case CalculatorAction.Equals:
                    DisplayText = "=";
                    break;
                case CalculatorAction.Add:
                    DisplayText = "+";
                    break;
                case CalculatorAction.Subtract:
                    DisplayText = "-";
                    break;
                case CalculatorAction.Multiply:
                    DisplayText = "x";
                    break;
                case CalculatorAction.Divide:
                    DisplayText = "÷";
                    break;
                default:
                    throw new ArgumentException($"Not a valid CalculatorAction: {calculatorAction.ToString()}");
            }
        }
    }

    public enum CalculatorAction
    {
        Equals,
        Add,
        Subtract,
        Multiply,
        Divide
    }
}