using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
