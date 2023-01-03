using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System;

namespace Bai01
{
    internal class Program
    {
        public static void GenerateRandomArray(int n, ref int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
        }
        public static int SumOfOddNums(int n, int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        public static bool isPrimeNumber(int x)
        {
            if (x < 2) return false;
            if (x == 2 || x == 3) return true;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        public static int CountPrimeNumber(int n, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (isPrimeNumber(arr[i])) count++;
            }
            return count;
        }
        public static void PrintArray(int n, int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static bool isSquareNumber(int x)
        {
            return ((int)Math.Sqrt(x) == Math.Sqrt(x));
        }
        public static int SmallestSquareNumber(int n, int[] arr)
        {
            int res = -1;
            for (int i = 0; i < n; i++)
            {
                if (isSquareNumber(arr[i]))
                {
                    if (res == -1) res = arr[i];
                    else res = Math.Min(res, arr[i]);
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap kich co mang n:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Mang random duoc tao ra: ");
            GenerateRandomArray(n, ref arr);
            PrintArray(n, arr);
            Console.WriteLine("Tong cac so le trong mang la: " + SumOfOddNums(n, arr));
            Console.WriteLine("So cac so nguyen to trong mang la: " + CountPrimeNumber(n, arr));
            Console.WriteLine("So chinh phuong nho nhat trong mang la: " + SmallestSquareNumber(n, arr));
        }
    }
}
