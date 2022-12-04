using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            res = a + b;
            Console.WriteLine($"{a}+{b}={res}");
            res = a - b;
            Console.WriteLine($"{a}-{b}={res}");
            Console.ReadKey();
        }
    }
}
