using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repro1
{
    public readonly struct S
    {
        public readonly int Field;
    }
    class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyList<object> list = new List<object>();
            var a = list.FirstOrDefault();
            Console.WriteLine("Hello World!");
        }
        public async void Test()
        {
            await Task.Delay(10);

        }
    }
}
