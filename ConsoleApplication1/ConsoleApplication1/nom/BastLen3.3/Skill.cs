using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.BastLen3._3
{
    class Skill
    {
        public int id;
        public int damage;
        public string name;
        public override string ToString()
        {
            return string.Format("Id:{0} damage:{1} name:{2}",id,damage,name);
        }
    }
}
