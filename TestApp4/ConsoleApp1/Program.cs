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
            WriteLine(p4?.I);
        }

        static void GameStage1122(IGame sprite)
    //  static void GameStage1122(Sprite sprite)
        {
            sprite.MoveX(10).Rotate(33).MoveY(2);
            sprite.Render();
        }

        static void Main(string[] args)
        {
            // PintaTest();
           //  Sprite sp1 = new Sprite(angle: 0,
            //    coords: new Point2D { X = 1, Y = 2 },
            //    color: Color.Green);
            // sp1.MoveX(1).MoveY(3).MoveX(-10).Rotate(25).MoveY(2);
           //  WriteLine(sp1);

            Rectangle rt1= new Rectangle(angle: 0,
               coords: new Point2D { X = 1, Y = 2 },
               color: Color.Green, height:10, width:5);
            WriteLine(rt1);
            rt1.Render();

            Circle c1 = new Circle(angle: 0,
               coords: new Point2D { X = 1, Y = 2 },
               color: Color.Green, radius: 5);
            WriteLine(c1.MoveX(10).MoveY(-2));
            c1.Render();

            //--------- cast test -------------
            WriteLine(new String('+', 60));
            Sprite s2 = c1;
            s2.Render();
            WriteLine(new String('+', 60));

            Circle c2 = (Circle)s2;
            c2.Render();
            WriteLine(new String('-', 60));

            Object o1 = new Circle(angle: 23,
               coords: new Point2D { X = 1, Y = 2 },
               color: Color.Green, radius: 5);

           // Rectangle rt3 = (Rectangle)o1;  //! invalid cast exception
           //1
            Rectangle rt3 = o1 as Rectangle;
            rt3?.Render();

            //2
            if (o1 is Rectangle rt4)
            {
                rt4.Render();
            }

            // ----- poly test --------
            WriteLine(new String('-', 20) + " Poly test " + new String('-', 20));
            GameStage1122(rt1);
            GameStage1122(c2);






        }
    }
}
