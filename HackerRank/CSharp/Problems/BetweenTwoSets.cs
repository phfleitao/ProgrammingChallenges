using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace HackerRank.CSharp.Problems
{
    public class BetweenTwoSets : IProblem
    {
        public string Name => nameof(BetweenTwoSets);
        public string Url => "https://www.hackerrank.com/challenges/between-two-sets/problem";
        public void Run()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();
            int total = getTotalX(arr, brr);
            Console.WriteLine(total);
        }

        public int getTotalX(List<int> a, List<int> b)
        {
            var fullList = a.Concat(b);
            var max = fullList.Max();
            var min = fullList.Min();
            var result = 0;

            for (int i = max; i >= min; i--)
            {
                if (a.All(x => i % x == 0) && b.All(x => x % i == 0))
                {
                    result++;
                }
            }

            return result;
        }
    }

    public class BetweenTwoSetsTests
    {
        [Theory]
        [MemberData(nameof(GetMemberDataTests))]
        public void BetweenTwoSets_MustPassAllTests(List<int> a, List<int> b, int expected)
        {
            //Arrange
            var problem = new BetweenTwoSets();

            //Act
            var result = problem.getTotalX(a, b);

            //Assert
            Assert.Equal(result, expected);
        }

        public static IEnumerable<object[]> GetMemberDataTests()
        {
            //a list, b list, expectedResult
            yield return new object[] { new List<int> { 2, 6 }, new List<int> { 24, 36 }, 2 };
            yield return new object[] { new List<int> { 2, 4 }, new List<int> { 16, 32, 96 }, 3 };
        }
    }
}