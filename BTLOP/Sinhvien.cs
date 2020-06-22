using System;
using System.Collections.Generic;
using System.Text;

namespace BTLOP
{
    class Sinhvien
    {
        public string hoTen { get; set; }
        public string maSV { get; set; }
        public string queQuan { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public PhuongTienGiaoThong phuongTienDiLai { get; set; }

        public Sinhvien()
        {
            this.hoTen = "";
            this.maSV = "";
            this.queQuan = "";
            this.gioiTinh = "";
            this.phuongTienDiLai = new DiBo();

        }
        public Sinhvien(string ht, string msv, string qq, string gt, float dt, float dv, float da)
        {
            this.hoTen = ht;
            this.maSV = msv;
            this.queQuan = qq;
            this.gioiTinh = gt;

        }

        public void Nhap()
        {
            Console.WriteLine("Nhập thông tin : ");
            Console.Write("Họ và tên : ");
            this.hoTen = Console.ReadLine();
            Console.Write("Mã sinh viên : ");
            this.maSV = Console.ReadLine();
            Console.Write("Quê quán : ");
            this.queQuan = Console.ReadLine();
            Console.Write("Giới tính : ");
            this.gioiTinh = Console.ReadLine();
            Console.Write("Ngày sinh : ");
            this.ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Chọn phương tiện đi lại : ");
            Console.WriteLine("1.Ô tô");
            Console.WriteLine("2.Xe máy");
            Console.WriteLine("3. Xe đạp");
            Console.WriteLine("4. Máy bay");
            Console.WriteLine("5. Tàu điện ngầm");
            Console.WriteLine("Khác : Đi bộ");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    this.phuongTienDiLai = new Oto();
                    break;
                case 2:
                    this.phuongTienDiLai = new XeMay();
                    break;
                case 3:
                    this.phuongTienDiLai = new XeDap();
                    break;
                case 4:
                    this.phuongTienDiLai = new MayBay();
                    break;
                case 5:
                    this.phuongTienDiLai = new TauDien();
                    break;
                default:
                    this.phuongTienDiLai = new DiBo();
                    break;
            }

        }

        public void Xuat()
        {
            Console.WriteLine("Thông tin đã nhập : ");
            Console.WriteLine("Họ và tên : " + this.hoTen);
            Console.WriteLine("Mã SV : " + this.maSV);
            Console.WriteLine("Quê quán : " + this.queQuan);
            Console.WriteLine("Giới tính : " + this.gioiTinh);
            Console.WriteLine("Ngày sinh : " + this.ngaySinh.ToString("dd/MM/yyyy"));
            Console.Write("Phương tiện đi lại : ");
            this.phuongTienDiLai.DiChuyen();

        }

        public void XuatTheoBang()
        {
            Console.Write("{0}      {1}           {2}             {3}             {4}       ", this.maSV, this.hoTen, this.gioiTinh, this.queQuan, this.ngaySinh.ToString("dd/MM/yyyy"));
            this.phuongTienDiLai.DiChuyen();
        }


    }
}
