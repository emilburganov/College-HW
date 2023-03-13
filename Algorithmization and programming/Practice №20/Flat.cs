using System;
using System.Collections.Generic;
using System.Linq ;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice__20
{
    internal class Flat
    {
        private static int HouseId { get; set; } 
        public double HouseHeight { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfApartments { get; set; }
        public int NumberOfEntrances { get; set; }

        public Flat(double houseHeight, int numberOfFloors, int numberOfApartments, int numberOfEntrances)
        {
            HouseHeight = houseHeight;
            NumberOfFloors = numberOfFloors;
            NumberOfApartments = numberOfApartments;
            NumberOfEntrances = numberOfEntrances;
        }

        public double FloorHeight()
        {
            return HouseHeight / NumberOfFloors;
        }

        public int NumberOfApartmentsInEntrance()
        {
            return NumberOfApartments / NumberOfEntrances;
        }

        public int NumberOfApartmentsInFloor()
        {
            return NumberOfApartmentsInEntrance() / NumberOfFloors;
        }
        public string FullInfo() 
        {
            return $"ID {++HouseId}\nHouseHeight {HouseHeight}\nNumberOfFloors {NumberOfFloors}\nNumberOfApartments {NumberOfApartments}\nNumberOfEntrances {NumberOfEntrances}\n";
        }
    }
}
