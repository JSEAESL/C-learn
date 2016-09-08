using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen5
{
    class Boss:Enemy
    {
        public void Attack()
        {
            Move();
            AI();
            HP = 100;
            Console.WriteLine("Bosszhe正在攻击");
        }
    }
}
