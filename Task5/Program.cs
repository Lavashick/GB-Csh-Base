using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите ваш рост: ");
            double heigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double i = weight / (heigth / 100 * heigth / 100);
            Console.WriteLine("Ваш ИМТ: ");
            Console.WriteLine(Math.Round(i, 4));
            Console.WriteLine();
            Console.WriteLine();

            if (i < 18.5)
                Console.WriteLine("Вам надо набрать вес");
            if (i >= 18.5 && i < 25)
                Console.WriteLine("Ваш вес в норме");
            if (i >= 25 && i < 30)
                Console.WriteLine("Вам стоит похудеть");

            Console.ReadKey();
        }
    }
}
