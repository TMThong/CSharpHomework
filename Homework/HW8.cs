using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class HW8 : HW7
    {
        public override void Math()
        {
            MathString = $"{x} {(x.IsSquare() ? "" : "khong")} la so chinh phuong";
        }
    }
}
