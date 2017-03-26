using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[][] a = new int[4][];

            for (int i = 0; i < 4; i++)
            {
                a[i] = new int[r.Next(6) + 1];
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = r.Next(10);
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine("---->" + a[i].Sum());
            }
            Console.WriteLine();

            BubbleSort.OrderBySumAsc(a);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine("---->" + a[i].Sum());
            }
            Console.ReadKey();
        }
    }
}
