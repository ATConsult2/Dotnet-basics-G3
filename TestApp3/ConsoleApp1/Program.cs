using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    class Program
    {
        static void Add100(ref int a) {
            a += 100;
        }

        static void Add100(int a)
        {
            a += 100;
        }

        static void Swap(ref int a, ref int b)
        { 
            int c = a; 
            a = b;  
            b = c;
        }

        static void PrintArray(byte[] arr)
        {
            Write("[");
            foreach (byte element in arr)
            {
                Write(element + ", ");
            }
            Write("\b\b]\n");
        }

        static void PrintArray(int[] arr)
        {
            Write("[");
            foreach (int element in arr)
            {
                Write(element + ", ");
            }
            Write("\b\b]\n");
        }

        static void Main(string[] args)
        {
            int b = 1,a= -200;
            Add100(ref b);
            WriteLine($"b={b}");
            Add100(b);
           // WriteLine($"b={b}");
            WriteLine($"a={a}, b={b}");
            Swap(ref b, ref a);
            WriteLine($"a={a}, b={b}");
            // ------ 1D ARRAYS TEST -------------
            byte[] arr1 = new byte[8];
            byte[] arr2 = new byte[] {1,44,76,99,123,201};

            arr1[2] = 222;
            Write("[");
            for (int i = arr1.Length-1; i >= 0; i--)
            { 
                Write(arr1[i] + ", "); 
            }
            Write("\b\b]\n");

            Write("[");
            foreach (byte element in arr2)
            {
                Write(element + ", ");
            }
            Write("\b\b]\n");
            PrintArray(arr2);

            // 1 fill array by random numbers
            Random rand = new Random();
            for (int i = 0; i < arr1.Length; i++) arr1[i] = (byte)rand.Next(255);
            PrintArray(arr1);

            // 2 fill array by random numbers
            rand.NextBytes(arr1);
            PrintArray(arr1);


            //WriteLine(arr2.ToString());


        }
    }
}
