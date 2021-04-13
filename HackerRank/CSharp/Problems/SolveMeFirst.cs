using System;
using Xunit;

namespace HackerRank.CSharp.Problems
{
    public class SolveMeFirst : IProblem
    {
        public string Name => nameof(SolveMeFirst);

        public string Url => "https://www.hackerrank.com/challenges/solve-me-first/problem";

        public void Run()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1,val2);
            Console.WriteLine(sum);
        }

        public int solveMeFirst(int a, int b) { 
            return a + b;
        }
    }

    public class SolveMeFirstTests
    {
        [Theory]
        [InlineData(2,3,5)]
        [InlineData(100,1000,1100)]
        public void SolveMeFirstTests_MustPassAllTests(int v1, int v2, int expectedSum){
            //Arrange
            var problem = new SolveMeFirst();

            //Act
            var calculatedSum = problem.solveMeFirst(v1, v2);

            //Assert
            Assert.Equal(calculatedSum, expectedSum);
        }
    }
}