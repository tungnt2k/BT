using System;
using System.Collections.Generic;
using System.Text;

namespace BT
{
    class TComplex
    {
        public int pThuc { get; set; }
        public int pAo { get; set; }

        public TComplex()
        {
            this.pAo = 0;
            this.pThuc=0;
        }
        public TComplex(int pt, int pa)
        {
            this.pThuc = pt;
            this.pAo = pa;
        }

        public void Nhap()
        {
            Console.Write("Nhập phần thực : ");
            this.pThuc = int.Parse(Console.ReadLine());
            Console.Write("Nhập phần ảo : ");
            this.pAo = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Số thực là : {0} + {1}i",this.pThuc,this.pAo);
        }

        public static TComplex operator +(TComplex sp1, TComplex sp2)
        {
            TComplex sp = new TComplex(sp1.pThuc+sp2.pThuc,sp1.pAo+sp2.pAo);
            return sp;
        }

        public static TComplex operator -(TComplex sp1, TComplex sp2)
        {
            TComplex sp = new TComplex(sp1.pThuc - sp2.pThuc, sp1.pAo - sp2.pAo);
            return sp;
        }
        public static TComplex operator *(TComplex sp1, TComplex sp2)
        {
            TComplex sp = new TComplex((sp1.pThuc * sp2.pThuc) -(sp1.pAo * sp2.pAo), (sp1.pThuc * sp2.pAo) + (sp1.pAo * sp2.pThuc));
            return sp;
        }
    }
}
