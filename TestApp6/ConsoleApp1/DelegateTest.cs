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
        static void Main(string[] args)
        {
            SayGreets(SayHello, "Andrei");
            SayGreets(SayHi, "Andrei");
            SayGreets(SaySalute, "Andrei");
            WriteLine($"------------------------");

        }
    }
}
