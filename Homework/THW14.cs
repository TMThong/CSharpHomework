using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class THW14 : BaseHomework
    {
        private float a, b;

        public override void Load()
        {
            a = "Nhap a:".rFloatLine();
            b = "Nhap b:".rFloatLine();
        }

        public override void Math()
        {
            float x = -b / a;
            MathString = $"Gia tri x: {x}";
        }
    }
}
