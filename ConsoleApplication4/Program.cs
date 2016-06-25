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
            Qsort(random, 0, random.Length-1);

            for (int i = 0; i < random.Length; i++)
            {
                Console.WriteLine(random[i]);
            }
         }


        static void Qsort(double[] random ,  int a,  int b)
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
                Qsort( random,  a,  x);
            }
            if (y < b)
            {
                Qsort(random, b,  y);
            }
        }
    }
}
