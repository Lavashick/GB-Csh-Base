using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию: ");
            string sername = Console.ReadLine();
            Console.WriteLine("Ваша фамилия: " + sername);
            Console.WriteLine();

            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше имя: " + name);
            Console.WriteLine();

            Console.WriteLine("Введите отчество: ");
            string otch = Console.ReadLine();
            Console.WriteLine("Ваше отчество: " + otch);
            Console.WriteLine();

            Console.WriteLine("ФИО: " + sername + name + otch);

            Console.ReadKey();
        }
    }
}
