using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasic
{
    internal class ClassBasic
    {
    }

    public partial class Point
    {
        private float x;
        public float getX()
        {
            return this.x;
        }
        public void setX(float value)
        {
            this.x = value;
        }

        private float y;
        public float Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public float Z { get; set; }

        // 常量
        public const int C = 0;

        // 只读字段
        public readonly int R;

        // 只写字段
        private int w;
        public int W { set { this.w = value; } }

        // 字符串数组
        private string[] _g = new string[]
        {
        // index from start index from end
	        "The",  // 0     ^9
	        "quick", // 1     ^8
	        "brown", // 2     ^7
	        "fox",  // 3     ^6
	        "jumped", // 4     ^5
	        "over",  // 5     ^4
	        "the",  // 6     ^3
	        "lazy",  // 7     ^2
	        "dog"  // 8     ^1
        };

        public string this[Index index]
        {
            get { return _g[index]; }
            set { _g[index] = value; } 
        }

        public int this[string str]
        {
            get { return Array.IndexOf(_g, str); }
        }

        public string printStrArray(Range range)
        {
            String str = "";
            var list = _g[range];
            for (int i = 0; i < list.Length; i++)
            {
                str = str + $"{list[i]} ";
            }
            return str;
        }

        public void DrawPoint()
        {
            Console.WriteLine($"改点的坐标为：X - {x}, Y - {this.y}");
        }
        // 构造函数 -- 接受两个参数
        public Point(float x, float y) 
        {
            this.x = x;
            this.y = y;
        }

        // 构造函数 -- 重载：只接受一个参数x
        public Point(float x)
        {
            this.x = x;
        }

        // 构造函数 -- 重载：不接受参数，为了支持对象初始化值
        public Point() {
            R = 1;
            W = 2;
        }

        public double getDistance(Point point)
        {
            return Math.Sqrt(Math.Pow(x - point.x, 2) + Math.Pow(this.y - point.y, 2));
        }
    }
}
