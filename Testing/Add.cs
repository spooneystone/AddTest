using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Add
    {
        int firstNumber, secondNumber;

        public Add(int _numberToAdd1, int _numberToAdd2)
        {
            firstNumber = _numberToAdd1;
            secondNumber = _numberToAdd2;
        }

        public int Result()
        {
            return firstNumber + secondNumber;
        }

    }
}
