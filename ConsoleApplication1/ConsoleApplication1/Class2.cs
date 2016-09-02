using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class len2
    {
        static void Main(string[] args)
        {
            //当在字符串前面加上一个@字符的时候，我们就可以把一个字符串定义在多行  
            // 编译器不会再去识别字符串中的转义字符  
            // 如果需要在字符串中表示一个双引号的话，需要使用两个双引号  
            String str1 = @"qweqwewqewqe
                    dasds";
            Console.WriteLine(str1);
            String str2 = @"qweqweqweqwe";
            Console.WriteLine(str2);

            //使用@字符的第二个好处  
            String path = @"c:\\qewqwe\\qweqwe";
            Console.WriteLine(path);
            String path2 = @"C:\dasdasa\dasd";
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
