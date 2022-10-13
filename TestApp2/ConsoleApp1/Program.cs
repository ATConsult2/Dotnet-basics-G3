using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//WriteLine("Pass");
namespace andestech.learning2022.krasn
{
   // WriteLine("Pass");
    internal class Program
    {

        static void TestInput() {
            WriteLine("Test input program. Press \"x\" to exit. Enjoy!");

            while (true)
            {
                Write("Enter number: ");
                string consoleData = ReadLine();
                if (consoleData == "x")
                { WriteLine("Bye.."); break; }

                //Console.WriteLine($"You input: {consoleData}");

                int Number = 0;
                if (!int.TryParse(consoleData, out Number))
                {
                    WriteLine("Wrong format.. Input ignored.");
                };
                Console.WriteLine($"Your number*10: {Number * 10}");
            }
        
        }

        static void Main(string[] args)
        {
            
            Write("Pass\n");
            Write("Pass\tPass\tPass\t\n");

            TestInput();

            Write("press any key..");
            ReadKey();
        }
    }
}
