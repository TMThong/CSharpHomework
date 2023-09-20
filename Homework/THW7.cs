using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 7
    /// </summary>
    public class THW7 : THW3
    {
        public override void Math()
        {
            if (n <= 0)
            {
                this.MathString = "n be hon 1";
                return;
            }

            double S = 0;
            for (int i = 1; i <= n; i++)
            {
                S += System.Math.Pow(x, i);
            }
            this.MathString = $"Tong S:{S}";
        }
    }
}
