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
            //1 set fields
            boat.Power = 200;
            boat.MaxSpeed = 40;
            boat.Mass = 250;
            WriteLine(boat.getInfo());
            //2 set fields
            Boat boat2 = new Boat {Power=1000,Mass=600,MaxSpeed=60};
            WriteLine(boat2.getInfo());
            // 
            Boat2 boat22 = new Boat2 { Power = 150, Mass = 100, MaxSpeed = 20 };
            WriteLine(boat22.getInfo());
            boat22.Power = 200;
            //
            Boat3 boat33 = new Boat3(power: 200, mass:200, max_speed:40);
            WriteLine(boat33.getInfo());
            new Boat();
            //
            Boat4 boat44 = new Boat4(power: 100, mass: 150, max_speed: 40);
            WriteLine(boat44.getInfo());
            //
            Boat5 boat55 = new Boat5(power: 80, mass: 250, max_speed: 40);
            new Boat5(power: 80, mass: 250, max_speed: 40);
            new Boat5(power: 80, mass: 250, max_speed: 40);
            WriteLine(boat55.getInfo());
            WriteLine("Dock: " + Boat5.DOCK_ID);
            WriteLine("Boats in dock: " + Boat5.Counter);
            //Boat5.DOCK_ID = "2222"; //const!!!

        }
    }
}
