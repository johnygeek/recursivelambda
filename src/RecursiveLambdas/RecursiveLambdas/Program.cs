using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> fact = null;
            fact = (n) => n == 1 ? 1 : n * fact(n - 1);
            Console.WriteLine(fact(5));
            Console.ReadKey();
        }
    }
}
