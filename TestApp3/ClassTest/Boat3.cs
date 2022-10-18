using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.dock
{

    class Boat3
    {
        private int _mass;
        private int _power;
        private int _max_speed;   

        public int MaxSpeed { 
        get { return _max_speed; }
        private set { if (value < 0 || value > 120) throw new Exception("Wrong speed!!!"); 
              _max_speed = value; 
            }
        }
        public int Mass { 
        get { return _mass; }
        private set { _mass = value; }  
        }
        public int Power { 
        get { return _power; }
        private set { _power = value; } 
        }

        public Boat3() { 
            WriteLine("+++ ctor Boat3.");
        }
        public Boat3(int mass, int power, int max_speed)
        {
        MaxSpeed = max_speed;
            Mass = mass;
            Power = power;
        }   

        public string getInfo() {
            return $"Boat3 -> speed:{MaxSpeed}, power:{Power}, mass:{Mass}";
        }
    }
}
