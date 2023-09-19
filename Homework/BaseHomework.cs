using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework.Homework
{
    public abstract class BaseHomework
    {
        public abstract void Load();
        public abstract void Math();
        public override string ToString()
        {
            return MathString;
        }

        public string MathString = "Ops!!! Chương trình chưa tính toán !!!";
    }
}
