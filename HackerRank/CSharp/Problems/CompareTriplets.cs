using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace HackerRank.CSharp.Problems
{
    public class CompareTriplets : IProblem
    {
        public string Name => nameof(CompareTriplets);
        public string Url => "https://www.hackerrank.com/challenges/compare-the-triplets/problem";
        public void Run()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
        }

        public List<int> compareTriplets(List<int> a, List<int> b) {
        var resultado = new List<int> { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) resultado[0]++;
                if (b[i] > a[i]) resultado[1]++;
            }
            return resultado;
        }
    }

    public class CompareTripletsTests
    {
        [Theory]
        [MemberData(nameof(GetMemberDataTests))]
        public void CompareTriplets_MustPassAllTests(List<int> a, List<int> b, string expected){
            //Arrange
            var problem = new CompareTriplets();

            //Act
            var calculated = problem.compareTriplets(a, b);

            //Assert
            Assert.Equal(String.Join(" ", calculated), expected);
        }

        public static IEnumerable<object[]> GetMemberDataTests()
        {
            //n, k, bill list, b, expectedResult
            yield return new object[] { new List<int>{ 5, 6, 7 }, new List<int>{ 3, 6, 10 }, "1 1" };
            yield return new object[] { new List<int>{ 17, 28, 30 }, new List<int>{ 99, 16, 8 }, "2 1" };
        }
    }
}