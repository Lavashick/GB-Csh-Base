using System;

namespace Task3
{

    class Fraction
    {
        int first;
        int second;

        // Проверяем, ясляется ли число целым
        public bool isInt(double value)
        {
            if (value % 1 == 0)
                return true;
            else
                return false;
        }

        // Функция проверяет, можно ли сократить дробь, и, если да, то выводит ее сокращенный вид
        public void Shortening(Fraction a)
        {
            Convert.ToDouble(a.first);
            Convert.ToDouble(a.second);
            double shortValue = a.first / a.second + a.first % a.second;
            Console.WriteLine("ПОЧЕМУ СУКА ТУТ БЛЯТЬ ЦЕЛОЕ НАХУЙ ЧИСЛО    " + shortValue);
            if (isInt(shortValue))
            {
                Convert.ToInt32(shortValue);
                Console.WriteLine("Сокращенная дробь: " + shortValue);
            }
            else
                return;
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
            Shortening(result);
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
            Shortening(result);
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
            Shortening(result);
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
            Shortening(result);
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


            Console.WriteLine("Сумма дробей a и b = {0}", a.Sum(b).ToString());
            Console.WriteLine();
            Console.WriteLine("Разность дробей a и b = {0}", a.Minus(b).ToString());
            Console.WriteLine();
            Console.WriteLine("Произведение a и b = {0}", a.Multiply(b).ToString());
            Console.WriteLine();
            Console.WriteLine("Частное дробей a и b = {0}", a.Division(b).ToString());
            Console.WriteLine();

        }
    }
}
