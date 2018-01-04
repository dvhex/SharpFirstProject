using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FixNum fn = new FixNum(15);
            FixNum.Print(fn);
            FixNum fn2 = fn / new FixNum(7.0);
            FixNum.Print(fn2);
            Console.WriteLine(fn2 * new FixNum(7));
            Console.WriteLine(fn / fn2);
            Console.ReadLine();
        }
    }
}
