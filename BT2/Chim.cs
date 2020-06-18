using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    public class Chim : DongVat
    {
        public override void An()
        {
            Console.WriteLine("Chim ăn gạo, thóc, cám");
        }

        public override void DiChuyen()
        {
            Console.WriteLine("Chim di chuyển bằng 2 chân");
        }

        public override void TiengKeu()
        {
            Console.WriteLine("Cúc cu");
        }
    }
}
