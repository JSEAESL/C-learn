using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.LastLen2._6
{
    class Lastlen26
    {
        static void ThreadMethod(object state)
        {
            Console.WriteLine("Thread start " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(20000);
            Console.WriteLine(" Thread end ");
        }

        static void TaskMethod()
        {
            Console.WriteLine("task Start");
            Thread.Sleep(20000);
            Console.WriteLine("task End");
        }

        static void Main()
        {
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);

            Task t = new Task(TaskMethod);
            t.Start();

            TaskFactory tf = new TaskFactory();
            tf.StartNew(TaskMethod);
            Console.ReadKey();

        }

    }
}
