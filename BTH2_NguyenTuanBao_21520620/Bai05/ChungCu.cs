using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Bai05
{
    internal class ChungCu : BatDongSan
    {
        protected int _soTang;
        public int soTang { get { return _soTang; } set { _soTang = value; } }

        public ChungCu()
        {

        }
        public ChungCu(string location, double price, double area, int soTang) : base(location, price, area) 
        {
            this._soTang = soTang;
        }
        public override bool ThoaDieuKien()
        {
            return false;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Hay nhap so tang:");
            _soTang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So tang: " + _soTang);
        }
    }
}
