using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_DeconstructObjectsToClasses
{
    internal class Notebook
    {
        public enum Style { collegeRuled, wideRuled, graph, dot, none }

        Style _style;
        int _numberOfSheets;
        float _widthInInches;
        float _heightInInches;
        string _coverMaterial;
        string _coverColor;
        int _percentRecycledMaterial;
        string _brand;
        decimal _price;

        internal Style Style1 { get => _style; set => _style = value; }
        public int NumberOfSheets { get => _numberOfSheets; set => _numberOfSheets = value; }
        public float WidthInInches { get => _widthInInches; set => _widthInInches = value; }
        public float HeightInInches { get => _heightInInches; set => _heightInInches = value; }
        public string CoverMaterial { get => _coverMaterial; set => _coverMaterial = value; }
        public string CoverColor { get => _coverColor; set => _coverColor = value; }
        public int PercentRecycledMaterial { get => _percentRecycledMaterial; set => _percentRecycledMaterial = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public decimal Price { get => _price; set => _price = value; }

        public Notebook(Style style, int numberOfSheets, float widthInInches, float heightInInches, string coverMaterial, string coverColor, int percentRecycledMaterial, string brand, decimal price)
        {
            _style = style;
            _numberOfSheets = numberOfSheets;
            _widthInInches = widthInInches;
            _heightInInches = heightInInches;
            _coverMaterial = coverMaterial;
            _coverColor = coverColor;
            _percentRecycledMaterial = percentRecycledMaterial;
            _brand = brand;
            _price = price;
        }
    }
}
