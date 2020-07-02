using System;
using System.Collections.Generic;
using System.Text;

namespace BTLOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng sinh viên : ");
            int slsv = int.Parse(Console.ReadLine());
            List<Sinhvien> dssv = new List<Sinhvien>();
            for(int i = 0; i < slsv; i++)
            {
                Sinhvien tmp = new Sinhvien();
                tmp.Nhap();
                dssv.Add(tmp);
            }

            Console.WriteLine("MaSV     Họ tên          Giới tính       Quê quán        Ngày sinh       Phương tiện đi lại");

            dssv.ForEach((e) =>
            {
                e.XuatTheoBang();
            });

        }
    }
}
