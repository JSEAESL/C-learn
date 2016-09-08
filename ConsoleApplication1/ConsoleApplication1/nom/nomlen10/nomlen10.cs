using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen10
{
    class nomlen10
    {
        static void Main(string[] args)
        {
            DerivedClass o1 = new DerivedClass();
            Console.WriteLine();

            DerivedClass o2 = new DerivedClass(11, 22);
            Console.WriteLine();

            BaseClass o11 = new BaseClass();

            Console.WriteLine();
            ClassXyz.z = 33;
            ClassXyz.TestMethmod();
            Console.ReadKey();
        }
    }
}
