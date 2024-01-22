using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access
{
    internal class Shape
    {
        string _color;

        public Shape(string color)
        {
            _color = color;
        }

        public override string ToString()
        {
            return $"This is a basic {_color} Shape Object";
        }
    }
}
