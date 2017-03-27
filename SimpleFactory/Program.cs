using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入第一个运算数字A：");
                string a = Console.ReadLine();
                Console.WriteLine("请输入第二个运算数字B：");
                string b = Console.ReadLine();
                Console.WriteLine("请输入运算符号（+，-，*，/）：");
                string strOperation = Console.ReadLine();
                string strResult = "";
                Operation operation =OperationFactory.CreateOperation(strOperation);
                strResult=operation.GetResult(Convert.ToDouble(a), Convert.ToDouble(b)).ToString();
                Console.WriteLine("运算结果是：{0}", strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("你输入的有错："+ex.Message);
            }
            
        }
    }
}
