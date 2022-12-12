using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection19Task
{
    public class ConcreteCalculator : ICalculator
    {
        public int CalcData(int x, int y, char op)
        {
            if (op.Equals('+'))
            {
                return x + y;
            }
            else
            if (op.Equals('-'))
            {
                return x - y;
            }
            else
            if (op.Equals('*'))
            {
                return x * y;
            }
            else
            if (x != 0 && y != 0)
            {
                return x / y;
            }
            throw new DivideByZeroException();

        }
    }
}
