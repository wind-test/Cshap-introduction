using System;

namespace HelloWorld
{
    // 基类：交通工具
    class Vehicle
    {
        public float Speed { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }

        public virtual void Run()
        {
            Console.WriteLine("该交通工具正在行驶");
        }
    }

    // 派生类：汽车
    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("汽车正在行驶");
        }
    }

    // 派生类：飞机
    class AirPlane: Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("飞机正在行驶");
        }
    }
}
