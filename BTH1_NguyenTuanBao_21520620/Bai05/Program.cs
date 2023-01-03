using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System;

namespace Bai05
{
    internal class Program
    {
        public static string DayofTheWeek(int dd, int MM, int yyyy)
        {
            DateTime dt;
            try
            {
                dt = new DateTime(yyyy, MM, dd);
                return dt.DayOfWeek.ToString();
            }
            catch
            {
                Console.WriteLine("Ngay thang nam khong hop le !!!");
                return "";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap ngay:");
            int dd = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap thang:");
            int MM = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap nam:");
            int yyyy = int.Parse(Console.ReadLine());
            
            // Xuat ket qua
            string res = DayofTheWeek(dd, MM, yyyy);
            if (res != "") Console.WriteLine("Thu trong tuan cua ngay thang nam da nhap la: " + res); 
        }
    }
}
