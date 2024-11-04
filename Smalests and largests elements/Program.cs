using System;
using System.Threading.Channels;


class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var result = findMinMax(array);
        Console.WriteLine($"Найменший елемент масиву: {result.min}" );
        Console.WriteLine($"Найбільший елемент масиву: {result.max}"  );
    }

    static (int min, int max) findMinMax(int[] array)
    {
        if ( array == null )
        {
            Console.WriteLine("Масив не може бути порожнім");
        }

        int min = array[0];
        int max = array[0];

        foreach(var num in array)
        {
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }
        return (min, max);
    }


}