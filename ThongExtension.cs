using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpHomework
{
    internal static class ThongExtension
    {
        public static void SetUTF8Console()
        {
            InputEncoding = Encoding.UTF8;
            OutputEncoding = Encoding.UTF8;

        }

        public static bool IsPrime(this int value)
        {
            if (value < 2) return false;

            for (int i = 2; i < value; i++)
            {
                if (value % 2 == 0) return false;
            }

            return true;
        }


        public static bool IsSquare(this int value)
        {
            return Math.Sqrt(value) % 1 == 0 && value > 0;
        }

        public static bool IsPerfectNumber(this int value)
        {
            if (value <= 0) return false;
            return false;
        }


        public static void wLine(this string text)
        {
            Console.WriteLine(text);
        }

        public static void w(this string text)
        {
            Console.Write(text);
        }

        public static string rLine(this string text)
        {
            text.w();
            return Console.ReadLine();
        }

        public static int rInt32Line(this string text)
        {
            return int.Parse(text.rLine());
        }

        public static float rFloatLine(this string text)
        {
            return float.Parse(text.rLine());
        }

        public static void ShowCredit()
        {
            "*****************************".wLine();
            "* Tác giả : Trần Minh Thông *".wLine();
            "*****************************\n".wLine();
            "/* Vui lòng không sửa tên nguyên tác */".wLine();
        }
    }
}
