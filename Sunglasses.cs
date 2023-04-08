using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_DeconstructObjectsToClasses
{
    internal class Sunglasses
    {
        public enum InterchangeableLenses { yes, no}
        public enum BestUse { fashion, athletic }

        int _numberOfLenses;
        int _UVProtection;
        string _brand;
        string _lensColor;
        string _frameColor;
        float _widthOfFramesInInches;
        InterchangeableLenses _interchangeableLenses;
        BestUse _bestUse;
        decimal _price;

        public int NumberOfLenses { get => _numberOfLenses; set => _numberOfLenses = value; }
        public int UVProtection { get => _UVProtection; set => _UVProtection = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public string LensColor { get => _lensColor; set => _lensColor = value; }
        public string FrameColor { get => _frameColor; set => _frameColor = value; }
        public float WidthOfFramesInInches { get => _widthOfFramesInInches; set => _widthOfFramesInInches = value; }
        internal InterchangeableLenses InterchangeableLenses1 { get => _interchangeableLenses; set => _interchangeableLenses = value; }
        internal BestUse BestUse1 { get => _bestUse; set => _bestUse = value; }
        public decimal Price { get => _price; }

        public Sunglasses(int numberOfLenses, int uVProtection, string brand, string lensColor, string frameColor, float widthOfFramesInInches, InterchangeableLenses interchangeableLenses, BestUse bestUse, decimal price)
        {
            _numberOfLenses = numberOfLenses;
            _UVProtection = uVProtection;
            _brand = brand;
            _lensColor = lensColor;
            _frameColor = frameColor;
            _widthOfFramesInInches = widthOfFramesInInches;
            _interchangeableLenses = interchangeableLenses;
            _bestUse = bestUse;
            _price = price;
        }

    }
}
