using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System;

namespace Bai04
{
    internal class Program
    {
        public static int DaysofMonth(int month, int year)
        {
            DateTime dateTime;
            try
            {
                dateTime = new DateTime(year, month, 1);
                // Them 1 thang roi tru di mot ngay la se ra ngay lon nhat trong thang = so ngay trong thang do
                dateTime = dateTime.AddMonths(1).AddDays(-1);
                return dateTime.Day;
            }
            catch
            {
                Console.WriteLine("Thang va nam da nhap khong hop le !!!");
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap thang:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap nam");
            int year = int.Parse(Console.ReadLine());
            int res = DaysofMonth(month, year);
            if (res != -1) Console.WriteLine("So ngay trong thang nam da nhap la: " + res);
        }
    }
}
