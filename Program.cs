using System;
using ClassBasic;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

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

    // 基类 Shape
    class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Shape()
        {
            this.Height = 10;
            this.Width = 10;
        }

        public Shape(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public void displayAttr()
        {
            Console.WriteLine($"Shape的高是：{Height}, 宽是：{Width}");
        }
        
    }

    // 派生类 Rectangle
    class Rectangle: Shape
    {
        public Rectangle(int height, int width): base(height, width) { }
        public Rectangle() { }
        public int getArea()
        {
            int area = this.Height * this.Width;
            Console.WriteLine($"Rectangle的面积是：{area}");
            return area;
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

            /** 2.面向对象--基础 **/
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
            //Point point11 = new Point();
            //Console.WriteLine($"0到8为的元素为：{point11.printStrArray(0..8)}");
            //point11.alternative = "end";
            //point11.printAlternative();

            /** 3.面向对象--继承、组合 **/
            // 继承的用法
            //Rectangle rect = new Rectangle();
            //rect.Height = 10;
            //rect.Width = 20;
            //rect.getArea();

            // 继承类的构造函数初始化
            //Rectangle rect1 = new Rectangle(20, 30);
            //rect1.displayAttr();

            // 复合的用法
            //Logger logger = new Logger();
            //DbMigrator dbMigrator = new DbMigrator(logger);
            //Installer installer = new Installer(logger);
            //installer.Install();
            //dbMigrator.Migrate();

            // 类型转换：
            // 向上转型
            //Rectangle rect2 = new Rectangle(20, 30);
            //Shape shape2 = rect2;
            //shape2.displayAttr();
            //// 向下转型
            //Shape shape3 = new Shape();
            //Rectangle rect3 = (Rectangle)shape3; // 会抛出异常
            ////使用as关键词来向下转型
            //Rectangle rect4 = shape3 as Rectangle;
            //if (rect4 != null)
            //{
            //    rect4.getArea(); // rect4是null,不会执行代码
            //}
            //// 使用is关键词来向下转型
            //if (shape3 is Rectangle)
            //{
            //    Rectangle rect5 = (Rectangle)shape3;
            //    rect5.getArea();
            //}
            // 类型转化的实际应用场景
            //var arrays = new List<Shape>();
            //arrays.Add(new Shape(10, 10));
            //arrays.Add(new Rectangle(20, 20));

            //arrays.ForEach(i => { 
            //    if (i is Rectangle)
            //    {
            //        var tmp = i as Rectangle;
            //        tmp.getArea();
            //    } else
            //    {
            //        i.displayAttr();
            //    }
            //});

            // 装箱与拆箱
            //int num = 2022;
            //Object obj = num;
            //Console.WriteLine($"装箱前的数据为：{obj}");
            //int num1 = (int)obj;
            //Console.WriteLine($"拆箱后的数据为：{num1}");

            // 虚方法与方法重写
            //var vehicleList = new List<Vehicle>();
            //vehicleList.Add(new Vehicle());
            //vehicleList.Add(new Car());
            //vehicleList.Add(new AirPlane());
            //foreach (var vehicle in vehicleList)
            //{
            //    vehicle.Run();
            //}

            // 抽象类
            //var vehicleList = new List<Vehicle>();
            //// 抽象类本身是不能创建实例的
            //vehicleList.Add(new Car());
            //vehicleList.Add(new AirPlane());
            //foreach (var vehicle in vehicleList)
            //{
            //    vehicle.Run();
            //}

            /** 4.面向对象--接口 **/
            // 接口的使用--订单及运费计算系统
            //Order order = new Order
            //{
            //    Id = 00001,
            //    dateTime = new DateTime(2022, 6, 30),
            //    TotalPrice = 30,
            //    IsShipped = false,
            //};
            //IShippingCalculator shippingCalculator;
            //if (DateTime.Today == new DateTime(2022, 11, 11))
            //{
            //    shippingCalculator = new SaleShippingCalculator();
            //}
            //else
            //{
            //    shippingCalculator = new ShippingCalculator();
            //}
            //OrderProcessor orderProcessor = new OrderProcessor(shippingCalculator);
            //orderProcessor.Process(order);

            // 控制反转与依赖注入
            //Order order_2 = new Order
            //{
            //    Id = 3,
            //    dateTime = new DateTime(2022, 6, 30),
            //    TotalPrice = 30,
            //    IsShipped = false,
            //};
            //ServiceCollection collection = new ServiceCollection();
            //collection.AddScoped<IOrderProcessor, OrderProcessor>();
            //collection.AddScoped<IShippingCalculator, SaleShippingCalculator>();

            //IServiceProvider serviceProvider = collection.BuildServiceProvider();
            //IOrderProcessor orderProcessor = serviceProvider.GetService<IOrderProcessor>();
            //orderProcessor.Process(order_2);

            // 接口的多态性
            //Order order_3 = new Order
            //{
            //    Id = 4,
            //    dateTime = new DateTime(2022, 6, 30),
            //    TotalPrice = 30,
            //    IsShipped = false,
            //};
            //IShippingCalculator shippingCalculator = new SaleShippingCalculator();
            //OrderProcessor orderProcessor = new OrderProcessor(shippingCalculator);

            //INotification emailService = new EmailService();
            //INotification smsService = new SMSService();
            //orderProcessor.RegisterNotification(emailService);
            //orderProcessor.RegisterNotification(smsService);
            //orderProcessor.Process(order_3);

            /** 5. C# 高级编程 **/
            // 结构体
            //Game game = new Game("Zelda", "Nintendo", new DateTime(2017, 3, 3));
            ////game.name = "Zelda";
            ////game.developer = "Nintendo";
            ////game.releaseDate = new DateTime(2017, 3, 3);
            //game.GetInfo();

            // 枚举
            //Weekday firday = Weekday.FRIDAY;

            //Console.WriteLine(firday);
            //Console.WriteLine((int)firday);

            //var firday2 = (Weekday)4;
            //Console.WriteLine(firday2);

            //Weekday day = Weekday.MONDAY;

            //switch (day)
            //{
            //    case Weekday.MONDAY:
            //    case Weekday.TUESDAY:
            //    case Weekday.WEDNESDAY:
            //    case Weekday.THURSDAY:
            //    case Weekday.FRIDAY:
            //        Console.WriteLine("今天要上班");
            //        break;
            //    case Weekday.SUNDAY:
            //    case Weekday.SATURDAY:
            //        Console.WriteLine("家里蹲");
            //        break;
            //}

            // 泛型
            GenericList<int> list_1 = new GenericList<int>(3);
            list_1.SetIem(1,0);
            list_1.SetIem(2,1);
            list_1.SetIem(3,2);
            Console.WriteLine($"list_1第二个元素 {list_1[1]}");
            GenericList<string> list_2 = new GenericList<string>(3);
            list_2.SetIem("a",1);
            list_2.SetIem("b",2);
            list_2.SetIem("c",3);
            Console.WriteLine($"list_2第二个元素 {list_2[1]}");

            AdvancedProgram utility = new AdvancedProgram();
            var max = utility.FindMax('a', 1);
            Console.WriteLine($"最大值为： {max}");
        }
    }
}
