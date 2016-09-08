using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.lastLen1
{
    class lastLen7
    {
        static void Main()
        {
            Func<int, int, int> plus1 = delegate (int a1, int a2)
              {
                  return a1 + a2;
              };
            Func<int, int, int> plus2 = (a1, a2) =>
             {
                 return a1 + a2;
             };
            Console.WriteLine(plus1(11, 22));
            Console.WriteLine(plus2(70,606));

            Func<int, int> test2 = a => a + 1;
            Func<int, int> test3 = (a) =>
             {
                 return a + 1;
             };
            Console.WriteLine(test2(1));
            Console.WriteLine(test3(3));
            Console.ReadKey();
        }
    }
}
