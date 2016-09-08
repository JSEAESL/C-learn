using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen14
{
    class ClassA<T,A>
    {
        private T a;
        private T b;
        private A c;
        public ClassA(T a, T b)
        {
            this.a = a;
            this.b = b;
        } 

        public string GetSum()
        {
            return a + "" + b;
        }
    }
}
