using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    public class Cho:DongVat
    {
        public override void An()
        {
            Console.WriteLine("Chó ăn cơm");
        }

        public override void DiChuyen()
        {
            Console.WriteLine("Chó di chuyển bằng 4 chân");
        }

        public override void TiengKeu()
        {
            Console.WriteLine("Gâu gâu");
        }
    }
}
