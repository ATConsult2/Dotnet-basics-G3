using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.dock
{

    class Boat2
    {
        private int _mass;
        private int _power;
        private int _max_speed;

        // alternative for Property
        private int _id;
        public int getId() { return _id; }
        public void setId(int id) { _id = id; } 


        public int MaxSpeed { 
        get { return _max_speed; }
        set { if (value < 0 || value > 120) throw new Exception("Wrong speed!!!"); 
              _max_speed = value; 
            }
        }
        public int Mass { 
        get { return _mass; }
        set { _mass = value; }  
        }
        public int Power { 
        get { return _power; }
        set { _power = value; } 
        }

        public Boat2() { 
            WriteLine("+++ ctor Boat2.");
        }

        public string getInfo() {
            return $"Boat2 -> speed:{MaxSpeed}, power:{Power}, mass:{Mass}";
        }
    }
}
