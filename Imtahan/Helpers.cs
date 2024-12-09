using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtahan
{
    public static class Helpers
    {
        public static void Print()
        {
            Console.WriteLine("bos print");
        }
        public static void Print(string a)
        {
            Console.WriteLine($" string tipinde metod");
        }
        public static void Print(int a, string b)
        {
            Console.WriteLine($"int ve string tipli print metodu");
        }
    }
}
