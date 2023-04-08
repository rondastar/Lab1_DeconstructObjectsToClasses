using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_DeconstructObjectsToClasses
{
    internal class Umbrella
    {
        public enum WindResistant { yes, no}
        // Fields
        float _lengthOfExpandedHandleInInches;
        float _lengthOfClosedUmbrellaInInches;
        float _diameterOfOpenUmbrellaInInches;
        string _color;
        string _brand;
        decimal _price;
        WindResistant _windResistant;

        public float LengthOfExpandedHandleInInches { get => _lengthOfExpandedHandleInInches; set => _lengthOfExpandedHandleInInches = value; }
        public float LengthOfClosedUmbrellaInInches { get => _lengthOfClosedUmbrellaInInches; set => _lengthOfClosedUmbrellaInInches = value; }
        public float DiameterOfOpenUmbrellaInInches { get => _diameterOfOpenUmbrellaInInches; set => _diameterOfOpenUmbrellaInInches = value; }
        public string Color { get => _color; set => _color = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public decimal Price { get => _price; }
        private WindResistant WindResistant1 { get => _windResistant; set => _windResistant = value; }

        public Umbrella(float lengthOfExpandedHandleInInches, float lengthOfClosedUmbrellaInInches, float diameterOfOpenUmbrellaInInches, string color, string brand, decimal price, WindResistant windResistant)
        {
            _lengthOfExpandedHandleInInches = lengthOfExpandedHandleInInches;
            _lengthOfClosedUmbrellaInInches = lengthOfClosedUmbrellaInInches;
            _diameterOfOpenUmbrellaInInches = diameterOfOpenUmbrellaInInches;
            _color = color;
            _brand = brand;
            _price = price;
            _windResistant = windResistant;
        }
    }
}
