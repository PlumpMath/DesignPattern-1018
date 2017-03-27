using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class OperationAdd:Operation
    {
        private double numberResult;
        public override double GetResult(double a,double b)
        {
            numberResult = a + b;
            return numberResult;
        }
    }
}
