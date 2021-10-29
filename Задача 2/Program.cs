using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\users\s.fedorovich\desktop\c#\занятие 8\Proba_pera.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(0, 10));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                int[] SummFile = File.ReadAllLines(path).Select(int.Parse).ToArray();
                int sum = SummFile.Sum();
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine("Сумма чисел в файле: {0}", sum);
            }
            Console.ReadKey();
        }
    }
}
