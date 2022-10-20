using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace andestech.learning2022.krasn
{
    internal class Box : IComparable<Box>
    {
        public uint Capacity { private set; get; }
        public Box(uint capacity)
        {
            Capacity = capacity;
        }

        public static Box operator +(Box b1, Box b2)
        {
            return new Box(b1.Capacity + b2.Capacity);
        }

        public static Box operator ++(Box b1)
        {
            b1.Capacity += 1;
            return b1;
        }

        public static bool operator ==(Box b1, Box b2)
        {
            return b1.Capacity == b2.Capacity;
        }

        public static bool operator !=(Box b1, Box b2)
        {
            return b1.Capacity != b2.Capacity;
        }

        public static Box operator --(Box b1)
        {
            uint C = b1.Capacity - 1;
            if (C > 0) { b1.Capacity = C; return b1; }
            else throw new ArgumentException("Wrong box size!!! ");
        }

        public override string ToString()
        {
            // return $"Box: {Capacity}, id: {GetHashCode()}.";
            return $"Box: {Capacity}.";
        }

        public override bool Equals(object obj)
        {
            return Capacity == ((Box)obj).Capacity;
        }

        public int CompareTo(Box other)
        {
            return (int)(Capacity - other.Capacity);
        }
    }
}
