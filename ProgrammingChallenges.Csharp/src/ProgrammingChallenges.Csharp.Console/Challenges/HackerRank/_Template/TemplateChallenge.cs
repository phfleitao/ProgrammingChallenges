using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

//TODO: Remove SuppressMessage if its not necessary
//[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
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