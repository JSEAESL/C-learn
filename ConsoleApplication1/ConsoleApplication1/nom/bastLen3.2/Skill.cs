using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.bastLen3._2
{
    class Skill
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Lang { get; set; }
        public int Damage { get; set; }
        public override string ToString()
        {
            return string.Format("Id:{0} Name:{1} Lang:{2} Damage{3}", Id, Name, Lang, Damage);
        }
    }
}
