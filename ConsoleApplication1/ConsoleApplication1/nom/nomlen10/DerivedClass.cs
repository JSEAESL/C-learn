using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen10
{
    class DerivedClass:BaseClass
    {
        private int y;
        public DerivedClass()
        {
            Console.WriteLine("DerivedClas no arg");
        }
        public DerivedClass(int x,int y):base(x)
        {
            this.y = y;
            base.z = 100;
            Console.WriteLine("y =y_");
        }
    }
}
