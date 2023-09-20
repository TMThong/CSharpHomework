using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 5
    /// </summary>
    public class THW5 : THW1
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
                S += n * (n  + 1) * (n + 2); 
            }
            this.MathString = $"Tong S:{S}";
        }
    }
}
