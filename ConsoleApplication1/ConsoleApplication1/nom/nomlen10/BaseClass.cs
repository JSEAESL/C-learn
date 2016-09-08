using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen10
{
    class BaseClass
    {
        private int x;
        protected int z;
        public BaseClass()
        {
            Console.WriteLine("base Class noArg");                
        }
        public BaseClass(int x)
        {
            this.x = x;
            Console.WriteLine("x = x_"); 
        }
    }
}
