using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // 手机短信信息服务
    public class SMSService : INotification
    {
        public void Send(string msg)
        {
            Console.WriteLine("手机短信发送中:" + msg);
        }
    }
}
