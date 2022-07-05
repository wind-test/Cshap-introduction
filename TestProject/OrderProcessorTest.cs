using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using System;

namespace TestProject
{
    [TestClass]
    public class OrderProcessorTest
    {
        // 被测方法_条件_期望结果
        [TestMethod]
        public void Process_OrderUnshiped_Add5RMB()
        {
            OrderProcessor orderProcess = new OrderProcessor(new FakeShippingCalculator());
            Order order = new Order
            {
                TotalPrice = 30f
            };
            orderProcess.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(order.ShipCost, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsShiped_ThrowException()
        {
            OrderProcessor orderProcess = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                TotalPrice = 30f
            };
            order.IsShipped = true;
            orderProcess.Process(order);
        }

        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 5;
            }
        }
    }
}
