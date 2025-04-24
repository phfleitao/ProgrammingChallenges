using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;
internal sealed class SolveMeFirstChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.SolveMeFirst.Identification, 
        HackerRankChallenges.SolveMeFirst.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        var val1 = Convert.ToInt32(Console.ReadLine());
        var val2 = Convert.ToInt32(Console.ReadLine());
        var sum = SolveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
    private static int SolveMeFirst(int a, int b) => a + b;
}