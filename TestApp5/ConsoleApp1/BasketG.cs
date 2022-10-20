using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace andestech.learning2022.krasn
{

    internal class BasketG<T> // Generic from Basket type
    {
        private T[] Boxes { get; }

        public BasketG(int size)
        { 
         Boxes = new T[size]; 
        }

        public T this[int i]
        {
            get { return Boxes[i]; }
            set { Boxes[i] = value; }
        }

        public T this[string s]
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

        public BasketG(T[] boxes)
        {
            Boxes = boxes;
        }   
    }
}
