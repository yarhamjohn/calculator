using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Calculator.Pages
{
    public interface IButton
    {
        string getDisplayText();
        RenderFragment getButton(Action updateCalculation);
    }

    public class NumberButton : IButton
    {
        private readonly int number;
        private RenderFragment result;

        public NumberButton(int number)
        {
            this.number = number;
        }

        public string getDisplayText()
        {
            return number.ToString();
        }

        private string test() { Console.WriteLine("test click"); return ""; }

        public RenderFragment getButton(Action updateCalculation)
        {
            result = b =>
            {
                b.OpenElement(1, "button");

                b.AddAttribute(1, "id", getDisplayText());
                b.AddAttribute(1, "class", "digit-button");
                b.AddAttribute(1, "onClick", EventCallback.Factory.Create<MouseEventArgs>(this, s => { System.Console.WriteLine(s.ToString()); }));

                b.AddContent(1, getDisplayText());

                b.CloseElement();
            };
            return result;
        }
    }

    public class CharacterButton : IButton
    {
        private readonly string character;
        private RenderFragment result;

        public CharacterButton(string character)
        {
            this.character = character;
        }
        public RenderFragment getButton(Action updateCalculation)
        {
            result = b =>
            {
                b.OpenElement(1, "button");

                b.AddAttribute(1, "id", getDisplayText());
                b.AddAttribute(1, "class", "digit-button");
                b.AddAttribute(1, "onClick", updateCalculation);

                b.AddContent(1, getDisplayText());

                b.CloseElement();
            };
            return result;
        }

        public string getDisplayText()
        {
            return character;
        }
    }

    public class ActionButton : IButton
    {
        private readonly CalculatorAction action;
        private RenderFragment result;

        public ActionButton(CalculatorAction action)
        {
            this.action = action;
        }

        public RenderFragment getButton(Action updateCalculation)
        {
            result = b =>
            {
                b.OpenElement(1, "button");

                b.AddAttribute(1, "id", getDisplayText());
                b.AddAttribute(1, "class", "digit-button");
                b.AddAttribute(1, "onClick", updateCalculation);

                b.AddContent(1, getDisplayText());

                b.CloseElement();
            };
            return result;
        }
        public string getDisplayText()
        {
            switch (action)
            {
                case CalculatorAction.Equals:
                    return "=";
                case CalculatorAction.Add:
                    return "+";
                case CalculatorAction.Subtract:
                    return "-";
                case CalculatorAction.Multiply:
                    return "x";
                case CalculatorAction.Divide:
                    return "÷";
                default:
                    throw new ArgumentException($"Not a valid calculator action: {action.ToString()}");
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