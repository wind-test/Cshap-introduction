using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class OrderProcessor: IOrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        private readonly List<INotification> _notificationServices;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
            _notificationServices = new List<INotification>();
        }

        // 注册信息通知服务
        public void RegisterNotification(INotification notification)
        {
            _notificationServices.Add(notification);
        }


        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("订单已发货，无法重复处理");
            }
                
            order.ShipCost = _shippingCalculator.CalculateShipping(order);
            order.IsShipped = true;
            order.ShipDate = DateTime.Now;
            //Console.WriteLine($"订单#{order.Id}完成，已发货");
            Console.WriteLine($"订单#{order.Id}总价：{order.TotalPrice}");
            Console.WriteLine($"订单#{order.Id}运费：{order.ShipCost}");
            foreach (INotification notification in _notificationServices)
            {
                notification.Send($"订单#{order.Id}完成，已发货");
            }
        }
    }
}
