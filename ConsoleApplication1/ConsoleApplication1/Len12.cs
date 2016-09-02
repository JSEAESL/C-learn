using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Len12
    {
        static int MaxValue(params int[] arr)
        {
            Console.WriteLine("int MAX_VALUE");
            int max = arr[0];
            for (int i = 1;i<arr.Length; i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static double MaxValue(params double[] arr)
        {
            Console.Write("double MAX_VLAUE ");
            double max = arr[0];
            for (int i = 1;i<arr.Length;i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            int intMax = MaxValue(123, 21321, 321321, 3213, 21321);
            double douMax = MaxValue(3213.4, 23423.234, 234234.2);
            Console.WriteLine("intMAX " + intMax);
            Console.WriteLine("douMAX " + douMax);
            Console.ReadKey();

        }
    }
}
