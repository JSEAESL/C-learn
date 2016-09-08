using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.LastLen2._5
{
    class LastLen25
    {
        static void DownLoadFile(object filename)
        {
            Console.WriteLine("start Down: " + Thread.CurrentThread.ManagedThreadId + filename);
            Thread.Sleep(20000);
            Console.WriteLine("Down Complete");
        }
        static void Main()
        {
            Thread t = new Thread(DownLoadFile);
            t.Start();
            Console.WriteLine("Main");

            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("start Down: " + Thread.CurrentThread.ManagedThreadId );
                Thread.Sleep(20000);
                Console.WriteLine("Down Complete");
            });
            t1.Start();

            Thread t2 = new Thread(DownLoadFile);
            t2.Start("xx.xxs");
            Console.WriteLine("Main");

            MyThread my = new MyThread("xxx.xx", "dasdasd");
            Thread t4 = new Thread(my.DownFile);
            t4.Start();
            Console.ReadKey();



        }
    }
}
