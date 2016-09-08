using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.LastLen2._2
{
    class lastLen22
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            Type type = myclass.GetType();
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.Assembly);

            FieldInfo[] array = type.GetFields();
            foreach (FieldInfo info in array)
            {
                Console.WriteLine(info.Name + " ");
            }
            Console.WriteLine();

            PropertyInfo[] array1 = type.GetProperties();
            foreach (PropertyInfo info in array1)
            {
                Console.WriteLine(info.Name + " ");
            }

            Console.WriteLine();

            MethodInfo[] arr3 = type.GetMethods();

            foreach(MethodInfo info in arr3)
            {
                Console.WriteLine(info.Name + " ");
            }

            Console.WriteLine();
            Console.ReadKey();

        }

    }
}
