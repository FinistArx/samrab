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

            int first = 0;
            int next = 21;
            int[] random = { 19, 21, 1, 5, 5, 5, 6, 9, 13, 8 };

            Qsort(random, 0, random.Length - 1);
            for (int i = 0; i < random.Length; i++)
            {
                Console.WriteLine(random[i]);
            }
        }

        static void Qsort(int[] random, int first, int next)
        {
            int x = first;
            int y = next;
            int mid;
            if (next > first)
            {
                mid = random[(first + next) / 2];
                if (x <= y)
                {
                    while (x < next && (random[x] < mid))
                    {
                        x++;
                    }
                    while ((y > first) && (random[y] > mid))
                    {
                        --y;
                    }
                    if (x <= y)
                    {
                        int temp;
                        temp = random[x];
                        random[x] = random[y];
                        random[y] = temp;

                        ++x;
                        --y;
                    }

                    if (first < y)
                    {
                        Qsort(random, first, y);
                    }
                    if (x < next)
                    {
                        Qsort(random, x, next);
                    }
                }
            }
        }
    }
}