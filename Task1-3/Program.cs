using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_3
{
    class Program
    {
        // 1
        // Минимальное з тех чисел
        static int Min(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
                min = a;
            if (b < a && b < c)
                min = b;
            else
                min = c;
            return min;
        }

        // 2
        // Метод подсчета количества цифр в числе 
        static int NumOfNumber(int value)
        {
            int k = 0;
            while (value % 10 != 0)
            {
                k++;
                value /= 10;
            }
            return k;
        }

        // 3
        // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
        static int Sum()
        {
            int a;
            int sum = 0;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 != 0 && a > 0)
                    sum += a;
            }
            while (a != 0);
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа: ");
            Console.WriteLine("Сумма нечетных положительных чисел: " + Sum());

            Console.WriteLine("Введите три числа: ");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минимальное число: ");
            Console.WriteLine(Min(first, second, third));
            Console.WriteLine();

            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество цифр в числе: ");
            Console.WriteLine(NumOfNumber(a));
            Console.ReadKey();
        }
    }
}
