using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bai5
{
    public partial class Phanso : Form
    {
        public int tu;
        public int mau;
        public Phanso()
        {

        }
        public Phanso(int tu, int mau)
        {
            this.tu = tu;
            if (mau != 0)
            {
                this.mau = mau;
            }
            else
            {
                throw new ArgumentException("Mẫu phải khác 0");
            }
        }
        public void Rutgon()
        {
            int ucln = UCLN(Math.Abs(tu), Math.Abs(mau));
            tu /= ucln;
            mau /= ucln;
        }

        public static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static Phanso operator +(Phanso ps1, Phanso ps2)
        {
            int tuMoi = ps1.tu * ps2.mau + ps2.tu * ps1.mau;
            int mauMoi = ps1.mau * ps2.mau;
            Phanso ketqua = new Phanso(tuMoi, mauMoi);
            ketqua.Rutgon();
            return ketqua;
        }

        public static Phanso operator -(Phanso ps1, Phanso ps2)
        {
            int tuMoi = ps1.tu * ps2.mau - ps2.tu * ps1.mau;
            int mauMoi = ps1.mau * ps2.mau;
            Phanso ketqua = new Phanso(tuMoi, mauMoi);
            ketqua.Rutgon();
            return ketqua;
        }

        public static Phanso operator *(Phanso ps1, Phanso ps2)
        {
            int tuMoi = ps1.tu * ps2.tu;
            int mauMoi = ps1.mau * ps2.mau;
            Phanso ketqua = new Phanso(tuMoi, mauMoi);
            ketqua.Rutgon();
            return ketqua;
        }

        public static Phanso operator /(Phanso ps1, Phanso ps2)
        {
            if (ps2.tu != 0)
            {
                int tuMoi = ps1.tu * ps2.mau;
                int mauMoi = ps1.mau * ps2.tu;
                Phanso ketqua = new Phanso(tuMoi, mauMoi);
                ketqua.Rutgon();
                return ketqua;
            }
            else
            {
                throw new DivideByZeroException("Không thể chia cho phân số có tử bằng 0.");
            }
        }

    }
}
