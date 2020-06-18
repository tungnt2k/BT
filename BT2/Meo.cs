using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    public class Meo:DongVat
    {
        public override void An()
        {
            Console.WriteLine("Mèo ăn cơm");
        }

        public override void DiChuyen()
        {
            Console.WriteLine("Mèo di chuyển bằng 4 chân");
        }

        public override void TiengKeu()
        {
            Console.WriteLine("Meo meo");
        }
    }
}
