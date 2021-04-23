using System;
using System.IO;
using Xunit;

namespace HackerRank.CSharp.Problems
{
    public class CatsAndMouse : IProblem
    {
        public string Name => nameof(CatsAndMouse);

        public string Url => "https://www.hackerrank.com/challenges/cats-and-a-mouse/problem";

        public void Run()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++) {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);
                int y = Convert.ToInt32(xyz[1]);
                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }

        public string catAndMouse(int x, int y, int z) 
        {
            var passosGatoA = Math.Abs(x - z);
            var passosGatoB = Math.Abs(y - z);

            if(passosGatoA < passosGatoB)
                return "Cat A";

            if(passosGatoB < passosGatoA)
                return "Cat B";

            return "Mouse C";
        }
    }

    public class CatsAndMouseTests
    {
        [Theory]
        [InlineData(1, 2, 3, "Cat B")]
        [InlineData(1, 3, 2, "Mouse C")]
        [InlineData(-4, 7, 1, "Cat A")]
        public void CatsAndMouseTests_MustPassAllTests(int x, int y, int z, string expected){
            //Arrange
            var problem = new CatsAndMouse();

            //Act
            var calculated = problem.catAndMouse(x, y, z);

            //Assert
            Assert.Equal(calculated, expected);
        }
    }
}