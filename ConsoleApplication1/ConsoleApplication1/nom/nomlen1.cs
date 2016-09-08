using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom
{
    class nomlen1
    {
        static void Main(string[] args)
        {
            int num1, num2 = 0;
            Console.WriteLine("请输入数字");

            while(true)
            {
                try
                {
                    num1 = Convert.ToInt32( Console.ReadLine() );
                    break;
                }catch
                {
                    Console.WriteLine("输入错误");
                }
                //break
            }
            Console.WriteLine("请输入第二个数字");
            while(true)
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }catch
                {
                    Console.WriteLine("输入错误");
                }

            }
            int sum = num1 + num2;
            Console.WriteLine(sum);
            Console.ReadKey();


        }
    }
}
