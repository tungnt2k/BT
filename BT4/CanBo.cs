using System;
using System.Collections.Generic;
using System.Text;
namespace BT4
{
  public class CanBo : ConNguoi
  {
    public float heSoLuong { get; set; }
    public int thamNien { get; set; }
    public CanBo() : base()
    {
      this.heSoLuong = 0;
      this.thamNien = 0;
    }
    public CanBo(string ht, int t, string qq, string gt, string ptdl, float hsl, int tn) : base(ht, t, qq, gt, ptdl)
    {
      this.heSoLuong = hsl;
      this.thamNien = tn;
    }
    public override void Nhap()
    {
      base.Nhap();
      Console.Write("Hệ số lương : ");
      this.heSoLuong = float.Parse(Console.ReadLine());
      Console.Write("Thâm niên : ");
      this.thamNien = int.Parse(Console.ReadLine());
    }
    public override void Xuat()
    {
      base.Xuat();
      Console.WriteLine("Hệ số lương : " + this.heSoLuong);
      Console.WriteLine("Thâm niên : " + this.thamNien);
    }
    public float tinhLuong()
    {
      return this.heSoLuong * 1300 + this.thamNien * 100;
    }
  }
}
