using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Additional_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>() {
                "Бурганов Эмиль Эдуардович, 23.03.2005, 4.58",
                "Андриянов Егор Тимурович, 10.02.2006, 3.50",
                "Александров Александр Александрович, 21.05.2004, 4.68",
                "Петров Дмитрий Сергеевич, 02.01.2005, 4.57",
                "Иванов Кирилл Алексеевич, 30.08.2004, 4.95",
                "Кузнецов Олег Дмитриевич, 22.09.2006, 5.00",
                "Садыков Камиль Гаврилович, 03.03.2005, 4.80",
                "Мукачев Александр Евгеньевич, 14.04.2005, 3.56"
            };

            Console.WriteLine("Список студентов:");
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", students));

            students = students.OrderBy(student => student).ToList();

            Console.WriteLine();
            Console.WriteLine("Список студентов по алфавиту:");
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", students));

            students = students.OrderByDescending(student => student).ToList();

            Console.WriteLine();
            Console.WriteLine("Список студентов по алфавиту наоборот:");
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", students));

            students = students.OrderBy(student => student.Split(',')[2].Trim()).ToList();

            Console.WriteLine();
            Console.WriteLine("Список студентов по возрастанию среднего балла:");
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", students));

            Console.WriteLine();
            Console.Write("Введите фамилию студента -> ");
            string studentSurname = Console.ReadLine();

            List<string> studentsWithSurname = students.Where(student => student.Split(',')[0].Split(' ')[0].ToLower() == studentSurname.ToLower()).ToList();

            Console.WriteLine();
            Console.WriteLine($"Список студентов с фамилией {studentSurname}:");
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", studentsWithSurname));

            Console.WriteLine();
            Console.Write($"Самый взрослый студент -> ");

            int maxTimeStamp = 0;
            string olderStudent = "";
            Console.WriteLine("Birth " + String.Join(" ", students.Where(student => student.Split(',')[1].Trim().Split('.')[1] == DateTime.Now.Month.ToString())));

            foreach (string student in students)
            {
                List<string> date = new List<string>(student.Split(',')[1].Trim().Split('.').Reverse());
                int timestamp = (int)DateTime.UtcNow.Subtract(new DateTime(Convert.ToInt16(date[0]), Convert.ToInt16(date[1]), Convert.ToInt16(date[2]))).TotalSeconds;

                if (timestamp > maxTimeStamp)
                {
                    maxTimeStamp = timestamp;
                    olderStudent = student.Split(',')[0].Trim();
                }


            }

            Console.WriteLine(olderStudent);
            Console.WriteLine();
            Console.WriteLine("Студенты, родившиеся в этом месяце:");
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", students.Where(student => DateTime.Parse(student.Split(',')[1].Trim()).Month == DateTime.Now.Month)));


            Console.WriteLine();
            double sum = 0;
            Console.Write("Общий средний балл всех студентов = ");
            Console.WriteLine(students.Average(student => Convert.ToDouble(String.Join(" ", student.Split(',')[2]).Trim().Replace('.', ','))));
            Console.ReadLine();
        }
    }
}
