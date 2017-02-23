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
            Add add = new Add(10,5);

          Console.WriteLine(add.Result());
            Console.ReadKey();
        }
    }
}
