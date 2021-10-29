using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Занятие_8
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\s.fedorovich\Desktop\Мои документы");
            foreach (var item in directory.GetDirectories())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
