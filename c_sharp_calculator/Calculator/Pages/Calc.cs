using System;

public static class Calc
{
    public static decimal Calculate(Calculation calculation)
    {
        var calc = calculation.GetCalculation();
        if (calc == "")
        {
            return 0;
        }

        return Convert.ToDecimal(calc);
    }
}