using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System;

namespace Bai02
{
    internal class Program
    {
        public static bool isPrimeNumber(int x)
        {
            if (x < 2) return false;
            if (x == 2 || x == 3) return true;
            for (int i = 2; i*i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        public static int SumOfPrimeNumbers(int n)
        {
            int sum = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrimeNumber(i))
                {
                    sum += i;
                }
                
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen duong n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong cac so nguyen to be hon n: " + SumOfPrimeNumbers(n));

        }
    }
}