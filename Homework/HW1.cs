using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class HW1 : BaseHomework
    {
        private int a, b, c;

        public override void Load()
        {
            a = "Nhập cạnh a:".rInt32Line();
            b = "Nhập cạnh b:".rInt32Line();
            c = "Nhập cạnh c:".rInt32Line();
        }

        public override void Math()
        {

        }

       
    }
}
