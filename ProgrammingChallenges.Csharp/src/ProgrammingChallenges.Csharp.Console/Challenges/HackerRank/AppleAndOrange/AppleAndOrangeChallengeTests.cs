using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class AppleAndOrangeChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("7 11", "5 15", "3 2", "-2 2 1", "5 -6", "1\r\n1")]
    public void BasicTests_MustPassAll(string input1, string input2, string input3, string input4, string input5, string expectedOutput)
    {
        //Arrange
        using var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2, input3, input4, input5);
        var problem = new AppleAndOrangeChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}