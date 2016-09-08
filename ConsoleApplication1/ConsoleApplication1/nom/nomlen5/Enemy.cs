using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen5
{
    class Enemy
    {
        private float hp;
        private float speed;
        public float HP
        {
            set
            {
                hp = value;
            }
            get
            {
                return hp;
            }
        }

        public float Speed
        {
            set
            {
                speed = value;
            }
            get
            {
                return speed;
            }
        }

        public void AI()
        {
            Console.Write("这是敌人的AI");
        }
        public void Move()
        {
            Console.WriteLine("开始移动");
        }

    }
}
