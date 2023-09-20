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
    public class THW6 : THW1
    {
        /// <summary>
        /// Ước là khi a = 28 và b là 1 số 28 chia hết cho b mà b bé hơn 28
        /// Đã test
        /// </summary>
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
                if(n % i == 0)
                {
                    this.MathString += $" {i} ";
                }
            }
        }
    }
}
