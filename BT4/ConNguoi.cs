using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace BT4
{
    public class ConNguoi
    {
        public string hoTen { get; set; }
        public int tuoi { get; set; }
        public string queQuan { get; set; }
        public string gioiTinh { get; set; }
        public string phuongTienDiLai { get; set; }

        public ConNguoi()
        {
            this.hoTen = "";
            this.tuoi = 0;
            this.queQuan = "";
            this.gioiTinh = "";
            this.phuongTienDiLai = "";
        }

        public ConNguoi(string ht, int t,string qq, string gt, string ptdl )
        {
            this.hoTen = ht;
            this.tuoi = t;
            this.queQuan = qq;
            this.gioiTinh = gt;
            this.phuongTienDiLai = ptdl;

        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhập thông tin : ");
            Console.Write("Họ và tên : ");
            this.hoTen = Console.ReadLine();
            Console.Write("Tuổi : ");
            this.tuoi = int.Parse(Console.ReadLine());
            Console.Write("Quê quán : ");
            this.queQuan = Console.ReadLine();
            Console.Write("Giới tính : ");
            this.gioiTinh = Console.ReadLine();
            Console.Write("Phương tiện đi lại : ");
            this.phuongTienDiLai = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Thông tin đã nhập : ");
            Console.WriteLine("Họ và tên : "+this.hoTen);
            Console.WriteLine("Tuổi : "+this.tuoi);
            Console.WriteLine("Quê quán : "+this.queQuan);
            Console.WriteLine("Giới tính : "+this.gioiTinh);
            Console.WriteLine("Phương tiện đi lại : "+this.phuongTienDiLai);
        }
    }
}
