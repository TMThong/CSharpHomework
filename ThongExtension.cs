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
            ShowCredit();
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
