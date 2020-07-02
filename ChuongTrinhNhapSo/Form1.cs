using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhNhapSo
{
    public partial class Form1 : Form
    {
        private int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "", b = "", c = "";
            for (int i = 1; i < n; i++)
            {
                if (snt(i))
                {
                    a += string.Format("{0},", i);
                }

                if (scp(i))
                {
                    b += string.Format("{0},", i);
                }

                if (shc(i))
                {
                    c += string.Format("{0},", i);
                }
            }

            label5.Text = a;
            label6.Text = b;
            label7.Text = c;
        }

        private bool snt(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }

            return true;
        }

        private bool scp(int n)
        {
            for (int i = 1; i <n; i++)
            {
                if (Math.Sqrt(n)==i)
                {
                    return true;
                }
            }

            return false;
        }

        private bool shc(int n)
        {
            int tongUoc = 0;
            for (int i = 1; i < n; i++)
            {
                if (n%i==0)
                {
                    tongUoc += i;
                }
            }

            if (tongUoc==n)
            {
                return true;
            }

            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out n))
            {
                textBox1.Text = "";
                MessageBox.Show("Bạn cần nhập một số ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
