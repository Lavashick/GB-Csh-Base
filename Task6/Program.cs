using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static int SumOfNumber(int value)
        {
            int sum = 0;
            while (value != 0)
            {
                sum += value % 10;
                value /= 10;
            }
            return sum;
        }

        static bool IsNormalCount(int value)
        {
            if (value % SumOfNumber(value) == 0)
                return true;
            else
                return false;
        }

        static int CountOfNormalNumber()
        {
            int k = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (IsNormalCount(i) == true)
                    k += 1;
            }
            return k;
        }
        
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            
            Console.Write("Количество хороших чисел в диапазоне от 1 до 1000000: ");
            Console.WriteLine(CountOfNormalNumber());
            DateTime finishTime = DateTime.Now;
            TimeSpan deltaTime = finishTime - startTime;
            Console.Write("Время выполнения программы: " + deltaTime);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Введите любой символ, чтобы закрыть программу: ");
            Console.ReadKey();
        }
    }
}
