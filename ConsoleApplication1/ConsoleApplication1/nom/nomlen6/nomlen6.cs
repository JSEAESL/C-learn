using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen6
{
    class nomlen6
    {
        static void Main(string[] ags)
        {
            Boss boss = new Boss();
            boss.AI();
            boss.Attack();
            Console.WriteLine();

            Enemy enemy = new Enemy();
            enemy.AI();
            enemy.Move();
            Console.ReadKey();
        }
    }
}
