using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Calc
{
    public static decimal Calculate(Calculation calculation)
    {
        System.Console.WriteLine(string.Join("", calculation.Current));
        if (calculation.Current.Count == 0)
        {
            return 0;
        }

        if (IsADecimal(calculation.Current))
        {
            return Convert.ToDecimal(string.Join("", calculation.Current));
        }

        List<string> chunks = GetCalculationChunks(calculation);

        decimal runningTotal = 0;
        string activeOperator = null;
        for (int i = 0; i < chunks.Count; i++)
        {
            var isDecimal = Decimal.TryParse(chunks[i], out var chunk);

            if (isDecimal && activeOperator == null)
            {
                runningTotal = chunk;
            }
            else if (isDecimal && activeOperator != null)
            {
                switch (activeOperator)
                {
                    case "+":
                        runningTotal += chunk;
                        break;
                    case "-":
                        runningTotal -= chunk;
                        break;
                    case "x":
                        runningTotal *= chunk;
                        break;
                    case "÷":
                        runningTotal /= chunk;
                        break;
                }
            }
            else
            {
                activeOperator = chunks[i];
            }
        }

        return runningTotal;
    }

    private static List<string> GetCalculationChunks(Calculation calculation)
    {
        StringBuilder activeChunk = new StringBuilder();
        List<string> chunks = new List<string>();

        for (int i = 0; i < calculation.Current.Count; i++)
        {
            if (IsADecimal(new List<string> { calculation.Current[i] }))
            {
                activeChunk.Append(calculation.Current[i]);
            }
            else
            {
                chunks.Add(activeChunk.ToString());
                activeChunk.Clear();
                chunks.Add(calculation.Current[i]);
            }
        }

        return chunks;
    }

    private static bool IsADecimal(List<string> current)
    {
        System.Console.WriteLine(current);
        System.Console.WriteLine(string.Join("", current.Distinct()));
        System.Console.WriteLine(string.Join("", current.Distinct().Except(new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", "-" })));
        return current
        .Distinct()
        .Except(new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", "-" })
        .Count() == 0;
    }
}