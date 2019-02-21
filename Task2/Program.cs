using System;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            // Требуется подсчитать сумму всех нечётных положительных чисел. 
            // Сами числа и сумму вывести на экран, используя tryParse
            int sum = 0;
            do
            {
                string s = Console.ReadLine();
                int value;
                if (!Int32.TryParse(s, out value))
                {
                    Console.WriteLine("NaN. Вы ввели не число!");
                    continue;
                }

                if (value == 0)
                    break;
                if (value % 2 != 0 && value > 0)
                    sum += value;
            }
            while (true);

            Console.WriteLine(sum);
        }
    }
}
