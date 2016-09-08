using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.LastLen2._3
{
    [MyTest("简单特性类",Id = 100)]
    class LastLen23
    {
        //1、obsolete特性用来表示一个方法被弃用了  
        [Obsolete("这个方法过时了，使用NewMethod代替")]
        static void OldMethod()
        {
            Console.WriteLine("OldMethod");
        }

        static void NewMedthod()
        {

        }

        //2、定义宏  
        [Conditional("IsTest")]
        static void test1()
        {
            Console.WriteLine("test1");
        }
        static void test2()
        {
            Console.WriteLine("test2");
        }

        static void Main(string[] args)
        {
            OldMethod();
            NewMedthod();

            test1();
            test2();
            test1();

            Type type = typeof(LastLen23);
            object[] array = type.GetCustomAttributes(false);
            MyTestAttribute mytest = array[0] as MyTestAttribute;
            Console.WriteLine(mytest.Description);
            Console.WriteLine(mytest.Id);
            Console.ReadKey();

        }
    }
}
