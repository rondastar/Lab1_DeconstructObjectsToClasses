using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_DeconstructObjectsToClasses
{
    internal class Dumbbells
    {
        int _quantity;
        float _weightEach;
        string _material;
        string _color;
        string _brand;
        decimal _price;

        public Dumbbells(int quantity, float weightEach, string material, string color, string brand, decimal price)
        {
            _quantity = quantity;
            _weightEach = weightEach;
            _material = material;
            _color = color;
            _brand = brand;
            _price = price;
        }

        public int Quantity { get => _quantity; set => _quantity = value; }
        public float WeightEach { get => _weightEach; set => _weightEach = value; }
        public string Material { get => _material; set => _material = value; }
        public string Color { get => _color; set => _color = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public decimal Price { get => _price; set => _price = value; }
    }
}
