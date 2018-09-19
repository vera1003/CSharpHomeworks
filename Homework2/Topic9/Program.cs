using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=new int[101];
            for(int j=0;j<100;j++)
            {
               numbers[j] = j;
            }
            numbers[1] = 0;
            for(int i=2;i<=100;i++)
            {
                if(numbers[i]!=0)
                {
                    for(int j=i+1;j<=100;j++)
                    {
                        if(numbers[j]!=0&&numbers[j]%numbers[i]==0)
                        {
                            numbers[j] = 0;
                        }
                    }
                }
            }
            for(int i=2;i<=100;i++)
            {
                if(numbers[i]!=0)
                {
                    Console.Write(numbers[i]+" ");
                }
            }

            
            
        }
    }
}
