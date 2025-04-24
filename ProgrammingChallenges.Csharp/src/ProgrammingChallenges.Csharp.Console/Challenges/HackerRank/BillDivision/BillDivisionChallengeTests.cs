using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class BillDivisionChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("4 1", "3 10 2 9", "7", "Bon Appetit")]
    [InlineData("4 1", "3 10 2 9", "12", "5")]
    public void BasicTests_MustPassAll(string input1, string input2, string input3, string expectedOutput){
        //Arrange
        using var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2, input3);
        var problem = new BillDivisionChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}