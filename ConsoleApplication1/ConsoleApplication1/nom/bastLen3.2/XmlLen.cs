using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1.nom.bastLen3._2
{
    class XmlLen
    {
        static void Main()
        {
            List<Skill> skillList = new List<Skill>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText("skill.xml"));
            XmlNode rootNode = xmlDoc.FirstChild;
            XmlNodeList skillNodeList = rootNode.ChildNodes;

            foreach(XmlNode  skillNode in  skillNodeList)
            {
                Skill skill = new Skill();
                XmlNodeList fieldNodeList = skillNode.ChildNodes;
                foreach (XmlNode fieldNode in fieldNodeList)
                {
                    if(fieldNode.Name == "id")
                    {
                        int id = Int32.Parse(fieldNode.InnerText);
                        skill.Id = id;
                    }else if(fieldNode.Name == "name")
                    {
                        string name = fieldNode.InnerText;
                        skill.Name = name;
                        skill.Lang = fieldNode.Attributes[0].Value;
                    }else
                    {
                        skill.Damage = Int32.Parse(fieldNode.InnerText);
                    }
                }
                skillList.Add(skill);
            }
            foreach (Skill tSkill in skillList)
            {
                Console.WriteLine(tSkill);
            }
            Console.ReadKey();
        }
    }
}
