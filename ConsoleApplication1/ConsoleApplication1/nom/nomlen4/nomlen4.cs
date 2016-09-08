using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen4
{
    class nomlen4
    {
        static void Main(string[] args)
        {

            Test4();
            Test5();

            Console.ReadKey();
        }

        static void Test4()
        {
            Vector3 v = new Vector3();
            v.x = 100;
            v.y = 100;
            v.z = 100;

            Vector3 v2 = new Vector3();
            v2.x = 200;
            v2.y = 200;
            v2.z = 200;

            v2 = v;
            v2.x = 300;
            //300 100 100  
            Console.WriteLine(v.x);
            Console.WriteLine(v.y);
            Console.WriteLine(v.z);
            //300 100 100  
            Console.WriteLine(v2.x);
            Console.WriteLine(v2.y);
            Console.WriteLine(v2.z);
        }

        static void Test5()
        {
            len4Vector3[] vArray = new len4Vector3[] { new len4Vector3(), new len4Vector3(), new len4Vector3() };
            //如果数组是一个值类型的数组，那么数组中直接存储值，如果是一个引用类型的数组（数组中存储的是引用类型），那么数组中存储的是引用（内存地址） 
            len4Vector3 v1 = vArray[0];
            vArray[0].x = 300;
            v1.x = 200;
            Console.WriteLine(vArray[0].x);

        }
    }
}
