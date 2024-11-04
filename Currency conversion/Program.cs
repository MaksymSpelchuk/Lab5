using System;


class Program
{
    static public double CurrencyConversion(double count, double rateExchange)
    {
        return count * rateExchange;
    }


    static void Main()
    {
        Console.Write("Введіть суму: ");
        double count = Convert.ToDouble(Console.ReadLine());


        Console.Write("Введіть обміний курс: ");
        double rateExchange = Convert.ToDouble(Console.ReadLine());


        double convertedCount = CurrencyConversion(count, rateExchange);

        Console.Write("Конвертована сума: " + convertedCount);

    }
}
