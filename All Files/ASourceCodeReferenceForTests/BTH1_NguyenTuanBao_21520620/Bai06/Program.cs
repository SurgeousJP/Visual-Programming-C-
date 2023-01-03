using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System;

namespace Bai06
{
    internal class Program
    {
        public static void GenerateRandomArray(int n, int m, ref int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(0, 100);
                }
            }
        }
        public static void PrintArray(int n, int m, int[,] arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static int RowIndexWithLargestSum(int n, int m, int[,] arr)
        {
            int idx = 0;
            int LargestSumOfRow = 0;
            for (int i = 0; i < n; i++)
            {
                int sumOfRow = 0;
                for (int j = 0; j < m; j++)
                {
                    sumOfRow += arr[i, j];
                }

                if (i == 0)
                {
                    LargestSumOfRow = sumOfRow;
                }
                else
                {
                    if (LargestSumOfRow < sumOfRow)
                    {
                        idx = i;
                    }
                }
            }
            return idx;
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
        public static int SumOfNonPrimeNums(int n, int m, int[,] arr)
        {
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!isPrimeNumber(arr[i, j])) res += arr[i, j];
                }
            }
            return res;
        }
        public static void DeleteRow(ref int n, int m, ref int[,] arr, int k)
        {
            for (int i = k; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = arr[i + 1, j];
                }
            }
            n--;
        }

        public static void DeleteCol(int n, ref int m, ref int[,] arr, int l)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = l; j < m - 1; j++)
                {
                    arr[i, j] = arr[i, j + 1];
                }
            }
            m--;
        }

        public static int ColIdxContainsLargestValue(int n, int m, int[,] arr)
        {
        
            int max = arr[0, 0];
            int l = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        l = j;
                    }
                }
            }
            return l;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap so dong ma tran n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap so cot ma tran m:");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            GenerateRandomArray(n, m, ref arr);
            PrintArray(n, m, arr);
            Console.WriteLine("Hang co tong lon nhat la: " + RowIndexWithLargestSum(n, m, arr));
            Console.WriteLine("Tong cac so khong phai la nguyen to trong ma tran la: " + SumOfNonPrimeNums(n, m, arr));
            Console.WriteLine("Hay nhap hang thu k can xoa:");
            int k = int.Parse(Console.ReadLine());
            DeleteRow(ref n, m, ref arr, k);
            PrintArray(n, m, arr);
            int l = ColIdxContainsLargestValue(n, m, arr);
            Console.WriteLine("Cot co gia tri lon nhat: " + l);
            DeleteCol(n, ref m, ref arr, l);
            PrintArray(n, m, arr);
        }
    }
}
