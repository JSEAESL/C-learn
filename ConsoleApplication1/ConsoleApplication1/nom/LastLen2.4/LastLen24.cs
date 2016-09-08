using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.LastLen2._4
{
    class LastLen24
    {
        static int Test(int i,string str)
        {
            Console.WriteLine("Thread " + i + " " + str);
            Thread.Sleep(100);
            return 100;
        }
        static void Test1(int i)
        {
            Console.WriteLine("Test1  " + i);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Action<int> aa = Test1;
            aa.BeginInvoke(100, null, null);
            Console.WriteLine("Main");

            Func<int,string,int> a = Test;
            IAsyncResult ar = a.BeginInvoke(100, "siki", null, null);
            Console.WriteLine("Main");

            bool IsEns = ar.AsyncWaitHandle.WaitOne(1);

            if(IsEns)
            {
                int res3 = a.EndInvoke(ar);
                Console.WriteLine(" int res3 = a.EndInvoke(ar);  " + res3);
            }else
            {
                Console.WriteLine("no end");
            }

            while(ar.IsCompleted == false)
            {
                Console.WriteLine(".");
                Thread.Sleep(10);
            }
            int res = a.EndInvoke(ar);
            Console.WriteLine("a.EndInvoke(ar) +" + res);
            Console.WriteLine();

            Func<int, string, int> aFunc = Test;
            aFunc.BeginInvoke(100, "siki,", Callback, aFunc);
            Console.WriteLine();

            Func<int, string, int> aFunc1 = Test;
            aFunc1.BeginInvoke(100, "siki", ar11 =>
              {
                  if (ar11.IsCompleted == true)
                  {
                      int res1 = aFunc1.EndInvoke(ar11);
                      Console.WriteLine("在表达式中获得状态: " + res1);
                  }
              }
            , null);

            Console.ReadKey();
        }
        static void Callback(IAsyncResult ar)
        {
            Func<int, string, int> a = ar.AsyncState as Func<int, string, int>;
            if(ar.IsCompleted == true)
            {
                int res = a.EndInvoke(ar);
                Console.WriteLine(res + "callBack get Res");
            }

        }

    }
}
