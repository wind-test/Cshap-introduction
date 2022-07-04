using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime dateTime { get; set; }  // 上架日期
        public bool IsShipped { get; set; } // 是否已经邮寄
        public DateTime ShipDate { get; set; } // 邮寄时间
        public float ShipCost { get; set; } // 邮寄费用
        public float TotalPrice { get; set; } // 总价
    }
}