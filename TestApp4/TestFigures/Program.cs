using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace andestech.learning2022.krasn.figures
{
    internal abstract class Figure2D {
        public abstract double square();
        public abstract double perimeter();

        public override string ToString()
        {
            return $"S={square():#.###}, P={perimeter():#.###}.";
        }
    }

    internal class Circle : Figure2D { 
       public int R { get; set; }

        public override double perimeter()
        {
            return 2 * R * Math.PI;
        }

        public override double square()
        {
            return Math.PI * R * R;
        }

        public override string ToString()
        {
            return base.ToString().Insert(0,$"Circle R={R}, ") + ".";
        }
    }

  

    internal class Program
    {
        static void FigureTest(Figure2D figure)
        {            
            WriteLine(figure);
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");    
            FigureTest(new Circle { R = 10 });


        }
    }
}
