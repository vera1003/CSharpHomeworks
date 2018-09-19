using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 9, 10, 5, 4, 7, 6, 8, 2, 1 };
            int max = numbers[0];
            int min = numbers[0];
            double add = 0;
            double average = 0;
            for (int i=0; i<10;i++)
            {
                if (numbers[i] >= max)
                {
                    max = numbers[i];
                }
            }
            Console.Write("最大值为："+max+" ");
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i]<= min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("最小值为"+min);
            for(int i=0;i<10;i++)
            {
                add = add + numbers[i];
            }
            Console.WriteLine("和为" + add);
            average = add / 10;
            Console.WriteLine("平均值为" + average);
        }
    }
}
