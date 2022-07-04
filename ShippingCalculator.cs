using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // 普通日子运费计算类
    internal class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice > 50)
            {
                return 0;
            }
            else
            {
                return 15;
            }
        }
    }
}