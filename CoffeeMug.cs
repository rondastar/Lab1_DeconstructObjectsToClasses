using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_DeconstructObjectsToClasses
{
    internal class CoffeeMug
    {
        // Fields
        string _handleType;
        string _color;
        int _sizeInOz;
        string _shape;
        string _material;
        decimal _price;

        public CoffeeMug(string handleType, string color, int sizeInOz, string shape, string material, decimal price)
        {
            _handleType = handleType;
            _color = color;
            _sizeInOz = sizeInOz;
            _shape = shape;
            _material = material;
            _price = price;
        }

        public string HandleType { get => _handleType; set => _handleType = value; }
        public string Color { get => _color; set => _color = value; }
        public int SizeInOz { get => _sizeInOz; set => _sizeInOz = value; }
        public string Shape { get => _shape; set => _shape = value; }
        public string Material { get => _material; set => _material = value; }
        public decimal Price { get => _price; } 
    }
}
