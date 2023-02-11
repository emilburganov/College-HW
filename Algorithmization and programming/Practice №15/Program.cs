using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practice__15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПЕРВОЕ ЗАДАНИЕ");
            Console.WriteLine();
            first();
            Console.WriteLine();
            Console.WriteLine("ВТОРОЕ ЗАДАНИЕ");
            Console.WriteLine();
            second();
            Console.WriteLine();
            Console.WriteLine("ТРЕТЬЕ ЗАДАНИЕ");
            Console.WriteLine();
            third();
            Console.WriteLine();
            Console.WriteLine("ЧЕТВЕРТОЕ ЗАДАНИЕ");
            Console.WriteLine();
            fourth();
            Console.WriteLine();
            Console.WriteLine("ПЯТОЕ ЗАДАНИЕ");
            Console.WriteLine();
            fifth();
            Console.ReadLine();
        }

        static void first()
        {
            Random rand = new Random();

            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                randomNumbers.Add(rand.Next(-10, 10));
            }

            if (randomNumbers.Contains(5)) Console.WriteLine($"Число 5 на позиции {randomNumbers.IndexOf(5)}");
            else Console.WriteLine("Числа 5 нет в списке!");

            Console.WriteLine();
            Console.WriteLine("Cписок:");
            Console.WriteLine(String.Join(" ", randomNumbers));

            randomNumbers.Sort();
            Console.WriteLine("Отсортированный список:");
            Console.WriteLine(String.Join(" ", randomNumbers));
        }

        static void second()
        {
            List<string> students = new List<string>() { "Вадим", "Ильмир", "Карим", "Дима", "Семен", "Никита", "Леонид", "Егор" };

            Console.WriteLine(string.Join(" ", students));

            students.RemoveAt(1);

            Console.WriteLine(string.Join(" ", students));

            students.Remove("Никита");

            Console.WriteLine(string.Join(" ", students));

            students.RemoveAll(student => student.Length > 4);

            Console.WriteLine(string.Join(" ", students));

            students.Add("Николай");
            students.Add("Александр");

            Console.WriteLine(string.Join(" ", students));

            students.RemoveRange(1, 2);

            Console.WriteLine(string.Join(" ", students));
        }

        static void third()
        {
            List<string> workers = new List<string>() { "Барано", "fdwef", "Симонов", "Аркадьева", "Маланина", "Беляев", "Петровский", "Михеева" };

            bool contains = Convert.ToBoolean(workers.Where(worker => worker.Length == 5).Count());

            if (contains) Console.WriteLine("Есть работник с фамилией длиной 5 символов");
            else Console.WriteLine("Нет работника с фамилией длиной 5 символов");

            string last = workers.Where(worker => worker.Length == 6).Last();

            Console.WriteLine($"Последняя фамилия состоящая из 6 символов - {last}");
        }

        static void fourth()
        {
            Random rand = new Random();

            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                randomNumbers.Add(rand.Next(-10, 10));
            }
            Console.WriteLine("Исходный список: " + String.Join(" ", randomNumbers));
            Console.WriteLine("Элементы с 1 по 3: " + String.Join(" ", randomNumbers.GetRange(1, 3)));
        }

        static void fifth()
        {
            Random rand = new Random();

            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                randomNumbers.Add(rand.Next(-10, 10));
            }

            Console.WriteLine("Исходный список: " + String.Join(" ", randomNumbers));
            randomNumbers.Reverse();
            Console.WriteLine("Cписок в обратном порядке: " + String.Join(" ", randomNumbers));
            randomNumbers.Reverse(2, 5);
            Console.WriteLine("Список с перевернутыми пятью элементами начиная с индекса 2: " + String.Join(" ", randomNumbers));
        }
    } 
}
