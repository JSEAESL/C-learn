using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.lastLen1
{
    class lastLen4
    {
        static void PrintString(string str)
        {
            Console.WriteLine(str);
        }

        static void PrintInt(int Int)
        {
            Console.WriteLine(Int);
        }

        static void PrintString()
        {
            Console.WriteLine("hello World");
        }

        static void PrintDoubleInt(int a1, int a2)
        {
            Console.WriteLine(a1 + a2);
        }

        static void Main(string[] args)
        {
            Action a1 = PrintString;
            Action<int> a2 = PrintInt;
            Action<string> a3 = PrintString;
            Action<int, int> a4 = PrintDoubleInt;
            a1();
            a2(111);
            a3("wewe233");
            a4(33, 55);
            Console.ReadKey();
        }
    }
}
