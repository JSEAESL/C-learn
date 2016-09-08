using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen5
{
    class nomLen5
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            boss.Move();
            boss.AI();
            boss.Attack();

            Enemy enemy;
            enemy = new Boss();
            enemy.Move();
            enemy.AI();

            Boss boss1 = (Boss)enemy;
            boss1.Attack();

            Enemy enemyOrg = new Enemy();

            enemyOrg.Move();
            enemyOrg.AI();
            Console.ReadKey();
        }
    }
}
