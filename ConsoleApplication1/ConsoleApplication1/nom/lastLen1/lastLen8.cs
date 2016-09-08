using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.lastLen1
{
    class lastLen8
    {
        public delegate void MyDelegate();
        public event MyDelegate mydelegate;
        static void Main()
        {
            lastLen8 p = new lastLen8();
            p.mydelegate = Test;
            p.mydelegate();
            Console.Read();
        }
        static void Test()
        {
            Console.WriteLine("test");
        }
    }
}
