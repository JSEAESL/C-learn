using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.nomlen12
{
    class nomlen12
    {
        static void Main(string[] args)
        {
            //List<int> scoreList = new List<int>();
            //var scoreList = new List<int>;

            var scoreList = new List<int>() { 1, 2, 3};

            Console.WriteLine("capacity" + scoreList.Capacity);
            Console.WriteLine("count" + scoreList.Count);
            scoreList.Add(12);
            Console.WriteLine("capacity" + scoreList.Capacity);
            Console.WriteLine("count" + scoreList.Count);
            scoreList.Add(45);
            Console.WriteLine("capacity" + scoreList.Capacity);
            Console.WriteLine("count" + scoreList.Count);
            Console.WriteLine(scoreList[0]);

            for(int i = 0;i<20;i++)
            {
                Console.WriteLine("capacity" + scoreList.Capacity);
                Console.WriteLine("count" + scoreList.Count);
                scoreList.Add(10);
            }
            Console.ReadKey();
        }

    }
}
