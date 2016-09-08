using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.lastLen1
{
    class Lastlen6
    {
        static void Test()
        {
            Console.WriteLine("test1");
        }

        static void Test1()
        {
            Console.WriteLine("test2");
        }

        static void Main()
        {
            Action a = Test;
            a += Test1;
            if (a != null)
            {
                a();
            }
            Delegate[] delegates = a.GetInvocationList(); 
            foreach ( Delegate fun in delegates )
            {
                fun.DynamicInvoke();
            }
            Console.ReadKey();
        }

    }
}
