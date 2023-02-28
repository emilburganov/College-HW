using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice__17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПЕРВОЕ ЗАДАНИЕ:");
            first();
            Console.WriteLine();
            Console.WriteLine("ВТОРОЕ ЗАДАНИЕ:");
            second();
            Console.WriteLine();
            Console.WriteLine("ТРЕТЬЕ ЗАДАНИЕ:");
            third();
            Console.WriteLine();
            Console.WriteLine("ЧЕТВЕРТОЕ ЗАДАНИЕ:");
            fourth();
            Console.WriteLine();
            Console.WriteLine("ПЯТОЕ ЗАДАНИЕ:");
            fifth();
            Console.ReadLine();
        }
        static void PrintNumbersIncrease(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b) PrintNumbersIncrease(++a, b);

        }
        static void PrintNumbersDecrease(int a, int b)
        {
            Console.WriteLine(a);
            if (b < a) PrintNumbersDecrease(--a, b);

        }
        static void first()
        {
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b) PrintNumbersIncrease(a, b);
            else PrintNumbersDecrease(a, b);
        }
        static void second()
        {
            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Ackerman(m, n));
        }

        static int Ackerman(int m, int n) {
            if (m == 0) return (n + 1);
            else if (n == 0) return Ackerman(m - 1, 1);
            else return Ackerman(m - 1, Ackerman(m, n - 1));
        }

        static int Sum(int n, int sum = 0)
        {
            return n < 10 ? n : ((n % 10) + Sum(n / 10));
        }
        static void third()
        {
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма цифр числа {n} равна {Sum(n)}");
        }
        static int ReverseNumber(int n)
        {
            Console.Write(n % 10);
            return n < 10 ? n : ReverseNumber(n / 10);
        }
        static void fourth()
        {
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число N в обратном порядке: ");
            ReverseNumber(n);
        }
        static bool palindrome(string word)
        {
            if (word.Length <= 1) return true;
            else return word[0] == word[word.Length - 1] && palindrome(word.Substring(1, (word.Length - 2)));
        }
        static void fifth()
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();

            Console.WriteLine(palindrome(word) ? "YES" : "NO");
        }
    }
}
