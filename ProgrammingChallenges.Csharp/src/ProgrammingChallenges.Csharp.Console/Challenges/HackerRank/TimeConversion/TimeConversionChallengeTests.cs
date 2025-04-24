using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class TimeConversionChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("07:05:45PM", "19:05:45")]
    [InlineData("12:01:00PM", "12:01:00")]
    [InlineData("12:01:00AM", "00:01:00")]
    public void BasicTests_MustPassAll(string input, string expectedOutput)
    {
        //Arrange
        var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input);
        var problem = new TimeConversionChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}