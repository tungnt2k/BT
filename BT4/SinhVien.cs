using System;
using System.Collections.Generic;
using System.Text;

namespace BT4
{
    public class SinhVien : ConNguoi
    {
        public float diemToan { get; set; }
        public float diemVan { get; set; }
        public float diemAnh { get; set; }

        public SinhVien() : base()
        {
            this.diemToan = 0;
            this.diemVan = 0;
            this.diemAnh = 0;
        }

        public SinhVien(string ht, int t, string qq, string gt, string ptdl, float dt,float dv,float da) : base(ht, t, qq, gt, ptdl)
        {
            this.diemToan = dt;
            this.diemVan = dv;
            this.diemAnh = da;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Điểm toán : ");
            this.diemToan = float.Parse(Console.ReadLine());
            Console.Write("Điểm văn : ");
            this.diemVan = float.Parse(Console.ReadLine());
            Console.Write("Điểm anh : ");
            this.diemAnh = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Điểm toán : " + this.diemToan);
            Console.WriteLine("Điểm văn : " + this.diemVan);
            Console.WriteLine("Điểm anh : " + this.diemAnh);
            Console.WriteLine("Điểm TB : "+this.diemTB());

        }

        public float diemTB()
        {
            return (this.diemToan + this.diemVan + this.diemAnh) / 3;
        }
    }
}
