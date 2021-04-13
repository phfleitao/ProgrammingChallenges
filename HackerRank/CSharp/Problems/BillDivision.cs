using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace HackerRank.CSharp.Problems
{
    public class BillDivision : IProblem
    {
        public string Name => nameof(BillDivision);
        public string Url => "https://www.hackerrank.com/challenges/bon-appetit/problem";
        public void Run()
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
            int b = Convert.ToInt32(Console.ReadLine().Trim());
            bonAppetit(bill, k, b);            
        }

        public void bonAppetit(List<int> bill, int k, int b) {
            var charged = b;
            var actual = (bill.Sum() - bill[k]) / 2;
            
            if(charged - actual == 0)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine((charged-actual).ToString());
        }
    }

    public class BillDivisionTests
    {
        [Theory]
        [MemberData(nameof(GetMemberDataTests))]
        public void BillDivision_MustPassAllTests(int n, int k, List<int> bill, int b, string expected){
            //Arrange
            var qtd = n; //Não utilizado, existe apenas para manter a ordem dos valores dos testes
            var problem = new BillDivision();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            //Act
            problem.bonAppetit(bill, k, b);

            //Assert
            Assert.Equal(consoleOutput.ToString(), expected + Environment.NewLine);
        }

        public static IEnumerable<object[]> GetMemberDataTests()
        {
            //n, k, bill list, b, expectedResult
            yield return new object[] { 4, 1, new List<int>{ 3, 10, 2, 9 }, 12, "5" };
            yield return new object[] { 4, 1, new List<int>{ 3, 10, 2, 9 }, 7, "Bon Appetit" };
        }
    }
}