using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Circle : Sprite
    {
        public Circle(Point2D coords, int angle, Color color, int radius) : base(coords, angle, color)
        {
            R = radius;
        }

      public int R { get; private set; }

        // public new void Render()
        public override void Render()
        {
            WriteLine("Render Circle sprite " + GetHashCode());
        }

        public override string ToString()
        {
            return (base.ToString() + $"\b, radius={R}").
                Insert(0,"Circle ");
        }

    }
}
