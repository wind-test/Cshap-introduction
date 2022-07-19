using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HelloWorld
{
    public class EventSubscriber
    {
        public void AlarmEventHandler(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("闹钟响了，再睡一会");
        }
    }
    public class MyRoomMate
    {
        private int temperament = 20; 
        public void AlarmEventHandler(object sender, ElapsedEventArgs e)
        {
            temperament += 20;
            if (temperament >= 100)
            {
                Console.WriteLine("受不了了，关闭闹钟");
                Timer timer = (Timer)sender;
                timer.Stop();
            } 
            else
            {
                Console.WriteLine("闹钟响了，我不管");
            } 
        }
    }
}
