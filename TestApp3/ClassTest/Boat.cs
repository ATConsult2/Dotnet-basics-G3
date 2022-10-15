using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.dock
{
    //class Engine { }

    class Boat
    {
        //public Engine engine;
        public int MaxSpeed;
        public int Mass;
        public int Power;
        public Boat() { 
            WriteLine("+++ ctor Boat.");
        }

        public string getInfo() {
            return $"Boat -> speed:{MaxSpeed}, power:{Power}, mass:{Mass}";
        }
    }
}
