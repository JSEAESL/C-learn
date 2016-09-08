using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.lastLen1
{
    class lastlen3
    {
        private delegate string getAString();
        static void Main(string[] args)
        {
            int x = 40;
            getAString a = new getAString(x.ToString);
            string s = a.Invoke();
            Console.WriteLine(s);

            PrintString Method = method1;
            PrintStr(Method);
            Method = method2;
            PrintStr(Method);
            Console.ReadKey();
        }

        private delegate void PrintString();
        static void PrintStr(PrintString print)
        {
            print();
        }
        static void method1()
        {
            Console.WriteLine("method1");
        }
        static void method2()
        {
            Console.WriteLine("method2");
        }
    }
}
