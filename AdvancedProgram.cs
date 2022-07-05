using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    struct Game
    {
        public string name;
        public string developer;
        public DateTime releaseDate;

        public Game(string name, string developer, DateTime releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.releaseDate = releaseDate;
        }

        public void GetInfo()
        {
            Console.WriteLine($"游戏名称: {name}");
            Console.WriteLine($"开发: {developer}");
            Console.WriteLine($"上架日期: {releaseDate}");
        }
    }

    enum Weekday
    {
        MONDAY = 1,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY = 5,
        SATURDAY,
        SUNDAY
    }
    internal class AdvancedProgram
    {
    }
}
