using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Len10
    {
        static void Write()
        {
            Console.WriteLine("let go");
            return;
        }

        static int plus(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static void Main(string[] args)
        {
            Write();
            int num1 = 100;
            int num2 = 200;
            int sum1 = plus(num1, num2);
            int sum2 = plus(1231, 123213);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.ReadKey();
        }
    }
}
