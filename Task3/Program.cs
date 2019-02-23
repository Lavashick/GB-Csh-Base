using System;

namespace Task3
{

    class Fraction
    {
        int first;
        int second;

        // Проверяем, ясляется ли число целым
        bool isInt(double value)
        {
            return Convert.ToDouble(Convert.ToInt32(value)) == value;
        }

        // Функция проверяет, можно ли сократить дробь, и, если да, то выводит ее сокращенный вид
        public int Shortening()
        {
            double shortValue = Convert.ToDouble(first) / second;
            if (isInt(shortValue))
                return Convert.ToInt32(shortValue);
            else
                throw new Exception();
        }

        // Вывод дроби
        public override string ToString()
        {
            return this.first.ToString() + "/" + this.second.ToString();
        }

        // Конструктор
        public Fraction(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        public static Fraction Sum(Fraction a, Fraction b)
        {
            int firstNew;
            int secondNew;
            if (b.second != a.second) // Если числители дробей не равны, то:
            {
                secondNew = a.second * b.second;
                firstNew = a.first * b.second + b.first * a.second;
            }
            else
            {
                firstNew = a.first + b.first;
                secondNew = b.second;
            }
            Fraction result = new Fraction(firstNew, secondNew);
            return result;
        }


        // Сложение дробей
        public Fraction Sum(Fraction a)
        {
            int firstNew;
            int secondNew;
            if (this.second != a.second) // Если числители дробей не равны, то:
            {
                secondNew = a.second * this.second;
                firstNew = a.first * this.second + this.first * a.second;
            }
            else
            {
                firstNew = a.first + this.first;
                secondNew = this.second;
            }
            Fraction result = new Fraction(firstNew, secondNew);
            return result;
        }

        // Вычитание дробей
        public Fraction Minus(Fraction a)
        {
            int firstNew;
            int secondNew;
            if (this.second != a.second) // Если числители дробей не равны, то:
            {
                secondNew = a.second * this.second;
                firstNew = a.first * this.second - this.first * a.second;
            }
            else
            {
                firstNew = a.first - this.first;
                secondNew = this.second;
            }
            Fraction result = new Fraction(firstNew, secondNew);
            return result;
        }

        // Умножение дробей
        public Fraction Multiply(Fraction a)
        {
            int firstNew;
            int secondNew;
            firstNew = a.first * this.first;
            secondNew = a.second * this.second;
            Fraction result = new Fraction(firstNew, secondNew);
            return result;
        }

        // Деление дробей
        public Fraction Division(Fraction a)
        {
            int firstNew;
            int secondNew;
            secondNew = a.first * this.second;
            firstNew = a.second * this.first;
            Fraction result = new Fraction(firstNew, secondNew);
            return result;
        }


    }
    class MainClass
    {
        static bool isZero(int second)
        {
            if (second == 0)
            {
                Console.Write("Ошибка, знаменатель не может быть равен нулю!");
                return true;
            }
            else
                return false;
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите числитель дроби А: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель дроби А: ");
            int second = Convert.ToInt32(Console.ReadLine());
            if (isZero(second))
                return;
            Fraction a = new Fraction(first, second);
            Console.WriteLine("Дробь A: {0}", a.ToString());
            Console.WriteLine();

            Console.Write("Введите числитель дроби В: ");
            int first2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель дроби В: ");
            int second2 = Convert.ToInt32(Console.ReadLine());
            if (isZero(second2))
                return;
            Fraction b = new Fraction(first2, second2);
            Console.WriteLine("Дробь B: {0}", b.ToString());
            Console.WriteLine();

            Fraction sum = a.Sum(b);
            Fraction sSum = Fraction.Sum(a, b);
            Fraction minus = a.Minus(b);
            Fraction multiply = a.Multiply(b);
            Fraction division = a.Division(b);

            Console.WriteLine("Сумма дробей a и b = {0}", sum.ToString());
            try
            {
                Console.WriteLine("Целая часть дроби без остатка: {0}", sum.Shortening());
            }
            catch { }
            Console.WriteLine();

            Console.WriteLine("Разность дробей a и b = {0}", minus.ToString());
            try
            {
                Console.WriteLine("Целая часть дроби без остатка:: {0}", minus.Shortening());
            }
            catch { }
            Console.WriteLine();

            Console.WriteLine("Произведение a и b = {0}", multiply.ToString());
            try
            {
                Console.WriteLine("Целая часть дроби без остатка:: {0}", multiply.Shortening());
            }
            catch { }
            Console.WriteLine();

            Console.WriteLine("Частное дробей a и b = {0}", division.ToString());
            try
            {
                Console.WriteLine("Целая часть дроби без остатка: {0}", division.Shortening());
            }
            catch { }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
