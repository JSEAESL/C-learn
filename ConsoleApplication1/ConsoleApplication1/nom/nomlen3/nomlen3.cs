using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen3
{
    class nomlen3
    {
        static void Main(string[] Args)
        {
            Vector3 v3 = new Vector3();
            v3.SetX(1);
            v3.SetY(1);
            v3.SetZ(1);

            Console.WriteLine(v3.Length());
            Console.WriteLine();
            Vector3 v31 = new Vector3(1, 1, 1);
            v31.MyIntProperty = 233;
            int temp = v31.MyIntProperty;
            Console.WriteLine(temp);
            Console.WriteLine();

            v3.X = 100;
            Console.WriteLine(v3.X);
            Console.WriteLine(v3.getX());
            Console.ReadKey();
        }
    }
}
