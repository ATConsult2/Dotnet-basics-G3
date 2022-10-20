using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;


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

        static void Print(IEnumerable coll)
        {
            Write("{");
            foreach (var a in coll) Write(a + ", ");
            Write("\b\b}\n");
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");    
            #region  Test Box & Generics

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
           // WriteLine(Sum("A","B")); Type mismatch!!
            // Basket --> BasketG<T>  !!
            BasketG<Box> basket2 = new BasketG<Box>(
                new Box[] { b1, b2, b3 }
                );
            BasketG<string> basket3 = new BasketG<string>(
                new string[] { "AA","BB" }
                );

            #endregion

            #region Test Collections
            WriteLine("-------------- Test Collections ----------");
            ArrayList alist = new ArrayList(4)
            {
            1,2-20,44,440,3,"RRR", b2
            };
           // Print(alist);
            ArrayList alist2 = new ArrayList(4)
            {1,2,-20,44,440,3 };
            Print(alist2);
            alist2.Add(7);
            alist2.Insert(2, 2001);
            Print(alist2);
            WriteLine(alist2.Capacity + " ---- " + alist2.Count);
            alist2.Add(-33);
            alist2[0] = -1;
            Print(alist2);
            WriteLine(alist2.Capacity + " ---- " + alist2.Count);
            alist2.InsertRange(5, new ArrayList()
            {
              41,42,43,44,45,46,47,48
            });
            Print(alist2);
            WriteLine(alist2.Capacity + " ---- " + alist2.Count);
            // sorting ---------
            alist2.Sort(new MySort());
            Print(alist2);
            // -------- LINQ --------------
            var result =
                (from int d in alist2
               // where d >0
                orderby d descending
                select d).ToList();

            result.Sort((x, y) => x - y);
            Print(result);

            List<Box> boxes = new List<Box>() {
            new Box(10),
             new Box(1),
              new Box(100),
               new Box(7),
            };
            WriteLine("----------- LIST test ----------------");
            Print(boxes);
            boxes.Sort();
            var boxes2 =  boxes.Where(a => a.Capacity < 100).ToList();
            //boxes.Sort((a,b) => (int)(a.Capacity - b.Capacity));
            Print(boxes);
            Print(boxes2);
            Print(new TestEnumerator());
            foreach (double a in new TestEnumerator()) Write(a + ", ");
            #endregion

            WriteLine("\n----------- STACK & QUEUE test ----------------");

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Print(stack);
            var a2 = stack.Pop();
            Print(stack);
            WriteLine("-------------------------");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            
            Print(queue);
            a2 = queue.Dequeue();
            Print(queue);
            //---------------------------------------
            WriteLine("\n----------- Dictionary test ----------------");
            Dictionary<string, Box> dict =
                new Dictionary<string, Box>()
                {
                    { "one", new Box(1)},
                    { "hundred", new Box(100)},
                    { "five", new Box(5)},
                    { "seven", new Box(7)},
                };
            foreach (string key in dict.Keys) Write($"{key} --> {dict[key]}, ");
            WriteLine();
            dict.Add("ones", new Box(11));
            foreach (string key in dict.Keys) Write($"{key} --> {dict[key]}, ");
            WriteLine();
            var dict2 = dict.OrderBy(p => p.Key).ToDictionary(p => p.Key);
            foreach (string key in dict2.Keys) Write($"{key} --> {dict2[key]}, ");
            WriteLine();
        }

    }

    public class TestEnumerator : IEnumerable<double>
    {
        public IEnumerator<double> GetEnumerator()
        {
            yield return 1.222;
            yield return -1.2;
            yield return 66.222;
            yield return 55.2;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return 10.222;
            yield return -100.2;
            yield return 66.222;
            yield return 55.2;
        }
    }

    public class MySort : IComparer
    {
        public int Compare(object x, object y)
        {
            return Math.Abs((int)x) - Math.Abs((int)y);
        }
    }
}
