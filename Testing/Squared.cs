using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Squared
    {
        int number;

        public Squared(int _numberToSquare)
        {
            number = _numberToSquare;
        }
        public int Result()
        {
            return number * number;
        }
    }
}
