using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    public enum Color
    { 
     Black=1,
     Red=2,
     Green=4,
     Blue=8
//......
    }

    internal abstract class Sprite : IGame
    {
      public Point2D Coordinates { get; private set; }
        /*public virtual void Render() {
              WriteLine("Rendre sprite " + GetHashCode());
          }*/

      public abstract void Render();
      public int Angle { get; private set; } 
      public Color Color { get; private set; }  

      //..... some props...
      //.....
      public Sprite(Point2D coords, int angle, Color color )
        {
            Color = color;
            Angle = angle;
            Coordinates = coords;
        }

        public virtual Sprite MoveX(int dx) { Coordinates.X += dx; return this; }
        public virtual Sprite MoveY(int dy) { Coordinates.Y += dy; return this; }
        public virtual Sprite Rotate(int da) { Angle += da; return this; }

        public override string ToString()
        {
            return $"Sprite: x={Coordinates.X}, y={Coordinates.Y}," +
                   $" alha={Angle}, color={Color}.";
        }


    }
}
