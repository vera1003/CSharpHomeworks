using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string t = "";
            int a, b;
            Console.Write("Please input one number:");
            s = Console.ReadLine();
            Console.Write("Please input another number:");
            t = Console.ReadLine();
            a = Int32.Parse(s);
            b = Int32.Parse(t);
            a = a * b;
            Console.WriteLine("a*b=" + a);

        }
    }
}
