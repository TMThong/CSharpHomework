using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 12
    /// </summary>
    public class THW12 : BaseHomework
    {
        private int a;
        private int b;
        public override void Load()
        {
            a = "Nhap a:".rInt32Line();
            b = "Nhap b:".rInt32Line();
        }

        public override void Math()
        {
            int max = (a > b) ? a : b;
            for(int i = max; i >= 0; i--)
            {
                if(a % i == 0 && b % i == 0)
                {
                    this.MathString = $"Uoc so chung lon nhat giua {a} va {b} la:{i}";
                    return;
                }
            }
        }
    }
}
