using System;
using System.IO;
using Xunit;

namespace HackerRank.CSharp.Problems
{
    public class CountingValleys : IProblem
    {
        public string Name => nameof(CountingValleys);

        public string Url => "https://www.hackerrank.com/challenges/counting-valleys/problem";

        public void Run()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = countingValleys(steps, path);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        public int countingValleys(int steps, string path)
        {
            int level = 0;
            int valleyCounter = 0;
            bool isBelowTheSea = false;

            for (var step = 0; step < steps; step++)
            {
                var letter = path[step];
                
                if(letter == 'D'){
                    level--;
                    isBelowTheSea = (level < 0);
                }

                if(letter == 'U'){
                    level++;
                }

                if(level == 0){
                    if(isBelowTheSea) 
                        valleyCounter++;
                    isBelowTheSea = false;
                }
            }

            return valleyCounter;
        }
    }

    public class CountingValleysTests
    {
        [Theory]
        [InlineData(2, "DU", 1)]
        [InlineData(8, "DDUUUUDD", 1)]
        [InlineData(8, "UDDDUDUU", 1)]
        [InlineData(10, "UDDDUUDDUU", 2)]
        public void CountingValleysTests_MustPassAllTests(int steps, string path, int expected){
            //Arrange
            var problem = new CountingValleys();

            //Act
            var calculated = problem.countingValleys(steps, path);

            //Assert
            Assert.Equal(calculated, expected);
        }
    }
}