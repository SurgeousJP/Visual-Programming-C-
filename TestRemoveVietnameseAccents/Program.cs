// See https://aka.ms/new-console-template for more information
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Globalization;
using System.Text;
using Diacritics;

public class HelloWorld
{
    public static class ConstantAccentsForVietnameseLetters
    {
        static string[] UpperCaseLetterA = { "Ả", "Á", "À", "Ã", "Ạ", "Â", "Ấ", "Ầ", "Ẫ", "Ậ", "Ă", "Ắ", "Ằ", "Ẵ", "Ặ" };
        static string[] LowerCaseLetterA = { "à", "á", "ạ", "ả", "ã", "â", "ầ", "ấ", "ậ", "ẩ", "ẫ", "ă", "ằ", "ắ", "ặ", "ẳ", "ẵ" };
        static string[] UpperCaseLetterE = { "Ẻ", "É", "È", "Ẽ", "Ẹ", "Ê", "Ế", "Ề", "Ễ", "Ệ", "Ể"};
        static string[] LowerCaseLetterE = { "è", "é", "ẹ", "ẻ", "ẽ", "ê", "ề", "ế", "ệ", "ể", "ễ" };
        static string[] UpperCaseLetterI = { "Ỉ", "Í", "Ì", "Ĩ", "Ị" };
        static string[] LowerCaseLetterI = { "ì", "í", "ị", "ỉ", "ị"};
        static string[] UpperCaseLetterO = { "O", "Ó", "Ò", "Õ", "Ọ", "Ô", "Ố", "Ồ", "Ỗ", "Ộ", "Ơ", "Ớ", "Ờ", "Ỡ", "Ợ"};
        static string[] LowerCaseLetterO = { "ò", "ó", "ọ", "ỏ", "õ", "ô", "ồ", "ố", "ộ", "ộ", "ơ", "ờ", "ớ", "ợ", "ở", "ỡ" };
    }

    private static readonly string[] VietnameseSigns = new string[]
        {

            "aAeEoOuUiIdDyY",

            "áàạảãâấầậẩẫăắằặẳẵ",

            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

            "éèẹẻẽêếềệểễ",

            "ÉÈẸẺẼÊẾỀỆỂỄ",

            "óòọỏõôốồộổỗơớờợởỡ",

            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

            "úùụủũưứừựửữ",

            "ÚÙỤỦŨƯỨỪỰỬỮ",

            "íìịỉĩ",

            "ÍÌỊỈĨ",

            "đ",

            "Đ",

            "ýỳỵỷỹ",

            "ÝỲỴỶỸ"
        };

    public static string RemoveSign4VietnameseString(string str)
    {
        for (int i = 1; i < VietnameseSigns.Length; i++)
        {
            for (int j = 0; j < VietnameseSigns[i].Length; j++)
            {
                str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
                Console.WriteLine(VietnameseSigns[i][j] + " " + VietnameseSigns[0][i - 1]);
            }
                
            
        }
        return str;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap chuoi:");
        string input = Console.ReadLine();
        string output = RemoveSign4VietnameseString(input);
        Console.WriteLine("Chuoi ket qua: " + output);
    }

}
