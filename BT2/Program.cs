using System;
using System.Text;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn con vật bạn yêu thích :");
            Console.WriteLine("1. Chó");
            Console.WriteLine("2. Mèo");
            Console.WriteLine("3. Gà");
            Console.WriteLine("4. Vịt");
            Console.WriteLine("5. Chim");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                {
                        Cho a = new Cho();
                        a.DiChuyen();
                        a.An();
                        a.TiengKeu();
                }
                    break;
                case 2:
                {
                    Meo a = new Meo();
                    a.DiChuyen();
                    a.An();
                    a.TiengKeu();
                    }
                    break;
                case 3:
                {
                    Ga a = new Ga();
                    a.DiChuyen();
                    a.An();
                    a.TiengKeu();
                    }
                    break;
                case 4:
                {
                    Vit a = new Vit();
                    a.DiChuyen();
                    a.An();
                    a.TiengKeu();
                    }
                    break;
                case 5:
                {
                    Chim a = new Chim();
                    a.DiChuyen();
                    a.An();
                    a.TiengKeu();
                    }
                    break;
                default:
                    Console.WriteLine("Bạn đã chọn sai lựa chọn !");
                    break;
            }
        }
    }
}
