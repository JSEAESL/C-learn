using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom
{
    class nomlen13
    {
        static void Main(string[]  args)
        {
            var scoreList = new List<int>();
            scoreList.Add(100);
            scoreList.Add(200);
            scoreList.Add(300);
            scoreList.Add(100);
            ConsolWrite(scoreList);


            scoreList.Insert(3, -1);
            ConsolWrite(scoreList);


            scoreList.RemoveAt(0);
            ConsolWrite(scoreList);

            int index = scoreList.IndexOf(400);
            Console.WriteLine(index);
            Console.WriteLine(scoreList.IndexOf(100));
            Console.WriteLine(scoreList.LastIndexOf(100));

            scoreList.Sort();
            ConsolWrite(scoreList);


            Console.ReadKey();

        }
        static void ConsolWrite(List<int> dim)
        {
            foreach(var temp in dim)
            {
                Console.WriteLine("temp: " + temp);
            }
            Console.WriteLine();
        }
    }
}
