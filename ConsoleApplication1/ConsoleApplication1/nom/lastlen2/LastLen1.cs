using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.lastlen2
{
    class LastLen1
    {
        private static void Main()
        {
            var masterList = new List<MartialArtsMaster>()
            {
                new MartialArtsMaster() { Id = 1,Name = "黄蓉1",Age = 18,Menpai ="1丐帮",Kongfu = "打狗222棒法",Level = 19},
                new MartialArtsMaster() { Id = 4,Name = "黄蓉4",Age = 118,Menpai ="丐帮1",Kongfu = "打狗222棒法",Level = 29},
                new MartialArtsMaster() { Id = 6,Name = "黄蓉6",Age = 128,Menpai ="丐1帮",Kongfu = "打狗232棒法",Level = 39},
                new MartialArtsMaster() { Id = 10,Name = "黄蓉10",Age = 138,Menpai ="丐11帮",Kongfu = "打狗232棒法",Level = 49},
            };
            var kongfuList = new List<Kongfu>()
            {
                new Kongfu() {Id = 1, Name = "打狗1棒法", Power = 90},
                new Kongfu() {Id = 2, Name = "打狗11棒法", Power = 90},
                new Kongfu() {Id = 3, Name = "打1狗棒1法", Power = 100},
                new Kongfu() {Id = 4, Name = "打狗222棒法", Power = 100},
                new Kongfu() {Id = 5, Name = "打狗232棒法", Power = 100},
                new Kongfu() {Id = 6, Name = "打狗242棒法", Power = 100},
            };

            var res = new List<MartialArtsMaster>();
            foreach(var temp in masterList)
            {
                if (temp.Level > 8)
                res.Add(temp);
            }

            var res1 = from m in masterList
                       where m.Level > 9 && m.Menpai == "丐帮"
                       select m;
            foreach(var temp in res1)
            {
                Console.WriteLine(temp);
            }

            var res2 = masterList.Where(test1);
            foreach (var temp in res2)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();

            var res3 = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮");
            foreach(var temp in res2)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();

            var res4 = from m in masterList
                       from k in kongfuList
                       where m.Kongfu == k.Name && k.Power > 100
                       //select new {master = m, kongfu = k};  
                       select m;
            foreach(var temp in res4)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();
            //扩展方法用法  
            //var res =  
            //    masterList.SelectMany(m => kongfuList, (m, k) => new {master = m, kongfu = k})  
            //        .Where(x => x.master.Kongfu == x.kongfu.Name && x.kongfu.Power>90 );  

            //4,对查询结果做排序 orderby (descending)  
            var res5 = from m in masterList
                           //from后面设置查询的集合  
                       where m.Level > 8 && m.Menpai == "丐帮" //通过&&添加并列的条件  
                                                             //orderby m.Age descending  
                       orderby m.Level, m.Age //按照多个字段进行排序，如果字段的属性相同，就按照第二个属性排序  
                                              //where后面跟上查询的条件  
                       select m;//表示m的结果结合返回  
            foreach (var temp in res5)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();
            //5,join on 集合联合--on連接條件  
            var res6 = from m in masterList
                       join k in kongfuList on m.Kongfu equals k.Name
                       where k.Power == 100
                       select new { master = m, kongfu = k };
            foreach (var temp in res6)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();

            //6,分组查询 into groups (把武林高手按照所学功夫分类，看一下那个功夫修炼的人数最多)  
            var res7 = from k in kongfuList
                       join m in masterList on k.Name equals m.Kongfu
                       into groups
                       orderby groups.Count()
                       select new { kongfu = k, count = groups.Count() };
            foreach (var temp in res6)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();

            //7,量词操作符 any all 判断集合中是否满足某个条件  
            bool res8 = masterList.Any(m => m.Menpai == "长留");
            Console.WriteLine(res);
            Console.WriteLine();
            bool res9 = masterList.All(m => m.Menpai == "丐帮");
            Console.WriteLine(res);
            Console.WriteLine();


            Console.ReadKey();


        }

        static bool test1(MartialArtsMaster master)
        {
            if (master.Level > 9) return true;
            return false;
        }
    }
}
