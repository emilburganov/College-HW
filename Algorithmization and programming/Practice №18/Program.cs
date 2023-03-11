using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__18
{
    internal class Program
    {
        static void Main()
        {
            Cone cone = new Cone(10, 10);
            Console.WriteLine(cone.CobeBase());
            Console.WriteLine(cone.LateralSurfaceArea());
            Console.WriteLine(cone.TotalSurfaceArea());

            Console.WriteLine();

            Car car = new Car("Москвич", "Красный", 2000000);
            Console.WriteLine(car.Price());
            Console.WriteLine(car.Color());
            Console.WriteLine(car.Brand());


            Car car2 = new Car("Москвич", "Красный", 1000000);
            Console.WriteLine(car2.Price());
            Console.WriteLine(car2.Color());
            Console.WriteLine(car2.Brand());

            Console.ReadKey();
        }
    }
}
