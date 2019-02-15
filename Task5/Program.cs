using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static double NormWeight (double weight, double heigth, string sex)
        {
            double deltaWeight;
            if (sex == "М")
                deltaWeight = weight - ((heigth - 100) * 1.15);
            else
                deltaWeight = weight - ((heigth - 110) * 1.15);
            if (deltaWeight < 0)
            {
                deltaWeight *= -1;
                Console.Write("Вам стоит набрать");
            }
            else
                Console.Write("Вам стоит сбросить");
            return Math.Round(deltaWeight, 1);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ваш пол М или Ж?");
            string sex = Console.ReadLine();
            Console.WriteLine("Введите ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш рост: ");
            double heigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double i = weight / (heigth / 100 * heigth / 100);
            Console.WriteLine("Ваш ИМТ: ");
            Console.WriteLine(Math.Round(i, 4));
            Console.WriteLine();

            if (i < 18.5)
                Console.WriteLine("Вам надо набрать вес");
            if (i >= 18.5 && i < 25)
                Console.WriteLine("Ваш вес в норме");
            if (i >= 25 && i < 30)
                Console.WriteLine("Вам стоит похудеть");
            Console.WriteLine();
            Console.WriteLine(" " + NormWeight(weight, heigth, sex) + " кг");


            Console.ReadKey();
        }
    }
}
