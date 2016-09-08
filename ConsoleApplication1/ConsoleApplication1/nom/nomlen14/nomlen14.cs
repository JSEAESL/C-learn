using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen14
{
    class nomlen14
    {
        static void Main(string[] args)
        {
            var o2 = new ClassA<string,int>("WWW", "234e234.com");
            Console.WriteLine(o2.GetSum());
            Console.ReadKey();
        }
    }
}
