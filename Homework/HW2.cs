using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class HW2 : BaseHomework
    {

        private double a, b, c, x;

        public override void Load()
        {
            a = "Nhập cạnh a:".rFloatLine();
            b = "Nhập cạnh b:".rFloatLine();
            c = "Nhập cạnh c:".rFloatLine();
            x = "Nhập cạnh x:".rFloatLine();
        }

        public override void Math()
        {
            double delta = System.Math.Pow(b, 2) - 4 * (a * c);
            if (delta > 0)
            {
                double x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);
                this.MathString = $"Phương trình có 2 nghiệm x1={x1},x2={x2}";
            }
            else if(delta < 0)
            {
                this.MathString = "Phương trình vô nghiệm";
            }
            else
            {
                double x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                this.MathString = $"Phương trình có 2 nghiệm kép = {x1}";
            }
        }
    }
}
