using System;
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
        static void Main(string[] args)
        {
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

            string name = "winddancer";
            int age = 20;

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

            int number3 = 3;
            int number4 = 4;
            Calculate calc = new Calculate();
            // 值传参调用
            calc.swap(number3, number4);
            Console.WriteLine("值传参后，number3的值: {0}，number4的值：{1}", number3, number4);
            // 引用传参调用
            calc.swapByRef(ref number3, ref number4);
            Console.WriteLine("引用传参后，number3的值: {0}，number4的值：{1}", number3, number4);
            // 输出传参调用
            int number5, number6;
            calc.change(out number5, out number6);
            Console.WriteLine("输出传参后，number5的值: {0}，number6的值：{1}", number5, number6);
        }
    }
}
