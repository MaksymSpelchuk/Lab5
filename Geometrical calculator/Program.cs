using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Геометричний калькулятор");
        Console.WriteLine("Виберіть фігуру для обчислення:");
        Console.WriteLine("1. Коло (площа)");
        Console.WriteLine("2. Прямокутник (площа)");
        Console.WriteLine("3. Куб (площа та об'єм)");
        Console.Write("Введіть номер вашого вибору: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateCircleArea();
                break;
            case 2:
                CalculateRectangleArea();
                break;
            case 3:
                CalculateCubeAreaAndVolume();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }

    static void CalculateCircleArea()
    {
        Console.Write("Введіть радіус кола: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Площа кола: {area:F2}");
    }

    static void CalculateRectangleArea()
    {
        Console.Write("Введіть довжину прямокутника: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Введіть ширину прямокутника: ");
        double width = double.Parse(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"Площа прямокутника: {area:F2}");
    }

    static void CalculateCubeAreaAndVolume()
    {
        Console.Write("Введіть довжину ребра куба: ");
        double edge = double.Parse(Console.ReadLine());
        double surfaceArea = 6 * Math.Pow(edge, 2);
        double volume = Math.Pow(edge, 3);
        Console.WriteLine($"Площа поверхні куба: {surfaceArea:F2}");
        Console.WriteLine($"Об'єм куба: {volume:F2}");
    }
}    


