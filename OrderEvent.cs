using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class OrderItem {
        public int Id { get; set; }
        public DateTime dateTime { get; set; }  // 上架日期
        public bool IsShipped { get; set; } // 是否已经邮寄
        public DateTime ShipDate { get; set; } // 邮寄时间
        public float ShipCost { get; set; } // 邮寄费用
        public float TotalPrice { get; set; } // 总价
    }
    public class OrderProcessorEventArgs : EventArgs
    {
        public string Status { get; set; }
        public DateTime ProcessingTime { get; set; }
        public string Description { get; set; }
    }
    public delegate void OrderProcessEventHandler(OrderItem order, OrderProcessorEventArgs args);
    public class OrderEvent
    {
        private OrderProcessEventHandler _orderProcessEventHandler;
        public event OrderProcessEventHandler OrderProcessEvent
        {
            add
            {
                this._orderProcessEventHandler += value;
            }
            remove
            {
                this._orderProcessEventHandler -= value;
            }
        }
        public void Process(OrderItem order)
        {
            if (this._orderProcessEventHandler != null)
            {
                OrderProcessorEventArgs args = new OrderProcessorEventArgs
                {
                    Status = "complete",
                    ProcessingTime = DateTime.Now,
                    Description = "订单处理完成"
                };
                this._orderProcessEventHandler(order, args);
            }
        }
    }
    // 短信通知服务
    public class SmsServices
    {
        public static void OnOrderProcessed(OrderItem order, OrderProcessorEventArgs args)
        {
            Console.WriteLine($"发送短信，订单 {order.Id} , 处理结果: {args.Status}, 处理时间: {args.ProcessingTime}");
        }
    }
    public class EmailServices
    {
        public static void OnOrderProcessed(OrderItem order, OrderProcessorEventArgs args)
        {
            Console.WriteLine($"发送邮件，订单 {order.Id} , 处理结果: {args.Status}, 处理时间: {args.ProcessingTime}");
        }
    }

}
