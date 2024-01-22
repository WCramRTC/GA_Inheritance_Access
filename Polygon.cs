using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access
{
    internal class Polygon : Shape
    {
        private int _numOfSides;

        public Polygon(string color, int numOfSides) : base(color)
        {
            _numOfSides = numOfSides;
        }

        public int NumOfSides { get => _numOfSides; protected set => _numOfSides = value; }

        public override string ToString()
        {
            return base.ToString() + $" a polygon with {_numOfSides} sides";
        }
    }
}
