using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public class HW5 : HW3
    {
        public override void Math()
        {
            int[] arr = new int[this.n.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(n.ElementAt(i) + "");
            }
            MathString = $"Chu so dau tien nguyen duong la:{arr.Where(p => p > 0).First()}";
        }
    }
}
