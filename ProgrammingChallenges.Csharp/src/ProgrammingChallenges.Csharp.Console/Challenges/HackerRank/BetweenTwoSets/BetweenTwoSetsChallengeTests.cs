using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank.BetweenTwoSets;

[SuppressMessage("Naming", "CA1707", Justification = "Keep tests naming convention")]
public class BetweenTwoSetsChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("2 2", "2 6","24 36","2")]
    [InlineData("2 3","2 4","16 32 96","3")]
    private void BetweenTwoSets_MustPassAllTests(string nm, string a, string b, string expected)
    {
        //Arrange
        var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(nm, a, b);
        var problem = new BetweenTwoSetsChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output.Trim('\r', '\n'), expected);
    }
}