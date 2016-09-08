using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen2
{
    class nomlen2
    {
        static void Main(string[] args)
        {
            Customer Custome1;
            Custome1 = new Customer();
            Custome1.name = "J";
            Custome1.age = 26;
            Console.WriteLine(Custome1.name);
            Custome1.show();
            Console.ReadKey();
        }
    }
}
