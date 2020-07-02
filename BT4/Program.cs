using System;
using System.Collections.Generic;
using System.Text;
namespace BT4
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      List<CanBo> dscb = new List<CanBo>();
      List<SinhVien> dssv = new List<SinhVien>();
      int select;
      Console.WriteLine("Nhập lựa chọn của bạn : ");
      Console.WriteLine("1. Nhập cán bộ");
      Console.WriteLine("2. Nhập sinh viên");
      Console.WriteLine("3. Thoát");
      do
      {
        Console.Write("Lựa chọn : ");
        select = int.Parse(Console.ReadLine());
        switch (select)
        {
          case 1:
            {
              CanBo cb = new CanBo();
              cb.Nhap();
              dscb.Add(cb);
            }
            break;
          case 2:
            {
              SinhVien sv = new SinhVien();
              sv.Nhap();
              dssv.Add(sv);
            }
            break;
          case 3:
            break;
          default:
            Console.WriteLine("Nhập sai lựa chọn !");
            break;
        }
      } while (select == 1 || select == 2);

      dscb.Sort((CanBo x, CanBo y) =>
      {
        return y.tinhLuong().CompareTo(x.tinhLuong());
      });
      dssv.Sort((SinhVien x, SinhVien y) =>
      {
        return x.hoTen.CompareTo(y.hoTen);
      });
      Console.WriteLine("Cán bộ đã nhập: ");
      dscb.ForEach((cb) =>
      {
        cb.Xuat();
      });
      Console.WriteLine("Sinh viên đã nhập: ");
      dssv.ForEach((sv) =>
      {
        sv.Xuat();
      });
    }
  }
}
