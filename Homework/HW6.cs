using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class HW6 : BaseHomework
    {
        private int a, b;
        public override void Load()
        {
            a = "Nhap a:".rInt32Line();
            b = "Nhap b:".rInt32Line();
        }

        public override void Math()
        {
            int max = (a > b) ? a : b;
            for (int i = max; ; i += max)
            {
                if (i % a == 0 &&  i % b == 0)
                {
                    MathString = $"BCNN la {i}";
                    break;
                }
            }
        }
    }
}
