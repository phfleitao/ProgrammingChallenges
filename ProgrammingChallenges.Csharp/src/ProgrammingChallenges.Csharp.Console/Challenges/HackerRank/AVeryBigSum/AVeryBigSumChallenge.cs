using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class AVeryBigSumChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.AVeryBigSum.Identification, 
        HackerRankChallenges.AVeryBigSum.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int arCount = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<long> ar = Console.ReadLine()!.TrimEnd().Split(' ').AsEnumerable().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = AVeryBigSum(ar);

        Console.WriteLine(result);
    }

    public static long AVeryBigSum(List<long> ar)
    {
        long sum = 0;
        foreach (var value in ar)
        {
            sum += value;
        }

        return sum;
    }
}