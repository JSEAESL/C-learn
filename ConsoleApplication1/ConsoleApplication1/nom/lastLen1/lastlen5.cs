using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.lastLen1
{
    class lastlen5
    {
        static int Test1()
        {
            return 1;
        }

        static int Test2(string str)
        {
            Console.WriteLine(str);
            return 100;
        }

        static int Test3(int a,string b, int c)
        {
            Console.WriteLine(b);
            return a + c;
        }

        static void Main()
        {
            Func<int> t1 = Test1;
            Console.WriteLine(t1);
            Func<string,int>t2 = Test2;
            Console.WriteLine(t2("11"));
            Func<int, string, int, int> t3 = Test3;
            Console.WriteLine(t3(23, "asd", 213213));
            Console.ReadKey();

        }
    }
}
