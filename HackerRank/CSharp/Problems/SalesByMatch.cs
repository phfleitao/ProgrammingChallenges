using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace HackerRank.CSharp.Problems
{
    public class SalesByMatch : IProblem
    {
        public string Name => nameof(SalesByMatch);

        public string Url => "https://www.hackerrank.com/challenges/sock-merchant/problem";

        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
        }

        public int sockMerchant(int n, List<int> ar)
        {
            var pairsCount = ar.GroupBy(x => x)
                        .Select(o => 
                        new 
                        {
                            Value = o.Key, 
                            Count = o.Count()
                        })
                        .Sum(s => (int)(s.Count / 2));
            return pairsCount;
        }
    }

    public class SalesByMatchTests
    {
        [Theory]
        [MemberData(nameof(GetMemberDataTests))]
        public void SalesByMatchTests_MustPassAllTests(int n, List<int> ar, int expected){
            //Arrange
            var problem = new SalesByMatch();

            //Act
            var calculated = problem.sockMerchant(n, ar);

            //Assert
            Assert.Equal(calculated, expected);
        }

        public static IEnumerable<object[]> GetMemberDataTests()
        {
            //n, color socks list, expectedResult
            yield return new object[] { 7, new List<int>{ 1,2,1,2,1,3,2 }, 2 };
            yield return new object[] { 9, new List<int>{ 10,20,20,10,10,30,50,10,20 }, 3 };
            yield return new object[] { 10, new List<int>{ 1,1,3,1,2,1,3,3,3,3 }, 4 };
        }
    }
}