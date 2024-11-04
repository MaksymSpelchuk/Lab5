using System;


class Program
{
    
        static void Main()
        {
            string input = "орщшкфоваиОЛОВчифлоаадащздіГУЩ";
            var result = count(input);
            Console.WriteLine($"Кількість голосних: {result.vowels}");
            Console.WriteLine($"Кількість приголосних: {result.consonats}");
        }

        static (int vowels, int consonats) count(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Рядок не може бути порожнім");
            }

            string vowelsList = "аоуеиіАОУЕИІ";
            int vowelsCount = 0;
            int consonatsCount = 0;

            foreach (char letter in input)
            {
                if (char.IsLetter(letter))
                {
                    if (vowelsList.Contains(letter))
                    {
                        vowelsCount++;
                    }
                    else
                    {
                        consonatsCount++;
                    }
                }
            }
            return (vowelsCount, consonatsCount);
        }
    }

