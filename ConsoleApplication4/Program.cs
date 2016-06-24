using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числa");
            string temp = Console.ReadLine();
            int a = Convert.ToInt32(temp);
            Console.WriteLine("Введите числo");
            string temp1 = Console.ReadLine();
            int b = Convert.ToInt32(temp1);
            string temp2 = Console.ReadLine();
            int razmer = Convert.ToInt32(temp2);
            double[] random = new double[razmer];
            
         }


        static void Qsort(double[] random , ref int a, ref int b)
        {
            double mid ;
            int x = a ;
            int y = b ;
        


            if (a > b || b > a)
            {
                mid = random[(x + y) / 2];
                if (random[a] < mid && random[b] >= mid)
                {
                    x++;
                    y--;
                }
                else if (random[a] >= mid && random[b] < mid)
                {
                    y++;
                    x--;
                }

            }

            if (x < a)
            {
                Qsort( random, ref a, ref x);
            }
            if (y < b)
            {
                Qsort(random,ref b, ref y);
            }
        }

    }
}
