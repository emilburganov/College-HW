using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__18
{
    class Car
    {
        private string brand;
        private string color;
        private double price;

        public Car(string brand, string color, double price) 
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
        }
        public string Price()
        {
           
            return $"Cтоимость машины с учетом 5% скидки = {this.price * 0.95}";
        }

        public string Color()
        {
          
            return $"Цвет машины {this.color}";
        }

        public string Brand()
        {
          
            return $"Бренд машины {this.brand}";
        }
    }
}
