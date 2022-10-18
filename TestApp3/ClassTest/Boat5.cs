using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.dock
{

    class Boat5
    {
        public static int Counter { get;  private set; } = 0;

        static Boat5() {
            //...
            WriteLine("+++ STATIC ctor Boat5");
            random = new Random();
        }

        public const string DOCK_ID = "AA-345-KRASNOYARSK";
        private static Random random;
        private readonly int _id = random.Next();
        public int MaxSpeed { get; }
        public int Mass {get;}
        public int Power {get;} 
        
        public Boat5() { 
            WriteLine($"+++ ctor default Boat5. Id:{_id}, ObjectId: {this.GetHashCode()}");
        }
        public Boat5(int mass, int power, int max_speed):this()
        {
            WriteLine("+++ ctor params Boat5.");
            if (max_speed < 0 || max_speed > 120) throw new Exception("Wrong speed!!!");
        MaxSpeed = max_speed;
            Mass = mass;
            Power = power;
            Counter++;
        }   

        public string getInfo() {
            
            return $"Boat5 -> speed:{MaxSpeed}, power:{Power}, mass:{Mass}";
        }
    }
}
