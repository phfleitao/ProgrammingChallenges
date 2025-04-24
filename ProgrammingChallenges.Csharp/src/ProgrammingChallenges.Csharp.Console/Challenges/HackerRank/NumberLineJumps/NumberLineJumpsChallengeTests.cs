using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class NumberLineJumpsChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("0 2 5 3", "NO")]
    [InlineData("0 3 4 2", "YES")]
    [InlineData("2 1 1 2", "YES")]
    public void BasicTests_MustPassAll(string input, string expectedOutput)
    {
        //Arrange
        var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input);
        var problem = new NumberLineJumpsChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}