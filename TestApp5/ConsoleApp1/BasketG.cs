using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace andestech.learning2022.krasn
{
    class Container<T> {
     public T Parcell { get; set; }
        public void f() {  }
    }

    internal class Basket
    {
        private Box[] Boxes { get; }

        public Basket(int size)
        { 
         Boxes = new Box[size]; 
        }

        public Box this[int i]
        {
            get { return Boxes[i]; }
            set { Boxes[i] = value; }
        }

        public Box this[string s]
        {
            get
            {
                switch (s.ToLower().Trim())
                {
                    case "one": return Boxes[0];
                    case "two": return Boxes[1];
                    case "three": return Boxes[2];
                    default: throw new ArgumentOutOfRangeException($"{s}");

                }
            }
           
        }

        public Basket(Box[] boxes)
        {
            Boxes = boxes;
        }   
    }
}
