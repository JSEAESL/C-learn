using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen6
{
    class Enemy
    {
        public void AI()
        {
            Console.WriteLine("Enemy的AI");
            Move();
        }

        virtual public void Move()
        {
            Console.WriteLine("Enemy开始移动");
        }
    }
}
