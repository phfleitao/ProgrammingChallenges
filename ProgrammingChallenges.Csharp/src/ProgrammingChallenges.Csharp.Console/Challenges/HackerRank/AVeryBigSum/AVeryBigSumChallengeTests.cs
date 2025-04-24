using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class AVeryBigSumChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("5", "1000000001 1000000002 1000000003 1000000004 1000000005", "5000000015")]
    public void BasicTests_MustPassAll(string input1, string input2, string expectedOutput)
    {
        //Arrange
        var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2);
        var problem = new AVeryBigSumChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}