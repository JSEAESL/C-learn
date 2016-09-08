using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom
{
    class nomLen15
    {
        public static string GetSum<T, T2, T3, T4>(T a,T b)
        {
            return a + " " + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum<int, int, int, int>(11, 22));
            Console.WriteLine(GetSum<double, double, double, double>(2.22, 3.33));
            Console.WriteLine(GetSum<string, string, string, string>("213232", "2wwww"));
            Console.ReadKey();
        }
    }
}
