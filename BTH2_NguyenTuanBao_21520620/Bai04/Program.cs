namespace Bai04
{
    internal class Program
    {
        // Ham tim Uoc chung lon nhat
        public static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
        public class PhanSo
        {
            protected int _tuSo, _mauSo;
            public int TuSo
            {
                get { return _tuSo; }
                set { _tuSo = value; }
            }
            public int MauSo
            {
                get { return _mauSo; }
                set { _mauSo = value; }
            }
            public PhanSo()
            {

            }
            public PhanSo(int tuSo, int mauSo)
            {
                _tuSo = tuSo;
                _mauSo = mauSo; 
            }
            // Ham nhap phan so, xuat phan so
            public void NhapPhanSo()
            {
                Console.WriteLine("Hay nhap tu so:");
                _tuSo = int.Parse(Console.ReadLine());
                Console.WriteLine("Hay nhap mau so:");
                _mauSo = int.Parse(Console.ReadLine());
            }
            public void XuatPhanSo()
            {
                Console.Write(_tuSo + "/" + _mauSo);
                Console.WriteLine();
            }
            // Cac ham cong tru nhan chia
            public static PhanSo operator+(PhanSo ps1, PhanSo ps2)
            {
                PhanSo res = new PhanSo();
                res._tuSo = ps1._tuSo * ps2._mauSo + ps1._mauSo * ps2._tuSo;
                res._mauSo = ps1._mauSo * ps2._mauSo;
                int gcd = GCD(res._tuSo, res._mauSo);
                res._tuSo /= gcd;
                res._mauSo /= gcd;
                return res;
            }
            public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
            {
                PhanSo res = new PhanSo();
                res._tuSo = ps1._tuSo * ps2._mauSo - ps1._mauSo * ps2._tuSo;
                res._mauSo = ps1._mauSo * ps2._mauSo;
                int gcd = GCD(res._tuSo, res._mauSo);
                res._tuSo /= gcd;
                res._mauSo /= gcd;
                return res;
            }
            public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
            {
                PhanSo res = new PhanSo();
                res._tuSo = ps1._tuSo * ps2._tuSo;
                res._mauSo = ps1._mauSo * ps2._mauSo;
                int gcd = GCD(res._tuSo, res._mauSo);
                res._tuSo /= gcd;
                res._mauSo /= gcd;
                return res;
            }
            public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
            {
                PhanSo res = new PhanSo();
                res._tuSo = ps1._tuSo * ps2._mauSo;
                res._mauSo = ps1._mauSo * ps2._tuSo;
                int gcd = GCD(res._tuSo, res._mauSo);
                res._tuSo /= gcd;
                res._mauSo /= gcd;
                return res;
            }

        }
        public static void NhapDayPhanSo(int n, ref PhanSo[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hay nhap phan so thu " + (i + 1));
                arr[i] = new PhanSo();
                arr[i].NhapPhanSo();
            }
        }
        public static PhanSo PhanSoMax(int n, PhanSo[] arr)
        {
            PhanSo res = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (1.0 * res.TuSo / res.MauSo < 1.0 * arr[i].TuSo / arr[i].MauSo)
                {
                    res = arr[i];
                }
            }
            return res;
        }
        public static void SapXepPhanSo(int n, ref PhanSo[] arr)
        {
            for (int i = 0 ; i < n ; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (1.0 * arr[i].TuSo / arr[i].MauSo > 1.0 * arr[j].TuSo / arr[j].MauSo)
                    {
                        PhanSo temp = new PhanSo();
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        public static void XuatDayPhanSo(int n, PhanSo[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i].XuatPhanSo();
            }
        }
        static void Main(string[] args)
        {
            // Nhap hai phan so va xuat ket qua tong hieu tich thuong

            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            Console.WriteLine("Hay nhap phan so thu nhat:");
            ps1.NhapPhanSo();
            Console.WriteLine("Hay nhap phan so thu hai:");
            ps2.NhapPhanSo();

            Console.Write("Tong hai phan so tren la: ");
            PhanSo tong = new PhanSo();
            tong = ps1 + ps2;
            tong.XuatPhanSo();
            Console.Write("Hieu hai phan so tren la: ");
            PhanSo hieu = new PhanSo();
            hieu = ps1 - ps2;
            hieu.XuatPhanSo();
            Console.Write("Tich hai phan so tren la: ");
            PhanSo tich = new PhanSo();
            tich = ps1 * ps2;
            tich.XuatPhanSo();
            Console.Write("Thuong hai phan so tren la: ");
            PhanSo thuong = new PhanSo();
            thuong = ps1 / ps2;
            thuong.XuatPhanSo();

            // Nhap day cac phan so
            Console.WriteLine("Hay nhap so cac phan so:");
            int n = int.Parse(Console.ReadLine());
            PhanSo[] arrPhanSo = new PhanSo[n];
            NhapDayPhanSo(n, ref arrPhanSo);

            // Tim phan so lon nhat
            PhanSo phanSoLonNhat = PhanSoMax(n, arrPhanSo);
            Console.Write("Phan so co gia tri lon nhat la: ");
            phanSoLonNhat.XuatPhanSo();

            // Sap xep cac phan so va xuat ket qua
            Console.WriteLine("Truoc khi sort:");
            XuatDayPhanSo(n, arrPhanSo);
            SapXepPhanSo(n, ref arrPhanSo);
            Console.WriteLine("Sau khi sort:");
            XuatDayPhanSo(n, arrPhanSo);
        }
    }
}
