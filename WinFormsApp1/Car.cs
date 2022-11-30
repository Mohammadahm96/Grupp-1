using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal abstract class Car
    {
        public string Brand;
        public int Price;
        public string Model;

        public Car(string brand, int price, string model)
        {
            Brand = brand;
            Price = price;
            Model = model;
        }
    }
}
