using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.lastLen1
{
    class lastLen2
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder("baidu.com");
            StringBuilder sb2 = new StringBuilder(20);
            StringBuilder sb3 = new StringBuilder("baidu.com", 20);
            sb1.Append("/dsds.html");
            Console.WriteLine(sb1.ToString());
            sb1.Insert(0, "http://");
            Console.WriteLine(sb1);

            sb1.Remove(0, 5);
            Console.WriteLine(sb1);
            sb1.Replace('.',' ');
            Console.WriteLine(sb1);
            Console.ReadKey();
        }
    }
}
