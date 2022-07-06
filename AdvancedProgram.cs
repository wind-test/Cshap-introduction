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

    public class GenericList<T>
    {
        private T[] list;

        public GenericList(int size)
        {
            list = new T[size + 1];
        }

        public void SetIem(T item, int index)
        {
            list[index] = item;
        }

        public T this[int index] 
        { 
            get { return list[index]; } 
        }
    }

    public class AdvancedProgram
    {
        public T FindMax<T>(T a, T b) where T : IComparable, new()
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
