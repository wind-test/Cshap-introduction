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

    public class MyNullable<T> where T : struct
    {
        public MyNullable() { }

        private object _value;

        public MyNullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            return default(T);
        }
    }

    public class AdvancedProgram
    {
        public T FindMax<T>(T a, T b) where T : IComparable, new()
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public static class StringExtension
    {
        public static string AddPrefix(this string s, string prefix)
        {
            return prefix + s;
        }
    }

    public class DynamicTest
    {
        public string Variable { get; set; }
        public void PrintTest()
        {
            Console.WriteLine("DynamicTest打印测试");
        }
    }

    public class StringMeta
    {
        public void Print(string msg)
        {
            Console.WriteLine($"来自元数据的打印: {msg}");
        }
    }

    public class DivNumbers
    {
        int result;
        public DivNumbers()
        {
            result = 0;
        }
        public void Divide (int number1, int number2)
        {
            try
            {
                result = number1 / number2;
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine($"Exception: {e}");
            }
            finally
            {
                Console.WriteLine($"Result: {result}");
            }
        }
    }

    public class Temperature
    {
        public float temperature { get; set; }
       
        public void ShowTemperature ()
        {
            if (temperature < -273.15)
            {
                throw (new TempUnderAbsolteZero("temperature is under absolute zero"));
            } else
            {
                Console.WriteLine($"Temperature: {temperature}");
            }
        }
    }

    public class TempUnderAbsolteZero: ApplicationException
    {
        public TempUnderAbsolteZero(string message) : base(message) { }
    } 
}
