using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "fsfsffff";
            string b = "dsjdjss";
            string c = a + b;
            char[] list = c.ToCharArray() ;

            var any = c.Distinct() ;
        }
    }
}
