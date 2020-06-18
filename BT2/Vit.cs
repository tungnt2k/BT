using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    public class Vit:DongVat
    {
        public override void An()
        {
            Console.WriteLine("Vịt ăn cám");
        }

        public override void DiChuyen()
        {
            Console.WriteLine("Vịt di chuyển bằng 2 chân");
        }

        public override void TiengKeu()
        {
            Console.WriteLine("Quạc quạc");
        }
    }
}
