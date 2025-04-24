using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class AngryProfessorChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("2", "4 3", "-1 -3 4 2", "4 2", "0 -1 2 1", "YES\r\nNO")]
    public void BasicTests_MustPassAll(string input1, string input2, string input3, string input4, string input5, string expectedOutput)
    {
        //Arrange
        var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2, input3, input4, input5);
        var problem = new AngryProfessorChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}