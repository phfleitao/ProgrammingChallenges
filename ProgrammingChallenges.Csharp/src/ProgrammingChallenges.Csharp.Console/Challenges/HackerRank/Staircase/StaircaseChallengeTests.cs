using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class StaircaseChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("4", "   #\r\n  ##\r\n ###\r\n####")]
    [InlineData("6", "     #\r\n    ##\r\n   ###\r\n  ####\r\n #####\r\n######")]
    public void BasicTests_MustPassAll(string input1, string expectedOutput)
    {
        //Arrange
        using var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1);
        var problem = new StaircaseChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}