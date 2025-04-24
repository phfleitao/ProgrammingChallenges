using System.Globalization;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank.SolveMeFirst;
internal sealed class SolveMeFirstChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.SolveMeFirst.Identification, 
        HackerRankChallenges.SolveMeFirst.Description, 
        challengeIO)
{
    public override void Run()
    {
        var val1 = Convert.ToInt32(ChallengeIO.ReadLine(), CultureInfo.InvariantCulture);
        var val2 = Convert.ToInt32(ChallengeIO.ReadLine(), CultureInfo.InvariantCulture);
        var sum = SolveMeFirst(val1,val2);
        ChallengeIO.WriteLine(sum);
    }
    private static int SolveMeFirst(int a, int b) => a + b;
}