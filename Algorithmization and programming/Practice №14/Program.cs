/* If you need my solution, please change the code a little, otherwise the practices will no longer be posted.

Если потребуется мое решение, пожалуйста, поменяйте немного код, иначе практики больше не будут выкладываться */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__14__Collections_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание:");
            first();
            Console.WriteLine();
            Console.WriteLine("Второе задание:");
            second();
            Console.ReadLine();

        }

        static void first()
        {
            Queue<int> queue = new Queue<int>();

            int queueCount = 0;

            int[] numbers = { 1, 4, 3, 10, 24, 234, 2, 52 };

            foreach (int number in numbers)
            {
                queue.Enqueue(number);
                if (number < 10) queueCount++;
            }

            foreach (int number in queue) Console.WriteLine(number);
            Console.WriteLine($"Количество элементов очереди меньших 10 = {queueCount}");
        }

        static void second()
        {
            Queue<string> queue = new Queue<string>();

            string[] processors = {"AMD Athlon 64 X2, 2.7Ггц, 2 ядра"};
            foreach (string processor in processors) queue.Enqueue(processor);

            foreach (string item in queue)
            {
                string cores = item.Split(',')[2];
                Console.WriteLine(cores);
                Console.WriteLine(item);
            }
        }
    }
}
