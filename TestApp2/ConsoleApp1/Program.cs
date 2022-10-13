using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//WriteLine("Pass");
namespace andestech.learning2022.krasn
{

    enum LogSeverety { 
    Info=1,     //    0b1
    Warning=2,  //   0b10
    Error=4,    //  0b100
    Metadata=8, // 0b1000
    Debug=16    //0b10000
    }

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

        static void Calculator()
        {
            WriteLine("Calculator program. Press \"x\" to exit. Enjoy!");

            while (true)
            {
                Write("Enter number1: ");
                string sa = ReadLine();

                Write("Enter number2: ");
                string sb = ReadLine();

                if (sa == "x" || sb == "x")
                { WriteLine("Bye.."); break; }

                int summa=0, a = 0, b=0;

                if (!int.TryParse(sa, out a) || !int.TryParse(sb, out b))
                {
                    WriteLine("Wrong format.. Input ignored.");
                }
                else
                {
                    checked
                    {
                        summa = a + b;
                    }
                }
                Console.WriteLine($"{a} + {b} = {summa}");
            }

        }


        static void NumberTest() {
            WriteLine($"byte\t MAX: {byte.MaxValue}");
            WriteLine(String.Format("short\t MAX: {0}",short.MaxValue));
            WriteLine($"int\t MAX: {int.MaxValue}");
            WriteLine($"long\t MAX: {long.MaxValue}");
            // number bit ops

            byte a = 3;
            WriteLine(a << 1);
            WriteLine(a << 2);
            WriteLine(a << 3);
            WriteLine("-----------------------");

            byte b = 155;
            WriteLine(b >> 1);
            WriteLine(b >> 2);
            WriteLine(b >> 3);

            WriteLine("-----------------------");

            int MAX = unchecked((1 << 31) - 1);
            WriteLine($"int\t MAX: {MAX}");


        }

        static void WriteLog(string message, LogSeverety LSeverity)
        {
            switch (LSeverity)
            {
                case LogSeverety.Info:
                    WriteLine($"Log Info {message}");
                    //.....
                    break;
                case LogSeverety.Error:
                    WriteLine($"Log Error! {message}");
                    //.....
                    break;
                case LogSeverety.Error | LogSeverety.Metadata:
                    WriteLine($"Log Error with metadata! {message}");
                    //.....
                    break;
                case LogSeverety.Warning:
                    WriteLine($"Log Warning {message}");
                    //.....
                    break;
                case LogSeverety.Debug:
                    WriteLine($"Log Debug {message}");
                    //.....
                    break;
                default:
                    WriteLine("SOME OPERATIONS...");
                    break;

            }
        
        
        }

        static void LoggerTest() {
            WriteLog("start prog", LogSeverety.Info);
            WriteLog("Error", LogSeverety.Error);
            WriteLog("Error", LogSeverety.Error | LogSeverety.Metadata);
            WriteLog("Info", (LogSeverety)1);
        }

        static void Main(string[] args)
        {
            
            Write("Pass\n");
            Write("Pass\tPass\tPass\t\n");

            //TestInput();
            //Calculator();
            //NumberTest();
            LoggerTest();



            Write("press any key..");
            ReadKey();
        }
    }
}
