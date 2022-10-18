using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void PintaTest() {
            Pinta p1 = Pinta.getBeer();
            Pinta p2 = Pinta.getBeer(1);
            Pinta p3 = Pinta.getBeer(2);
            Pinta p33 = Pinta.getBeer(2);
            Pinta p4 = Pinta.getBeer(3);
        }

        static void Main(string[] args)
        {
            Pinta p1 = Pinta.getBeer();
            Pinta p2 = Pinta.getBeer(1);
            Pinta p3 = Pinta.getBeer(2);
            Pinta p33 = Pinta.getBeer(2);
            Pinta p4 = Pinta.getBeer(3);

        }
    }
}
