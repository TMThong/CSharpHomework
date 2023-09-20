using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 16
    /// </summary>
    public class THW16 : BaseHomework
    {

        protected int[,] matrix;

        public override void Load()
        {
            int col = "Nhap cot:".rInt32Line();
            int row = "Nhap hang:".rInt32Line();
            matrix = new int[col, row];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix[i, j] = $"Nhap matrix[{i},{j}]:".rInt32Line();
                }
            }
        }

        public override void Math()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (IsPrime(matrix[i, j]))
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            MathString = $"Tong so nguyen to:{sum}";
        }

        /// <summary>
        /// Là số nguyên tố
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPrime(int value)
        {
            if (value < 2) return false;

            for (int i = 2; i < value; i++)
            {
                if (value % 2 == 0) return false;
            }

            return true;
        }

    }
}
