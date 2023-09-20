using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class THW8 : THW7
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
                S += (System.Math.Pow(x, i)) / GiaiThua(i);
            }
            this.MathString = $"Tong S:{S}";
        }
        /// <summary>
        /// Thuật toán giai thừa
        /// Dùng đệ quy
        /// </summary>
        /// <param name="n">Số gia thừa</param>
        /// <returns>Kết quả giai thừa</returns>
        public static double GiaiThua(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * GiaiThua(n - 1);
        }
    }
}
