using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingAndWritingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading and writing files");

            string test;
            test = System.IO.File.ReadAllText("test.txt");
            Console.WriteLine(test);

            Console.ReadKey(true);
        }
    }
}
