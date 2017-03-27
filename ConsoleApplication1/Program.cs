using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Cat cat=new Cat("Tom");
            Mouse mouse1=new Mouse("Jerry");
            Mouse mouse2=new Mouse("Jack");

            cat.CatShout += mouse1.Run;
            cat.CatShout += mouse2.Run;

            cat.Shout();

            Console.ReadLine();
        }
    }
}
