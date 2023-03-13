using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* FIRST TASK */
            Flat flat = new Flat(100, 10, 500, 3);

            Console.WriteLine(flat.FullInfo());

            Console.WriteLine($"Высота этажа равна {flat.FloorHeight()}");
            Console.WriteLine($"Количество квартир в подъезде равно {flat.NumberOfApartmentsInEntrance()}");
            Console.WriteLine($"Количество квартир на этаже равно {flat.NumberOfApartmentsInFloor()}");

            /* SECOND TASK */
            Console.WriteLine(Math.Plus(9, 9));
            Console.WriteLine(Math.Minus(9, 9));
            Console.WriteLine(Math.Division(9, 9));
            Console.WriteLine(Math.Multiplication(9, 9));
            Console.WriteLine(Math.Pow(9, 9));
            Console.WriteLine(Math.Remainder(9, 9));
            Console.ReadKey();
        }
    }
}
