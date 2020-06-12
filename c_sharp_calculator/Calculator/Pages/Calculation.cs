using System.Collections.Generic;

public class Calculation
{
    public List<string> Current;
    private List<string> operators = new List<string> { "+", "-", "x", "÷" };

    public Calculation()
    {
        Current = new List<string>();
    }

    public void UpdateCalculation(Button button)
    {
        if (button.DisplayText == "." && Current.Contains("."))
        {
            return;
        }

        if (button.DisplayText == "+/-")
        {
            if (Current.Contains("-"))
            {
                Current.Remove("-");
            }
            else
            {
                Current.Insert(0, "-");
            }

            return;
        }

        if (operators.Contains(button.DisplayText))
        {
            if (Current.Count == 0)
            {
                Current.AddRange(new List<string> { "0", button.DisplayText });
            }
            else if (operators.Contains(Current[Current.Count - 1]))
            {
                ReplaceLastOperator(button);
            }
        }

        Current.Add(button.DisplayText);
    }

    private void ReplaceLastOperator(Button button)
    {
        Current.RemoveAt(Current.Count - 1);
        Current.Add(button.DisplayText);
    }

    public string GetCalculation() => string.Join("", Current).Trim();
}