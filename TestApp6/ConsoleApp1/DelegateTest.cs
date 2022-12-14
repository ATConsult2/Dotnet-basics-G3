using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andrestech.learning2022.krasn
{
    public delegate void GreetsHandler(string name); 
    internal class DelegateTest
    {
        //public delegate void GreetsHandler2(string name);
        static void SayHi(string name) =>  
            WriteLine($"Hi, {name}!! ");
        static void SayHello(string name) =>
            WriteLine($"Hello, {name}!! ");
        static void SaySalute(string name)
        {
            WriteLine($"Salute, {name}!! ");
        }

        static void SayGreets(GreetsHandler greets, string name) {
            greets(name);
        }

        static void SayGreets2(Action<string> greets, string name)
        {
            greets(name);
        }
        static void Main2(string[] args)
        {
            SayGreets(SayHello, "Andrei");
            SayGreets2(SayHi, "Peter");
            SayGreets(SaySalute, "Basil");
            SayGreets2(name => WriteLine("Привет, " + name + "!!"), "Таня");

            WriteLine($"------------------------");
            Action<string> greets = SayHello;
            greets += SayHi;
            greets += SaySalute;
            greets += name => WriteLine("Как дела, " + name + "!!");
            SayGreets2(greets,"Andrei");
            greets -= SayHi;
            WriteLine($"------------------------");
            SayGreets2(greets, "Andrei");

            WriteLine($"-------- Calclus Test ---------");
            Dictionary<string, Func<int, int, int>> calculator =
                new Dictionary<string, Func<int, int, int>>()
                {
                    {"+", (x,y) => x+y },
                    {"-", (x,y) => x-y},
                    {"*", (x,y) => x*y},
                    {"/", (x,y) => x/y},
                };
            // int -> double
            WriteLine(calculator["*"](2, 18));
            WriteLine($"-------- EventTest ---------");
            Library lib = new Library(new List<Book>());
               
            NewBookHandler subscr1 = mess => WriteLine("S1: " + mess);
            NewBookHandler subscr2 = mess => WriteLine("S2: " + mess);
            lib.NewBook += subscr1;
            lib.NewBook += subscr2;

            lib.Add(new Book() { Title = "Война Миров", Author = "Г. Уэлс" });

            lib.NewBook -= subscr2;
            lib.Add(new Book() { Title = "To Stars", Author = "R. Heinlein" });

        }
    }
}
