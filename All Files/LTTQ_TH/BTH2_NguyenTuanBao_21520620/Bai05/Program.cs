using Lab02_Bai05;
namespace Bai05
{
    internal class Program
    {
        public static void Nhap(ref BatDongSan[] list, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("Hay chon loai bat dong san:\n1 - Khu dat\n2 - Nha pho\n3 - Chung cu\n");
                int type = int.Parse(Console.ReadLine());
                if (type == 1)
                {
                    list[i] = new KhuDat();
                }
                else if (type == 2)
                {
                    list[i] = new NhaPho();
                }
                else if (type == 3)
                {
                    list[i] = new ChungCu();
                }
                list[i].Nhap();
            }
        }
        public static void Xuat(BatDongSan[] list, int size)
        {
            for (int i = 0; i < size; i++)
            {
                list[i].Xuat();
                Console.WriteLine();
            }
        }
        public static void TotalPriceForEachType(BatDongSan[] list, int size)
        {
            double khuDatTotalPrice = 0;
            double nhaPhoTotalPrice = 0;
            double chungCuTotalPrice = 0;
            for (int i = 0; i < size; i++)
            {
                if (list[i] is KhuDat) khuDatTotalPrice += list[i].Price;
                else if (list[i] is NhaPho) nhaPhoTotalPrice += list[i].Price;
                else if (list[i] is ChungCu) chungCuTotalPrice += list[i].Price;
            }
            Console.WriteLine("Tong gia tien cua cac khu dat: " + khuDatTotalPrice);
            Console.WriteLine("Tong gia tien cac nha pho: " + nhaPhoTotalPrice);
            Console.WriteLine("Tong gia tien cac chung cu: " + chungCuTotalPrice);
        }
        public static void XuatBDSThoaDieuKien(BatDongSan[] list, int size)
        {
            Console.WriteLine("Cac BDS thoa dieu kien la:");
            for (int i = 0; i < size; i++)
            {
                if (list[i].ThoaDieuKien()) list[i].Xuat();
            }
        }
        public static void XuatBDSThoaYeuCau(BatDongSan[] list, int size, string location, double price, double area)
        {
            Console.WriteLine("Cac BDS thoa yeu cau da nhap la:");
            for (int i = 0; i < size; i++)
            {
                if (list[i].ThoaYeuCau(location, price, area)) list[i].Xuat();
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap so toa nha (bat dong san):");
            int numOfBuildings = int.Parse(Console.ReadLine());
            BatDongSan[] list = new BatDongSan[numOfBuildings];
            // Nhap xuat danh sach bat dong san
            Nhap(ref list, numOfBuildings);
            Console.WriteLine();
            Xuat(list, numOfBuildings);
            Console.WriteLine();
            // Xuat tong gia tien tung loai bat dong san
            TotalPriceForEachType(list, numOfBuildings);
            Console.WriteLine();
            // Xuat danh sách các khu đất có diện tích > 100m2 hoặc là nhà phố mà có
            // diện tích > 60m2 và năm xây dựng >= 2019(nếu có).
            XuatBDSThoaDieuKien(list, numOfBuildings);
            Console.WriteLine();
            // Nhap thong tin dia diem, gia, dien tich, xuat danh sach thoa dieu kien
            Console.WriteLine("Hay nhap dia diem:");
            string location = Console.ReadLine();
            Console.WriteLine("Hay nhap gia:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap dien tich:");
            double area = double.Parse(Console.ReadLine());
            XuatBDSThoaYeuCau(list, numOfBuildings, location, price, area);
        }
    }
}