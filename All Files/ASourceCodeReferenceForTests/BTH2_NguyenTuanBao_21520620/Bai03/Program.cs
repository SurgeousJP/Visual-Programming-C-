

namespace Bai03
{
    internal class Program
    {
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
        
        // Ham nhap ma tran
        public static void InputArray(int[,] arr, int rows, int cols)
        {
            
            for (int i = 0; i < rows; i++)
            {
                string []input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = int.Parse(input[j]);
                }
            }
        }
        // Ham xuat ma tran
        public static void PrintArray(int[,] arr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
        // Xac dinh toa do cua mot gia tri cho san trong ma tran, neu khong tim thay thi tra ve chuoi khong tim thay
        public static string IndexOfAValueInArray(int[,] arr, int rows, int cols, int value)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i, j] == value)
                    {
                        return i.ToString() + ", " + j.ToString();
                        break;
                    }
                }
            }
            // If can't find the value
            return "Khong tim thay gia tri !!!";
        }
        public static void PrintPrimeNumbers(int[,] arr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (isPrimeNumber(arr[i, j])) Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // Ham tra ve index cua row co nhieu so nguyen to nhat, neu khong co hang nao co so nguyen to tra ve 0
        public static int RowIndexHasMostPrimeNumber(int[,] arr, int rows, int cols)
        {
            int maxNumOfPrimeNums = 0;
            int maxRow = -1;
            
            for (int i = 0; i < rows; i++)
            {
                int currMaxNumOfPrimeNums = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (isPrimeNumber(arr[i, j])) currMaxNumOfPrimeNums++;
                }
                if (currMaxNumOfPrimeNums > 0 && currMaxNumOfPrimeNums > maxNumOfPrimeNums)
                {
                    maxRow = i;
                    maxNumOfPrimeNums = currMaxNumOfPrimeNums;
                }
            }
            return maxRow;
        }
        static void Main(string[] args)
        {

            int[,] arr;
            int rows, cols;
            // Nhap ma tran va xuat ma tran cac so nguyen
            Console.WriteLine("Hay nhap so dong:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap so cot:");
            cols = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap ma tran:");
            arr = new int[rows, cols];
            InputArray(arr, rows, cols);
            Console.WriteLine("Ma tran da nhap la:");
            PrintArray(arr, rows, cols);

            // Tim kiem gia tri trong ma tran (tra ve toa do)
            int value;
            Console.WriteLine("Hay nhap gia tri can tim trong mang:");
            value = int.Parse(Console.ReadLine());
            Console.WriteLine("Toa do cua gia tri tren: " + IndexOfAValueInArray(arr, rows, cols, value));

            // Xuat cac so nguyen to co trong ma tran
            Console.WriteLine("Cac so nguyen to co trong ma tran:");
            PrintPrimeNumbers(arr, rows, cols);

            // Xuat index cua hang co nhieu so nguyen to nhat
            Console.WriteLine("Vi tri cua hang co nhieu so nguyen to nhat la: " + RowIndexHasMostPrimeNumber(arr, rows, cols));
        }
    }
}
