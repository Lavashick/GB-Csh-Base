using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите рост: ");
            double heigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double i = weight / (heigth / 100 * heigth / 100);
            Console.WriteLine("Ваш ИМТ: ");
            Console.WriteLine(Math.Round(i, 4));
            Console.WriteLine();
            Console.WriteLine();

            if (i < 18.5)
                Console.WriteLine("Данные введены неверно");
            if (i >= 18.5 && i < 25)
                Console.WriteLine("Нормальный вес");
            if (i >= 25 && i < 30)
                Console.WriteLine("Избыточный вес");
            if (i >= 30 && i < 35)
                Console.WriteLine("Ожирение 1 степени");
            if (i >= 35 && i < 40)
                Console.WriteLine("Ожирение 2 степени");
            if (i >= 40)
                Console.WriteLine("Ожирение 3 степени");

            Console.ReadKey();
        }
    }
}
