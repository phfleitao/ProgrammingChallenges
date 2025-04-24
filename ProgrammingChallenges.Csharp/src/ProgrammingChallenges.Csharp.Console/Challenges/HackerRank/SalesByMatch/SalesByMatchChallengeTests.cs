using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class SalesByMatchChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("9", "10 20 20 10 10 30 50 10 20", "3")]
    [InlineData("7", "1 2 1 2 1 3 2", "2")]
    [InlineData("10", "1 1 3 1 2 1 3 3 3 3", "4")]
    public void BasicTests_MustPassAll(string input1, string input2, string expectedOutput)
    {
        //Arrange
        using var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2);
        var problem = new SalesByMatchChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}