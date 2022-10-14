using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace domZad5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] at = { 1, 3, 6, 9, 4, 67, 37, 8 };
            Array.Sort(at);
            Console.WriteLine(String.Join(" ",at));
            Console.ReadKey();
        }
    }
}
