using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.bestLen3._1
{
    class Best3
    {
        static void Main()
        {
            FileInfo fileInfo = new FileInfo(@"F://temp//other.txt");
            Console.WriteLine(fileInfo.Exists);//判断该文件是否存在  

            Console.WriteLine(fileInfo.Name);//文件名.后缀  

            Console.WriteLine(fileInfo.Directory);//取得文件所在路径  

            Console.WriteLine(fileInfo.Length);//取得文件大小  

            Console.WriteLine(fileInfo.IsReadOnly);//文件是否可读  
            fileInfo.CopyTo("ccc.txt");
            fileInfo.Delete();
            Console.WriteLine(fileInfo.Exists);

            FileInfo fileInfo2 = new FileInfo(@"F://temp//new.txt");
            if(fileInfo2.Exists == false)
            {
                fileInfo2.Create();
            }

            Console.WriteLine();

            DirectoryInfo dirInfo = new DirectoryInfo(@"F://temp");
            Console.WriteLine(dirInfo.Exists);
            Console.WriteLine(dirInfo.Name);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.CreationTime);
            dirInfo.CreateSubdirectory("newTemp");

            DirectoryInfo dirInfo2 = new DirectoryInfo("test");
            if (dirInfo2.Exists == false)
            {
                dirInfo2.Create();//创建目录  
            }


            Console.ReadKey();

        }
    }
}
