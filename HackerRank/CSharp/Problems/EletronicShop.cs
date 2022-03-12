using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace HackerRank.CSharp.Problems
{
    public class EletronicShop : IProblem
    {
        public string Name => nameof(EletronicShop);
        public string Url => "https://www.hackerrank.com/challenges/electronics-shop/problem";
        public void Run()
        {
            string[] bnm = Console.ReadLine().Split(' ');
            int b = Convert.ToInt32(bnm[0]);
            int n = Convert.ToInt32(bnm[1]);
            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

            int moneySpent = getMoneySpent(keyboards, drives, b);
            Console.WriteLine(moneySpent);
        }

        public int getMoneySpent(int[] keyboards, int[] drives, int b) {
            var mostExpensive = -1;
            foreach(var keyboard in keyboards){
                foreach(var drive in drives){
                    if(keyboard + drive <= b && keyboard + drive > mostExpensive)
                        mostExpensive = keyboard + drive;
                }
            }           
            return mostExpensive;
        }
    }

    public class EletronicShopTests
    {
        [Theory]
        [MemberData(nameof(GetMemberDataTests))]
        public void EletronicShop_MustPassAllTests(int[] keyboards, int[] drives, int b, int expected){

            //Arrange
            var problem = new EletronicShop();
            
            //Act
            var result = problem.getMoneySpent(keyboards, drives, b);

            //Assert
            Assert.Equal(result, expected);
        }

        public static IEnumerable<object[]> GetMemberDataTests()
        {
            //keyboards, drives, b, expected
            yield return new object[] { new int[]{ 40, 50, 60 }, new int[]{ 5, 8, 12 }, 60, 58 };
            yield return new object[] { new int[]{ 3, 1 }, new int[]{ 5, 2, 8 }, 10, 9 };
            yield return new object[] { new int[]{ 4 }, new int[]{ 5 }, 5, -1 };
        }
    }
}