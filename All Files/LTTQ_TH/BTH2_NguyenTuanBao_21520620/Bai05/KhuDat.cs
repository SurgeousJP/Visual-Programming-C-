using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Bai05
{
    internal class KhuDat : BatDongSan
    {
        public KhuDat()
        {

        }
        public KhuDat(string location, double price, double area) : base(location, price, area)
        {
            _location = location;
            _price = price;
            _area = area;
        }
        public override bool ThoaDieuKien()
        {
            return _area >= 100;
        }
    }
}
