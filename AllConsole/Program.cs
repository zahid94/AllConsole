using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We live in an age of Science";
            
            Console.WriteLine(String.Concat(str.Where(c => !char.IsWhiteSpace(c))).ToLower());
        }
    }
}
