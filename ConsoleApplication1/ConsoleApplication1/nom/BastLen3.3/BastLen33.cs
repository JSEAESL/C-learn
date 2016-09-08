using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.BastLen3._3
{
    class BastLen33
    {
        static void Main(string[] agr)
        {
            List<Skill> skillList = new List<Skill>();
            string skillJson = File.ReadAllText("skill.txt");
            JsonData jsdata = JsonMapper.ToObject(skillJson);

            foreach (JsonData temp in jsdata)
            {
                Skill skill = new Skill();
                JsonData idValue = temp["id"];
                JsonData nameValue = temp["name"];
                JsonData damageValue = temp["damage"];
                skill.id = Int32.Parse(idValue.ToString());
                skill.name = nameValue.ToString();
                skill.damage = Int32.Parse(damageValue.ToString());
                skillList.Add(skill);

            }

            foreach (Skill temp in skillList)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();

            Skill[] skillArr = JsonMapper.ToObject<Skill[]>(File.ReadAllText("skill.txt"));
            foreach( Skill temp in skillArr)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine();

            List<Skill> skillList1 = JsonMapper.ToObject<List<Skill>>(File.ReadAllText("skill.txt"));
            foreach(Skill temp in skillList1)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine();

            Player p = JsonMapper.ToObject<Player>(File.ReadAllText("json.txt"));
            foreach (Skill temp in p.SkillList)
            {
                Console.WriteLine(temp);
            }

            Player p1 = new Player();
            p1.Name = "aa";
            p1.Age = 18;
            p1.Level = 18;
            string json = JsonMapper.ToJson(p1);
            Console.WriteLine(json);
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
