using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen8
{
    class nomlen8
    {
        static void Main(string[] args)
        {
            crow Crow = new crow();
            Crow.fly();

            bird Bird = new crow();
            Bird.fly();

            crow c = (crow)Bird;
            c.fly();
            Console.ReadKey();
        }
    }
}
