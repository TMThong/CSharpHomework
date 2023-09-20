using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class HW7 : BaseHomework
    {

        protected int x;

        public override void Load()
        {
            x = "Nhap x:".rInt32Line();
        }

        public override void Math()
        {
            MathString = $"{x} {(x.IsPrime() ? "" : "khong")} la so nguyen to";
        }
    }
}
