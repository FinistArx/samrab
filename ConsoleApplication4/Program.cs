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
            int first = Convert.ToInt32(temp);
            Console.WriteLine("Введите числo");
            string temp1 = Console.ReadLine();
            int next = Convert.ToInt32(temp1);
            string temp2 = Console.ReadLine();
            int razmer = Convert.ToInt32(temp2);
            double[] random = new double[razmer];
            Qsort(random, 0, random.Length-1);

            for (int i = 0; i < random.Length; i++)
            {
                Console.WriteLine(random[i]);
            }
         }


        static void Qsort(double[] random ,  int first,  int next)
        {
            double mid ;
            int x = first;
            int y = next;



            if (first > next || next > first)
            {
                mid = random[(x + y) / 2];
                if (random[first] < mid )
                {
                    x++;
                }
                else if (random[first] > mid )
                {
                    x--;                
                }
                else if (random[next] > mid)
                {
                    y--;
                }
                else //( random[next] < mid)
                {
                    y++;
                }

            }
                if (x < first)
            {
                Qsort( random,  first,  x);
            }
            if (y < next)
            {
                Qsort(random, next,  y);
            }
        }
    }
}
