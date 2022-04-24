using System;
using ClassBasic;

namespace HelloWorld
{
    class Calculate
    {
        public int FindMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
        // 值传参定义
        public void swap(int x, int y)
        {
            int temp;
            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        // 引用传参
        public void swapByRef(ref int x, ref int y)
        {
            int temp;
            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        // 输出传参
        public void change(out int x, out int y)
        {
            x = 100;
            y = 200;
        }
    }

    internal class Program
    {
        public static void DrawPoint(dynamic point) => Console.WriteLine($"该点的坐标为：X - {point.x}  Y - {point.y}");
        static void Main(string[] args)
        {
            /** 1. 基础语法练习 **/
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello C#!");

            //Console.Write("Hello World!");
            //Console.Write("Hello C#!");

            //Console.WriteLine("请输入一个字符：");
            //int inputChar = Console.Read();
            //Console.WriteLine("输入的字符ASCII是：{0}", inputChar);

            //Console.WriteLine("请输入一个字符：");
            //ConsoleKeyInfo inputText = Console.ReadKey();
            //Console.WriteLine("\n输入的字符是：{0}", inputText.KeyChar);

            //Console.WriteLine("请输入字符串：");
            //string inputStr = Console.ReadLine();
            //Console.WriteLine("输入的字符串是：{0}", inputStr);

            //string name = "winddancer";
            //int age = 20;

            // 字符串格式化
            //string message = "my name is {0}. I am {1} years old";
            //string format_mesage = String.Format(message, name, age);
            //Console.WriteLine(format_mesage);

            // 字符串内插 $
            //string insert_message = $"my name is {name}. I am {age} years old";
            //Console.WriteLine(insert_message);

            // 原意字符串 @
            //string transfer_message = $"my name is {name}.\n I am {age} years old\n";
            //Console.WriteLine(transfer_message);
            //string original_message = @"my name is {name}.\n I am {age} years old\n";
            //Console.WriteLine(original_message);
            //string mixed_message = $@"my name is {name}.\n I am {age} years old\n";
            //Console.WriteLine(mixed_message);

            // 判断语句
            //Console.Write("请输入结果（Y/N）");
            //ConsoleKeyInfo bool_result = Console.ReadKey();
            //if (bool_result.KeyChar == 'Y')
            //{
            //    Console.WriteLine("\n你选择了是");
            //}else if (bool_result.KeyChar == 'N')
            //{
            //    Console.WriteLine("\n你选择了否");
            //}else
            //{
            //    Console.WriteLine("\n输入不合法");
            //}

            // 条件运算符
            //Console.Write("请输入结果（Y/N）");
            //ConsoleKeyInfo bool_result = Console.ReadKey();
            //string result_text = bool_result.KeyChar == 'Y' ? "\n你选择了是" : (
            //    bool_result.KeyChar == 'N' ? "\n你选择了否" : "\n输入不合法"
            //);
            //Console.WriteLine(result_text);

            // 循环语句
            //int number = 10;
            ///* do 循环执行 */
            //do
            //{
            //    if (number == 12)
            //    {
            //        /* 跳过迭代 */
            //        number = number + 1;
            //        continue;
            //    }
            //    Console.WriteLine("number的值： {0}", number);
            //    number++;
            //} while (number < 15);

            // 调用方法
            //Calculate calc = new Calculate();
            //int max_number = calc.FindMax(1, 2);
            //Console.WriteLine(max_number);

            //int number3 = 3;
            //int number4 = 4;
            //Calculate calc = new Calculate();
            //// 值传参调用
            //calc.swap(number3, number4);
            //Console.WriteLine("值传参后，number3的值: {0}，number4的值：{1}", number3, number4);
            //// 引用传参调用
            //calc.swapByRef(ref number3, ref number4);
            //Console.WriteLine("引用传参后，number3的值: {0}，number4的值：{1}", number3, number4);
            //// 输出传参调用
            //int number5, number6;
            //calc.change(out number5, out number6);
            //Console.WriteLine("输出传参后，number5的值: {0}，number6的值：{1}", number5, number6);

            /** 面向对象--基础 **/
            // 使用普通的方法画点
            //dynamic point = new { x = 100, y = 200};
            //DrawPoint(point);

            //dynamic point2 = new { x = "小明", y = "小华"};
            //DrawPoint(point2);

            //dynamic point3 = new { x = 300 };
            //DrawPoint(point3);

            // 使用Point类来创建坐标点
            //Point point4 = new Point();
            //point4.x = 10;
            //point4.y = 20;
            //point4.DrawPoint();

            //// 对象初始化值
            //Point point5 = new Point { x = 3, y = 4 };
            //point5.DrawPoint();

            //// 构造函数初始化值
            //Point point6 = new Point(3);
            //point6.DrawPoint();

            //// 构造函数初始化值 -- 重载
            //Point point7 = new Point(0, 0);
            //point7.DrawPoint();
            //Console.WriteLine($"两个坐标点之间的距离为{point7.getDistance(point5)}" );

            // 使用set,get方法操作成员变量
            //Point point8 = new Point(1, 2);
            //point8.DrawPoint();
            //point8.setX(3);
            //Console.WriteLine($"该坐标点的 X - {point8.getX()}");
            //point8.Y = 4;
            //Console.WriteLine($"该坐标点的 Y - {point8.Y}");
            //point8.Z = 5;
            //Console.WriteLine($"该坐标点的 Z - {point8.Z}");

            // 常量、readOnly和writeOnly
            //Point point9 = new Point();
            //Console.WriteLine($"常量 C - {Point.C}");
            //Console.WriteLine($"readOnly R - {point9.R}");
            //point9.W = 3;  // writeOnly只能赋值

            // index和range
            //Point point10 = new Point();
            //Console.WriteLine($"修改字符串数组第八位前：{point10[8]}");
            //Index index = ^1;
            //point10[index] = "cat";
            //Console.WriteLine($"修改字符串数组第八位后：{point10[index]}");
            //Console.WriteLine($"获取元素为cat所在的位置：{point10["cat"]}");

            //Range range = 1..7;
            //Console.WriteLine($"1到7为的元素为：{point10.printStrArray(range)}");

            // 设置partial类
            Point point11 = new Point();
            Console.WriteLine($"0到8为的元素为：{point11.printStrArray(0..8)}");
            point11.alternative = "end";
            point11.printAlternative();
        }
    }
}
