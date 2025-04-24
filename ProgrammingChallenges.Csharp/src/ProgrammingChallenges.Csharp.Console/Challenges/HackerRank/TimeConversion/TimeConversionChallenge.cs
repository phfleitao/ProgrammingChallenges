using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

internal sealed class TimeConversionChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.TimeConversion.Identification, 
        HackerRankChallenges.TimeConversion.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        string s = Console.ReadLine()!;

        string result = TimeConversion(s);

        Console.WriteLine(result);
    }

    public static string TimeConversion(string s)
    {
        return DateTime.Parse(s).ToString("HH:mm:ss");
    }
}