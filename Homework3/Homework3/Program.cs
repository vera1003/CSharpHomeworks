using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCircle(8,'.');
            PrintRectangle(4,8);
            PrintSquare(4);
            
        }
       static void PrintCircle(int r, char s)
        {
            for(int i=0;i<r;i++)
            {
                int temp = (int)(2 * Math.Sqrt(2 * i * r - i * i));
                int t = 2 * r - temp - 1;
                for(int j=0;j<t;j++)
                {
                    Console.Write(" ");

                }
                Console.Write(s);
               
            }
            for (int i = r - 2; i >= 0; i--)
            {
                int temp = (int)(2 * Math.Sqrt(2 * i * r - i * i));
                int t = 2 * r - temp - 1;
                for (int j = 0; j < t; j++)
                {
                    Console.Write(" ");

                }
                Console.Write(s);
                for (int j=0;j<2*temp;j++)
                {
                    Console.WriteLine(s);
                }
            }
            double size = 3.14 * r * r;
            Console.WriteLine("圆形面积为：" + size);
        }
        static void PrintRectangle(int height, int width)
        {
            for (int i=1; i<=width;i++)
            {
                Console.Write(".");
            }
            Console.Write("/t");
            for(int j=1;j<=height;j++)
            {
                Console.Write(".");
                for (int i=1;j<width;j++)
                {
                    Console.Write(" ");
                }
                Console.Write(".");
                Console.Write("/t");
            }
            for (int i = 1; i <= width; i++)
            {
                Console.Write(".");
            }
            double size = height * width;
            Console.Write("矩形面积为：" + size);
        }
        static void PrintSquare(int width)
        {
            for (int i = 1; i <= width; i++)
            {
                Console.Write(".");
            }
            Console.Write("/t");
            for (int j = 1; j <= width; j++)
            {
                Console.Write(".");
                for (int i = 1; j < width; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(".");
                Console.Write("/t");
            }
            for (int i = 1; i <= width; i++)
            {
                Console.Write(".");
            }
            double size = width * width;
            Console.Write("正方形面积为：" + size);
        }
        

    }
    



}
