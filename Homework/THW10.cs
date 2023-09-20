using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 10
    /// </summary>
    public class THW10 : THW9
    {
        public override void Math()
        {
            if (n <= 0)
            {
                this.MathString = "n be hon 1";
                return;
            }

            this.MathString = String.Empty;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && (i % 2 == 0))
                {
                    this.MathString += $" {i} ";
                }
            }
        }
    }
}
