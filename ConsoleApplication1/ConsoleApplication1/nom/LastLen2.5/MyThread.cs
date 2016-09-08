using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.LastLen2._5
{
    class MyThread
    {
        private string fileName;
        private string filePath;
        public  MyThread(string fileName,string filePath)
        {
            this.fileName = fileName;
            this.filePath = filePath;
        }

        public void DownFile()
        {
            Console.WriteLine("start Down file Name:" + fileName + " path:" + filePath);
            Thread.Sleep(20000);
            Console.WriteLine("Down is complete");
        }

    }
}
