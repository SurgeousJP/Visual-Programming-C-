using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System;

namespace Bai03
{
    internal class Program
    {
        public static bool CheckValidDateTime(int day, int month, int year)
        {
            string DateTimestr;
            try
            {
                DateTime test = new DateTime(year, month, day);
                DateTimestr = String.Format("{0:dd/MM/yyyy}", test);
;            }
            catch
            {
                Console.WriteLine("Ngay thang nam khong hop le !!!");
                return false;
            }
            Console.WriteLine("Ngay thang nam da nhap la hop le: " + DateTimestr);
            return true;
        }
        static void Main(string[] args)
        {
            int day, month, year;
            Console.WriteLine("Hay nhap ngay:");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap thang:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap nam:");
            year = int.Parse(Console.ReadLine());
            CheckValidDateTime(day, month, year);
        }
    }
}
