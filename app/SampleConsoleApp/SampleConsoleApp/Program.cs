using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringFactory sf = new StringFactory();
            Console.WriteLine("Hello world!");
            Console.WriteLine("Hello world again!!");
            Console.WriteLine(GetSomething());
            Console.WriteLine(sf.CreateString("one"));
            Console.WriteLine(sf.CreateString("two"));
            Console.Read();
        }

        private static string GetSomething() => "Something";
    }
}
