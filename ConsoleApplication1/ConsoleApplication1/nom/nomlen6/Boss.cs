using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen6
{
    class Boss:Enemy
    {
        public override void Move()
        {
            Console.WriteLine("这里是Boss的移动方法");
        }

        public void Attack()
        {
            Console.WriteLine("这是Boss的攻击");
        }
    }
}
