using System;

class Program
{
    static double Forecast(double principal, double rate, int years)
    {
        if (years == 0)
        {
            return principal;
        }

        return Forecast(principal * (1 + rate), rate, years - 1);
    }

    static void Main()
    {
        double principal = 10000;
        double annualRate = 0.10;
        int years = 5;

        double futureValue = Forecast(principal, annualRate, years);

        Console.WriteLine($"Initial Amount : ₹{principal:F2}");
        Console.WriteLine($"Interest Rate  : {annualRate * 100}%");
        Console.WriteLine($"Years          : {years}");
        Console.WriteLine($"Future Value   : ₹{futureValue:F2}");
    }
}