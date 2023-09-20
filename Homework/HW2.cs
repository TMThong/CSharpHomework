using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class HW2 : BaseHomework
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
                this.MathString = $"Pt co 4 nghiem x1={System.Math.Pow(x1 , 2)},x2={System.Math.Pow(x2, 2)} , x3 ={x1}, x4 = {-x1}";
            }
            else if(delta < 0)
            {
                this.MathString = "Pt vo nghiem";
            }
            else
            {
                double x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                this.MathString = $"Pt co nghiem kep = {System.Math.Pow(x1, 2)}";
            }
        }
    }
}
