using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class PlusMinusChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("6", "-4 3 -9 0 4 1", "0.500000\r\n0.333333\r\n0.166667")]
    public void BasicTests_MustPassAll(string input1, string input2, string expectedOutput)
    {
        //Arrange
        var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2);
        var problem = new PlusMinusChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}