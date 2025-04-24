using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class CatsAndMouseChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("1", "1 2 3", "Cat B")]
    [InlineData("1", "1 3 2", "Mouse C")]
    [InlineData("1", "-4 7 1", "Cat A")]
    public void BasicTests_MustPassAll(string input1, string input2, string expectedOutput)
    {
        //Arrange
        using var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2);
        var problem = new CatsAndMouseChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }

    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("2", "1 2 3", "1 3 2", "Cat B\r\nMouse C")]
    public void TwoLineTests_MustPassAll(string input1, string input2, string input3, string expectedOutput)
    {
        //Arrange
        using var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2, input3);
        var problem = new CatsAndMouseChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }
}