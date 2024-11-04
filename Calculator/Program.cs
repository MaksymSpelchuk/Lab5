using System;

class Program
{
    public static void Main()
    {
        double result = Calculator(2, 2, "+");
        Console.WriteLine(result);
    }

    public static double Calculator(double number1, double number2, string operation)
    {
        if (operation == "+")
        {
            return number1 + number2;
        }
        else if (operation == "-")
        {
            return number1 - number2;
        }
        else if (operation == "*")
        {
            return number1 * number2;
        }
        else if (operation == "/")
        {
            if (number2 == 0)
            {
                Console.WriteLine("Не можна ділити на нуль");
                return double.NaN;
            }
            else
            {
                return number1 / number2;
            }
        }
        Console.WriteLine("Неправильна операція");
        return double.NaN;

    }
}

