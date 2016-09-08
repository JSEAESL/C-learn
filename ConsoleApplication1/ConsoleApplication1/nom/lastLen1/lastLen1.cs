using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.lastLen1
{
    class lastLen1
    {
        static void Main(string[] args)
        {
            string s = "www.baidu.com";
            int len = s.Length;
            if(s == "www.baidu.com")
            {
                Console.WriteLine("==");
            }else
            {
                Console.WriteLine("!=");
            }

            if(s.Equals("www.baidu.com"))
            {
                Console.WriteLine("Equals");
            }

            Console.WriteLine(len);
            Console.WriteLine();


            s = "http://" + s;
            Console.WriteLine(s);
            char Char = s[3];
            Console.WriteLine(Char);

            for(int i = 0;i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine();

            string s1 = "www.baidu.com 2 1 3 2 3";
            Console.WriteLine(s.CompareTo(s1));

            string newS = s1.Replace('.', '-');
            Console.WriteLine(s1);
            Console.WriteLine(newS);

            string[] stringS1= s1.Split('.');
            foreach(string  temp in stringS1)
            {
                Console.WriteLine();
                Console.WriteLine(temp);
            }
            string str = s1.Substring(4);
            Console.WriteLine(str);

            string str1 = s1.ToUpper();
            Console.WriteLine(str1);
            string str2 = s1.Trim();
            Console.WriteLine(str2);

            int index = s1.IndexOf("baidu");

            Console.WriteLine(index);

            Console.ReadKey();
        }
    }
}
