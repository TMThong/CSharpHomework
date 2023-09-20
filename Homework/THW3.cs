using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    /// <summary>
    /// Author - Trần Minh Thông
    /// Bài 3
    /// </summary>
    public class THW3 : BaseHomework
    {
        protected int x;
        protected int n;
        public override void Load()
        {
            x = "Nhap x:".rInt32Line();
            n = "Nhap n:".rInt32Line();
        }

        public override void Math()
        {
            this.MathString = $"Ket qua T la:{System.Math.Pow(x, n)}";
        }
    }
}
