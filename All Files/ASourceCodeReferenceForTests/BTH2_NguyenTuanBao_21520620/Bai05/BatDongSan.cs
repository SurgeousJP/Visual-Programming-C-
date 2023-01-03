using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Bai05
{
    internal abstract class BatDongSan
    {
        protected string _location;
        public string Location { get { return _location; } set { _location = value; } }

        protected double _price;
        public double Price { get { return _price; } set { _price = value; } }

        protected double _area;
        public double Area { get { return _area; } set { _area = value; } }
        public BatDongSan()
        {

        }
        public BatDongSan(string location, double price, double area)
        {
            _location = location;
            _price = price;
            _area = area;
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Hay nhap dia diem:");
            _location = Console.ReadLine();
            Console.WriteLine("Hay nhap gia:");
            _price = double.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap dien tich (m2):");
            _area = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Dia diem: " + _location);
            Console.WriteLine("Gia: " + _price);
            Console.WriteLine("Dien tich (m2): " + _area);
        }
        // Ham tra ve gia tri true -> thoa khu đất có diện tích > 100m2 hoặc là nhà phố mà có
        // diện tích >60m2 và năm xây dựng >= 2019 (nếu có).
        public abstract bool ThoaDieuKien();
        // Cho thong tin, tra ve gia tri true neu thoa dieu kien
        // có địa điểm chứa chuỗi tìm kiếm không phân biệt hoa thường,
        // có giá <= giá tìm kiếm, và diện tích >= diện tích cần tìm kiếm)
        public bool ThoaYeuCau(string location, double price, double area)
        {
            return string.Equals(_location, location) && _price <= price && _area >= area;
        }


    }
}
