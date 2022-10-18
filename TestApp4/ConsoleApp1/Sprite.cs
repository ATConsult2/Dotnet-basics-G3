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

    internal class Sprite
    {
      public Point2D Coordinate { get; private set; }
      public int Angle { get; private set; } 
      public Color Color { get; private set; }  

      //..... some props...
      //.....
      public Sprite()
      

    }
}
