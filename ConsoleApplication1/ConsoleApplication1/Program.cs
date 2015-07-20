using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            while (true)
            {
                
                var num = rnd.Next(1337);
                Console.WriteLine(num);
                Thread.Sleep(10);
            }
        }
    }
}
