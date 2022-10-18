using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Rectangle : Sprite
    {
        public Rectangle(Point2D coords, int angle, Color color, int height, int width) : base(coords, angle, color)
        {
            Width = width;
            Height = height;
        }

      public int Height { get; private set; }
      public int Width { get; private set; }

        // public new void Render()
        public override void Render()
        {
            WriteLine("Render Rectangle sprite " + GetHashCode());
        }

        public override string ToString()
        {
            return (base.ToString() + $"\b, height={Height}, width={Width}").
                Insert(0,"Rectangle ");
        }

    }
}
