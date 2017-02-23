using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Add add = new Add(10, 5);

            Subtract sub = new Subtract(4, 2);

            Multiply multi = new Multiply(5,5);

            Squared Squ = new Squared(15);

            Console.WriteLine(add.Result());
            Console.WriteLine(sub.Result());
            Console.WriteLine(multi.Result());
            Console.WriteLine(Squ.Result());
            Console.ReadKey();
        }
    }
}
