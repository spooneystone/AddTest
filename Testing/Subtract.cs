using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Subtract
    {
        int firstNumber, secondNumber;

        public Subtract(int _numberToSub1, int _numberToSub2)
        {
            firstNumber = _numberToSub1;
            secondNumber = _numberToSub2;
        }

        public int Result()
        {
            return firstNumber - secondNumber;
        }

    }
}
