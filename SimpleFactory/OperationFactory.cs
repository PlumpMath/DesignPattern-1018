using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class OperationFactory
    {
        public static Operation CreateOperation(string strOperation)
        {
            Operation operation=null;
            switch (strOperation)
            {
                case "+":
                    operation=new OperationAdd();
                    break;
            }
            return operation;
        }
    }
}
