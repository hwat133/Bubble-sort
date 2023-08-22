using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько чисел вы хотите ввести?");
            var DataFromConsoleStr = Console.ReadLine();
            int.TryParse(DataFromConsoleStr, out var DataFromConsole);

            string ConsoleNumbers = Console.ReadLine();
            List<string> NumbersStr = ConsoleNumbers.Split(' ').ToList();
            List<int> numbers = new List<int>();


            for (int i = 0; i < DataFromConsole; i++)
            {
                int.TryParse(NumbersStr[i], out var number);
                numbers.Add(number);
            }

            for (int i = 0; i < DataFromConsole - 1; i++)
            {
                for (int j = 0; j < DataFromConsole - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int X = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = X;
                    }
                }
            }


            for (int i = 0; i < DataFromConsole; i++)
            {
                Console.Write(numbers[i]);
                Console.Write(' ');
            }

            Console.ReadKey();
        }

    }
}


