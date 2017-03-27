using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Operation
    {
        private double numberA;
        private double numberB;
        private double numberResult;

        public double NumberA
        {
            get { return numberA; }
            set { numberA = value; }
        }

        public double NumberB
        {
            get { return numberB;  }
            set { numberB = value; }
        }

        public virtual double GetResult(double a,double b)
        {
            return numberResult;
        }
    }
}
