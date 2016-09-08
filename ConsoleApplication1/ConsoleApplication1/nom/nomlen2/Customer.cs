using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen2
{

    class Customer
    {
        public string name;
        public string adress;
        public int age;
        public string buyTime;
        public void  show()
        {
            Console.WriteLine(name);
            Console.WriteLine(adress);
            Console.WriteLine(age);
            Console.WriteLine(buyTime);
        }    
    }
}
