using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn
{
    internal interface IMovable
    {
        Sprite MoveX(int dx);
        Sprite MoveY(int dy);
        Sprite Rotate(int a);
    }
}
