using System;
using System.Collections.Generic;
using System.Data;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>
            {
                1,2,3,4,5,6
            };

            var res = Problems.divisibleSumPairs(6, 5, list.ToArray());
            Console.WriteLine($"{res}");
        }
    }
}
