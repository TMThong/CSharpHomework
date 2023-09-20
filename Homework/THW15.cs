using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 15
    /// </summary>
    public class THW15 : BaseHomework
    {
        private double a, b, c;

        public override void Load()
        {
            a = "Nhap a:".rFloatLine();
            b = "Nhap b:".rFloatLine();
            c = "Nhap c:".rFloatLine();
        }

        public override void Math()
        {
            double delta = System.Math.Pow(b, 2) - 4 * (a * c);
            if (delta > 0)
            {
                double x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);
                this.MathString = $"Pt co 2 nghiem x1={x1},x2={x2}";
            }
            else if (delta < 0)
            {
                this.MathString = "Pt vo nghiem";
            }
            else
            {
                double x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                this.MathString = $"Pt co nghiem kep = {x1}";
            }
        }
    }
}
