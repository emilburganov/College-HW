using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПЕРВОЕ И ВТОРОЕ ЗАДАНИЕ:");
            FirstAndSecond(5, 7);
            Console.WriteLine();
            Console.WriteLine("ТРЕТЬЕ ЗАДАНИЕ:");
            Third("Hello World");
            Console.WriteLine();
            Console.WriteLine("ЧЕТВЕРТОЕ ЗАДАНИЕ:");
            Fourth(10);
            Console.WriteLine();
            Console.WriteLine("ПЯТОЕ ЗАДАНИЕ:");
            Fifth(5);
            Console.ReadKey();
        }
        static int Factorial(int number)
        {
            if (number > 1) number *= Factorial(--number);
            return number;
        }
        static void FirstAndSecond(int k, int n)
        {

            Console.Write($"Количество сочетаний из {n} объектов по {k} = ");
            Console.WriteLine(Factorial(n) / (Factorial(k) * Factorial(n - k)));
        }
        static void Third(string word)
        {
            string newWord = "";

            foreach (char c in word)
            {
                if (Char.IsLower(c))
                {
                    newWord += char.ToUpper(c);
                }
                else
                {
                    newWord += char.ToLower(c);
                }
            }

            Console.WriteLine(newWord);
        }

        static void Fourth(int lenght)
        {
            Random random = new Random();

            int[] numbers = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = random.Next(0, 100);
            }

            Console.WriteLine(String.Join(" ", numbers));
            AverageCount(numbers);

        }
        static void AverageCount(int[] numbers)
        {
            double average = numbers.Average();
            int count = 0;

            foreach (int number in numbers)
            {
                if (number > average) count++;
            }

            Console.WriteLine($"Среднее значение = {average}");
            Console.WriteLine($"Количество элементов массива, больших среднего значения = {count}");
        }
        static void Fifth(int size)
        {
            Random random = new Random();

            int[,] matrix= new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Преобразованная матрица:");

            matrix = TransformMatrix(matrix, size);


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] TransformMatrix(int[,] matrix, int size)
        {
            int temp;

            for (int col = 0; col < size; col++) 
            {
                if ((col + 1) % 2 != 0) {

                    for (int row = 0; row < size - 1; row++) 
                    {
                        for (int i = 0; i < size - row - 1; i++)
                        {
                            if (matrix[i + 1, col] < matrix[i, col])
                            {
                                temp = matrix[i, col];
                                matrix[i, col] = matrix[i + 1, col];
                                matrix[i + 1, col] = temp;
                            }
                        }
                    } 
                }
                else
                {
                    for (int row = 0; row < size - 1; row++) 
                    {
                        for (int i = 0; i < size - row - 1; i++)
                        {
                            if (matrix[i + 1, col] > matrix[i, col])
                            {
                                temp = matrix[i, col];
                                matrix[i, col] = matrix[i + 1, col];
                                matrix[i + 1, col] = temp;
                            }
                        }
                    }
                }
            }

            return matrix;
        }
    }
}
