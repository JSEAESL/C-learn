using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen7
{
    class nomLen7
    {
        static void Main(string[] args)
        {
            Enemy en = new Enemy();
            en.Move();
            Console.WriteLine();

            Enemy enemy = new Boss();
            enemy.Move();
            Console.WriteLine();

            Boss bos = (Boss)enemy;
            bos.Move();
            Console.WriteLine();

            Boss boss = new Boss();
            boss.Move();
            Console.WriteLine();

        }
    }
}
