using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Divide
    {
        int firstNumber, secondNumber;

        public Divide(int _numberToDiv1, int _numberToDiv2)
        {
            firstNumber = _numberToDiv1;
            secondNumber = _numberToDiv2;
        }

        public int Result()
        {
            return firstNumber / secondNumber;
        }

    }
}
