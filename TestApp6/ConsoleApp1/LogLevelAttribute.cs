using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andrestech.learning2022.krasn
{
    internal class LogLevelAttribute : Attribute
    {
        public int Level { get; }
        public LogLevelAttribute() { }
        public LogLevelAttribute(int level)
        {
            Level = level;
        }   
    }
}
