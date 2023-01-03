using System.IO;
namespace Bai02
{
    internal class Program
    {
        // In ten tat ca file trong thu muc chi boi duong dan
        public static void PrintAllFiles(string[] files)
        {
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(Path.GetFileName(files[i]));

            }
        }
        // In ten tat ca thu muc trong thu muc chi boi duong dan
        public static void PrintAllDirectories(string[] directories)
        {
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine(Path.GetFileName(directories[i]));
            }
        }
        static void Main(string[] args)
        {
            // Nhap duong dan
            Console.WriteLine("Hay nhap duong dan:");
            string filePath = Console.ReadLine();
            // Lay duong dan tat ca cac file va folder
            string[] getFiles = Directory.GetFiles(filePath);
            string[] getDirectories = Directory.GetDirectories(filePath);
            // In ket qua
            PrintAllFiles(getFiles);
            PrintAllDirectories(getDirectories);
        }

    }
}

