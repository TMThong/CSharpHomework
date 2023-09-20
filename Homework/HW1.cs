using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class HW1 : BaseHomework
    {
        private int a, b, c;

        public override void Load()
        {
            a = "Nhap canh a:".rInt32Line();
            b = "Nhap canh b:".rInt32Line();
            c = "Nhap canh c:".rInt32Line();
        }

        public override void Math()
        {
            if (a == b && b == c) MathString = "Tam giac deu";
            else if ((a == b || b == c || c == a) && (System.Math.Pow(a, 2) == System.Math.Pow(b, 2) + System.Math.Pow(c, 2)) || (System.Math.Pow(c, 2) == System.Math.Pow(b, 2) + System.Math.Pow(a, 2)) || (System.Math.Pow(b, 2) == System.Math.Pow(a, 2) + System.Math.Pow(c, 2))) MathString = "Tam giac vuong can";
            else if (a == b || b == c || c == a) MathString = "Tam giac can";
            else if ((System.Math.Pow(a, 2) == System.Math.Pow(b, 2) + System.Math.Pow(c, 2)) || (System.Math.Pow(c, 2) == System.Math.Pow(b, 2) + System.Math.Pow(a, 2)) || (System.Math.Pow(b, 2) == System.Math.Pow(a, 2) + System.Math.Pow(c, 2))) MathString = "Tam giac vuong";
            else MathString = "Tam giac thuong";
        }
    }
}
