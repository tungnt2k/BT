using System;
using System.Text;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn phương tiện mà bạn yêu thích :");
            Console.WriteLine("1. Ô tô");
            Console.WriteLine("2. Xe máy");
            Console.WriteLine("3. Tàu thủy");
            Console.WriteLine("4. Máy bay");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                {
                        Oto a = new Oto();
                        a.DiChuyen();
                }
                    break;
                case 2:
                {
                    XeMay a = new XeMay();
                    a.DiChuyen();
                }
                    break;
                case 3:
                {
                    TauThuy a = new TauThuy();
                    a.DiChuyen();
                }
                    break;
                case 4:
                {
                    MayBay a = new MayBay();
                    a.DiChuyen();
                }
                    break;
                default:
                    Console.WriteLine("Bạn đã chọn sai lựa chọn !");
                    break;
            }
        }
    }
}
