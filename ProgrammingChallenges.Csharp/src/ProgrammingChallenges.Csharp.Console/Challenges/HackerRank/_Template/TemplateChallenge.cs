using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;
internal sealed class TemplateChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.Template.Identification, 
        HackerRankChallenges.Template.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        Console.WriteLine("Template");
    }
}