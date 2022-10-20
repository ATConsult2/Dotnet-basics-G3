using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        { 
         // T temp = a; a = b; b = temp;
            (a, b) = (b, a);
        }

        static double Sum<T>(params T[] arr)
        { 
         double sum = 0;
         double[] darr = new double[arr.Length];
         Array.Copy(arr, darr, arr.Length);
         foreach (var a in darr) sum += a; 
         return sum;
        }

        static void Main(string[] args)
        {
            
            Box b1 = new Box(20);
            Box b2 = new Box(20);
            Box b3 = b1 + b2;
            WriteLine(b3);
            b3++; b3++;
            WriteLine(b3);
            WriteLine(b1 == b2);
            WriteLine(b1.Equals(b2));
            WriteLine(Object.ReferenceEquals(b1, b2));

            //-------------------------------------
            Basket basket = new Basket(
                new Box[] { b1, b2, b3 }
                );
            // Add, Remove, .... []
            WriteLine(basket[2]);
            WriteLine(basket["one"]);

            //--------------------------------------
            Container<string> datas =
                new Container<string> { Parcell = "www" };
            // --- swzp test
            WriteLine(b1 + " --- " + b3);
            Swap<Box>(ref b1, ref b3);
            WriteLine(b1 + " --- " + b3);
            WriteLine("--------------------------");
            WriteLine(Sum(1, 2, 3));
            WriteLine(Sum(new byte[] {1,2,3 }));
            WriteLine(Sum(new float[] { 1.2f, 2.3f, 3f }));
            WriteLine(Sum(new byte[] { }));
            WriteLine(Sum("A","B"));
        }
    }
}
