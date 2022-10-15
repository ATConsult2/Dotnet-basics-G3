using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using andestech.learning2022.krasn.dock;



namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat();
            boat.Power = 200;
            boat.MaxSpeed = 40;
            boat.Mass = 250;
            WriteLine(boat.getInfo());

            new Boat();

        }
    }
}
