using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    delegate double mydelegate(double par1, double par2);
    class len13
    {
        static double multiply(double par1,double par2)
        {
            return par1 * par2;
        }
        static double divide(double par1, double par2)
        {
            return par1 / par2;
        }

        static void Main(string[] args)
        {
            mydelegate de;
            de = multiply;
            Console.WriteLine(de(2.0,34.1));
            de = divide;
            Console.WriteLine(de(2.0, 34.1));
            Console.ReadKey();

        }
    }
}
