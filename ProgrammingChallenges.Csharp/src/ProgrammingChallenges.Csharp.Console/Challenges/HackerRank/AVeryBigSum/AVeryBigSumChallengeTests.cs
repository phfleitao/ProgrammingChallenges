using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class AVeryBigSumChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("5", "1000000001 1000000002 1000000003 1000000004 1000000005", "5000000015")]
    [InlineData("10", "1001458909 1004570889 1007019111 1003302837 1002514638 1006431461 1002575010 1007514041 1007548981 1004402249", "10047338126")]
    public void BasicTests_MustPassAll(string input1, string input2, string expectedOutput)
    {
        //Arrange
        using var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2);
        var problem = new AVeryBigSumChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}