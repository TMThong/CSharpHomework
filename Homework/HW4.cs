using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class HW4 : BaseHomework
    {
        private int n;

        public override void Load()
        {
            n = "Nhap n:".rInt32Line();
        }

        public override void Math()
        {
            int num = 0;
            for(int i = 1; i < n;i ++)
            {
                if(i % 2 == 0 && n % i ==0)
                {
                    num++;
                }
            }
            MathString = $"So luong uoc so chan la:{num}";
        }
    }
}
