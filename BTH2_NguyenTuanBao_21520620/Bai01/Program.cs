using System;
using System.IO;

namespace Bai01
{
    class Program
    {
        // Ham xac dinh thu cua mot ngay xac dinh trong thang
        public static string DayOfTheWeek(int dd, int MM, int yyyy)
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
        // Xac dinh so ngay toi da co trong mot thang
        public static int DaysOfMonth(int month, int year)
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
        // Ham xac dinh vi tri cot trong mang lich duoc in ra
        public static int IndexOfDayInTheWeek(string dayOfWeek)
        {
            if (dayOfWeek == "Monday")
            {
                return 1;
            }
            else if (dayOfWeek == "Tuesday")
            {
                return 2;
            }
            else if (dayOfWeek == "Wednesday")
            {
                return 3;
            }
            else if (dayOfWeek == "Thursday")
            {
                return 4;
            }
            else if (dayOfWeek == "Friday")
            {
                return 5;
            }
            else if (dayOfWeek == "Saturday")
            {
                return 6;
            }
            else if (dayOfWeek == "Sunday")
            {
                return 0;
            }
            return -1;
        }
        // Ham xu ly in lich
        public static void PrintCalendar(string dayOfWeekStart, int dayOfMonth)
        {
            int[,] calendar = new int[6, 7];
            int i = 0;
            int j = IndexOfDayInTheWeek(dayOfWeekStart);
            int day = 1;
            while (day <= dayOfMonth)
            {
                if (day > dayOfMonth) break;
                while (j < 7 & day <= dayOfMonth)
                {
                    calendar[i, j] = new int();
                    calendar[i, j] = day++;
                    j++;
                }
                j = 0;
                i++;
            }
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    try 
                    {
                        if (calendar[i, j] != 0) Console.Write(calendar[i, j] + "\t");
                        else Console.Write("\t");
                    }
                    catch
                    {
                        Console.WriteLine("IndexOutOfRangeException");
                    }
                    
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // Nhap du lieu
            Console.WriteLine("Hay nhap thang:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap nam:");
            int year = int.Parse(Console.ReadLine());

            // Khoi tao cac thu trong tuan, ngay dau tien trong tuan, so ngay trong thang
            string[] daysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            string dayOfWeekOfFirstDayInMonth = DayOfTheWeek(1, month, year);
            int dayOfMonth = DaysOfMonth(month, year);

            // In ra lich ket qua
            Console.WriteLine(string.Join("\t", daysOfWeek));
            PrintCalendar(dayOfWeekOfFirstDayInMonth, dayOfMonth);
        }
    }
}