using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);
            int i = 2;
            while (n >= i)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
                else
                {
                    i++;
                }

            }
            if (n != 1)
            {
                Console.WriteLine(n);
            }
        }
        }
   
}
