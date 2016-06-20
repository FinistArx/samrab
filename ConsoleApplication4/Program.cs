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
        }
        void Qsort(double[] random, int a, int b)
        {
            double mid;
            int x = a;
            int y = b;

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
                Qsort(random,  a,  x);
            }
            if (y < b)
            {
                Qsort(random,  b,  y);
            }
            
             
        }
    }
}
