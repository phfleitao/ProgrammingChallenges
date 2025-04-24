using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class EletronicShopChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("60 3 3", "40 50 60", "5 8 12", "58")]
    [InlineData("10 2 3", "3 1", "5 2 8", "9")]
    [InlineData("5 1 1", "4", "5", "-1")]
    public void BasicTests_MustPassAll(string input1, string input2, string input3, string expectedOutput)
    {
        //Arrange
        var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2, input3);
        var problem = new EletronicShopChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}