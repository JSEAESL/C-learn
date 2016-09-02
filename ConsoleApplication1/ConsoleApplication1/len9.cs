using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class len9
    {
        static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        static int Plus(params int[] arr)
        {
            int sum = 0;
            for(int i = 0;i<arr.Length; i++)
            {
                sum += arr[i];
            }
                return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(new int[] { 22, 23423, 2342, 23423, 4234, 234 });
            Console.WriteLine(sum);

            int sum2 = Plus(22, 2323, 334, 3434, 34234, 234234, 23432);
            Console.WriteLine(sum2);
            Console.ReadKey();

        }
    }
}
