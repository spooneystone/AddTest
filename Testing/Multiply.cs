using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Multiply
    {
        int firstNumber, secondNumber;

        public Multiply(int _numberToMul1, int _numberToMul2)
        {
            firstNumber = _numberToMul1;
            secondNumber = _numberToMul2;
        }

        public int Result()
        {
            return firstNumber * secondNumber;
        }

    }
}
