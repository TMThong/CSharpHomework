using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 1
    /// </summary>
    public class THW1 : BaseHomework
    {
        protected int n;

        public override void Load()
        {
            n = "Nhap n:".rInt32Line();
        }

        public override void Math()
        {
            if (n <= 0)
            {
                this.MathString = "n be hon 1";
                return;
            }
            
            int S = 1;
            for(int i = 1; i <= n; i++)
            {
                S += i;
            }
            this.MathString = $"Tong S:{S}";
        }
    }
}
