using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cat
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get{ return name;}
            set { name = value; }
        }

        public delegate void CatShoutEventHandler(object sender,CatShoutEventArgs args);

        public event CatShoutEventHandler CatShout;

        public void Shout()
        {
            Console.WriteLine("喵，我是{0}.",name);
            if (CatShout != null)
            {
                CatShoutEventArgs e=new CatShoutEventArgs();
                e.Name = name;
                CatShout(this,e);
            }
        }
    }
}
