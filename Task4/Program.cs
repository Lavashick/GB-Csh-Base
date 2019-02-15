using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        // 4
        // Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе
        // истина, если прошел авторизацию, и ложь, если не прошел. Используя метод проверки логина и
        // пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его
        // дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками

        static bool isLogPas(string log)
        {
            string login = "login";
            if (!(log == login))
            {
                Console.WriteLine("Логин неверен");
                return false;
            }

            string password = "password";
            int k = 0;
            do
            {
                string pas;
                if (k != 0)
                    Console.Write("Введите пароль еще раз: ");
                else
                    Console.Write("Введите пароль: ");
                pas = Console.ReadLine();
                k++;
                if (pas == password)
                {
                    Console.Write("Доступ открыт!");
                    return true;
                } 
            }
            while (k != 3);
            Console.Write("Количество попыток кончилось, доступа нет!");
            return false;
        }


        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string log = Console.ReadLine();
            bool check;
            check = isLogPas(log);
            Console.ReadKey();
        }
    }
}
