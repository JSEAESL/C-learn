using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct CustomerName
    {
        public string firstName;
        public string endName;
        public string TotalName()
        {
            return firstName + endName;
        }
    }
    struct Vector3
    {
        public float x;
        public float y;
        public float z;
        public double distance()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }

    class Len11
    {
        static void Main(string[] args)
        {
            CustomerName cName;
            cName.firstName = "J";
            cName.endName = "Sea";
            Console.WriteLine("mu Name is " + cName.TotalName());

            Vector3 vec;
            vec.x = 3;
            vec.y = 4;
            vec.z = 5;
            Console.WriteLine(vec.distance());
            Console.ReadKey();
        }
    }
}
