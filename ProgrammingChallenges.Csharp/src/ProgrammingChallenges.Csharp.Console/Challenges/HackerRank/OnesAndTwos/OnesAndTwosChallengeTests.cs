using ProgrammingChallenges.Csharp.Console.Core;
using Xunit;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

public class OnesAndTwosChallengeTests
{
    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("4", "0 0", "2 2", "0 2", "2 0", "0\r\n6\r\n2\r\n2")]
    public void BasicTests_FiveInputs_MustPassAll(string input1, string input2, string input3, string input4, string input5, string expectedOutput)
    {
        //Arrange
        using var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2, input3, input4, input5);
        var problem = new OnesAndTwosChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }

    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory]
    [InlineData("5", "1 1", "1 2", "1 3", "1 4", "1 5", "3\r\n5\r\n9\r\n13\r\n19")]
    [InlineData("5", "2 2", "2 4", "4 2", "8 2", "16 2", "6\r\n15\r\n8\r\n12\r\n20")]
    public void BasicTests_SixInputs_MustPassAll(string input1, string input2, string input3, string input4, string input5, string input6, string expectedOutput)
    {
        //Arrange
        using var challengeIO = new TestChallengeIO();
        challengeIO.AddInputs(input1, input2, input3, input4, input5, input6);
        var problem = new OnesAndTwosChallenge(challengeIO);

        //Act
        problem.Run();

        //Assert
        Assert.Equal(challengeIO.Output, expectedOutput);
    }

    [Trait("Category", HackerRankChallenges.Identification)]
    [Theory(Skip = "Challenge not solved yet, this test is failing and has a 'todo' to reevaluate the solution")]
    [InlineData("TestCase3_Input.txt", "TestCase3_Output.txt")]
    [InlineData("TestCase4_Input.txt", "TestCase4_Output.txt")]
    public void BigTests_FromFile_MustPassAll(string testCaseInputFileName, string testCaseOutputFileName)
    {
        //Arrange
        var basePath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\Challenges\HackerRank\OnesAndTwos\TestFiles");
        var testCaseInputPath = Path.Combine(basePath, testCaseInputFileName);
        var testCaseOutputPath = Path.Combine(basePath, testCaseOutputFileName);
        var outputPath = Path.GetTempFileName();

        //Act
        using (var challengeIO = new FileChallengeIO(testCaseInputPath, outputPath))
        {
            var problem = new OnesAndTwosChallenge(challengeIO);
            problem.Run();
        }

        var actualOutput = File.ReadAllText(outputPath).Trim();
        var expectedOutput = File.ReadAllText(testCaseOutputPath).Trim();

        File.Delete(outputPath);

        //Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
}