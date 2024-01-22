using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access
{
    internal class Triangle : Polygon
    {
        // Existing constructor and properties

        public Triangle(string color, int numOfSides = 3) : base(color, numOfSides = 3)
        {
        }

        public override string ToString()
        {
            // Custom logic for ToString
            return base.ToString() + $" and a triangle with {NumOfSides} sides";
        }
    }
}
