using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank.SolveMeFirst;

[SuppressMessage("Naming", "CA1707", Justification = "Keep tests naming convention")]
public class SolveMeFirstChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("2","3","5")]
    [InlineData("100","1000","1100")]
    private void SolveMeFirst_BasicTests_ShouldPass(string v1, string v2, string expectedSum){
        //Arrange
        var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(v1, v2);
        var problem = new SolveMeFirstChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output.Trim('\r','\n'), expectedSum);
    }
}