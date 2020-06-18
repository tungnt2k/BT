using System;
using System.Text;

namespace BT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TComplex sp1 = new TComplex(3,4);
            TComplex sp2 = new TComplex(1,2);
            TComplex sp3 = new TComplex(5,6);
            sp1.Xuat();
            sp2.Xuat();
            sp3.Xuat();
            Console.WriteLine("Nhập dữ liệu cho số phức 1");
            sp1.Nhap();
            Console.WriteLine("Nhập dữ liệu cho số phức 2");
            sp2.Nhap();
            Console.WriteLine("Nhập dữ liệu cho số phức 3");
            sp3.Nhap();
            sp1.Xuat();
            sp2.Xuat();
            sp3.Xuat();

            sp3 = sp1 - sp2;
            sp3.Xuat();
            TComplex sp4 = sp1 + sp2;
            sp4.Xuat();
            TComplex sp5 = sp4 * sp3;
            sp5.Xuat();


        }
    }
}
