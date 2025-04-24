using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class SimpleArraySumChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.SimpleArraySum.Identification, 
        HackerRankChallenges.SimpleArraySum.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int arCount = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> ar = Console.ReadLine()!.TrimEnd().Split(' ').AsEnumerable().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = SimpleArraySum(ar);

        Console.WriteLine(result);
    }

    public static int SimpleArraySum(List<int> ar)
    {
        int sum = 0;
        foreach (var value in ar)
        {
            sum += value;
        }

        return sum;
    }
}