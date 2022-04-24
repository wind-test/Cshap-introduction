using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasic
{
    public partial class Point
    {
        public string alternative { get; set; }

        public void printAlternative()
        {
            Console.WriteLine($"打印来自partial类的 alternative - {alternative}");
        }
    }
}
