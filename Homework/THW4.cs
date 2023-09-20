using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 4
    /// </summary>
    public class THW4 : THW1
    {
        public override void Math()
        {
            if (n <= 0)
            {
                this.MathString = "n be hon 1";
                return;
            }

            double S = 1;
            for (int i = 1; i <= n; i++)
            {
                S += (2 * n) + 1;
            }
            this.MathString = $"Tong S:{S}";
        }
    }
}
