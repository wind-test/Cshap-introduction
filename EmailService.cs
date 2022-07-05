using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // 电子邮件信息服务
    public class EmailService : INotification
    {
        public void Send(string msg)
        {
            Console.WriteLine("电子邮件发送中:" + msg);
        }
    }
}
