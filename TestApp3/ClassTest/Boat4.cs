using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.dock
{

    class Boat4
    {
        private int _max_speed;   

        public int MaxSpeed { 
        get { return _max_speed; }
        private set { if (value < 0 || value > 120) throw new Exception("Wrong speed!!!"); 
              _max_speed = value; 
            }
        }
        public int Mass { get; private set; }
        public int Power { get; private set; } 
        
        public Boat4() { 
            WriteLine("+++ ctor Boat4.");
        }
        public Boat4(int mass, int power, int max_speed)
        {
        MaxSpeed = max_speed;
            Mass = mass;
            Power = power;
        }   

        public string getInfo() {
            return $"Boat4 -> speed:{MaxSpeed}, power:{Power}, mass:{Mass}";
        }
    }
}
