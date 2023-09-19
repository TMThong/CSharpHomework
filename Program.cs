using CSharpHomework.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpHomework.ThongExtension;
namespace CSharpHomework
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            SetUTF8Console();
            try
            {
                int homeworkId = "Nhập câu (nghĩa là câu số mấy):".rInt32Line();
                Type typeClassHomework = Type.GetType($"CSharpHomework.Homework.HW{homeworkId}");
                BaseHomework baseHomework = (BaseHomework)typeClassHomework.GetConstructor(new Type[] { }).Invoke(new object[] { });
                baseHomework.Load();
                baseHomework.Math();
                baseHomework.ToString().wLine();
            }
            catch
            (Exception ex)
            {
                "Bạn nhập sai cú pháp, ấn phím bất kỳ để kết thúc.".wLine();
            }
            Console.ReadKey();
        }
    }
}