using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Bai05
{
    internal class NhaPho : BatDongSan
    {
        protected int _soTang;
        public int soTang { get { return _soTang; } set { _soTang = value; } }
        protected int _yearBuilt;
        public int yearBuilt { get { return _yearBuilt; } set { _yearBuilt = value; } }
        public NhaPho()
        {

        }
        public NhaPho(string location, double price, double area, int yearBuilt, int soTang) : base(location, price, area)
        {
            this._yearBuilt = yearBuilt;
            this._soTang = soTang;
        }
        public override bool ThoaDieuKien()
        {
            return _area > 100 && _yearBuilt >= 2019;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Hay nhap nam xay dung:");
            _yearBuilt = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap so tang:");
            _soTang = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Nam xay dung: " + _yearBuilt);
            Console.WriteLine("So tang: " + _soTang);
            
        }
    }
}