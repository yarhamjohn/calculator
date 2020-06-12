using System.Collections.Generic;

public class Calculation
{
    public List<string> Current;
    public Calculation()
    {
        Current = new List<string>();
    }

    public void AddToCalculation(Button button)
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

        Current.Add(button.DisplayText);
    }

    public string GetCalculation() => string.Join("", Current).Trim();
}