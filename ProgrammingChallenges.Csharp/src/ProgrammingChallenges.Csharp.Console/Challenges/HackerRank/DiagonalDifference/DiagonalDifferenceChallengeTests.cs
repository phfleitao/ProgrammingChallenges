using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class DiagonalDifferenceChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("3", "11 2 4", "4 5 6", "10 8 -12", "15")]
    public void BasicTests_MustPassAll(string input1, string input2, string input3, string input4, string expectedOutput)
    {
        //Arrange
        var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2, input3, input4);
        var problem = new DiagonalDifferenceChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}