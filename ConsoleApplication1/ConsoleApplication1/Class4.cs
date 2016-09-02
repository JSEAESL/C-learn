using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class4
    {
        static void Main()
        {
            Console.WriteLine("输入第一个数字");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            Console.WriteLine("输入第二个数字");
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);

            int result = num1 + num2;
            Console.WriteLine("答案是");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
