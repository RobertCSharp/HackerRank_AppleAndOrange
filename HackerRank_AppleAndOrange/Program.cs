using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            countApplesAndOranges(2, 3, 1, 5 , new List<int> {2} , new List<int> {-2});
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int counterApples = 0;
            int counterOranges = 0;

            foreach (var app in apples)
            {
                int distanceApp = a + app;
                if (distanceApp >= s  && distanceApp <= t)
                {
                    counterApples++;
                }
            }

            foreach (var org in oranges)
            {
                int distanceOrg = b + org;
                if (distanceOrg >= s && distanceOrg <= t)
                {
                    counterOranges++;
                }
            }
            Console.WriteLine(counterApples);
            Console.WriteLine(counterOranges);
        }
    }
}
