using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen7
{
    class Boss:Enemy
    {
        public new void Move()
        {
            base.Move();
            Console.WriteLine("这是是Boss的移动");
        }
    }
}
