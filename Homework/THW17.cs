using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 17
    /// </summary>
    public class THW17 : THW16
    {
        public override void Math()
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                this.MathString = "Khong phai ma tran vuong";
                return;
            }


            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
                sum += matrix[matrix.GetLength(0) - i - 1, i];
            }

            MathString = $"Tong so nguyen to:{sum}";
        }
    }
}
