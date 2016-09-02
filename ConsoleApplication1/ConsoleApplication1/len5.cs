using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class len5
    {
        static void Main(string[] arg)
        {
            string str = "123.3";
            double dou = Convert.ToDouble(str);

            int myNumber = 213213;
            string str2 = Convert.ToString(myNumber);
            string str3 = myNumber + "";

            Console.WriteLine(dou);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.ReadKey();

        }
    }
}
