using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "IDE0060", Justification = "Keep challenge code as is even if not used")]
internal sealed class SalesByMatchChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.SalesByMatch.Identification, 
        HackerRankChallenges.SalesByMatch.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> ar = Console.ReadLine()!.TrimEnd().Split(' ').AsEnumerable().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = SockMerchant(n, ar);

        Console.WriteLine(result);
    }

    public static int SockMerchant(int n, List<int> ar)
    {
        var pairsCount = ar.GroupBy(x => x)
                    .Select(o =>
                    new
                    {
                        Value = o.Key,
                        Count = o.Count()
                    })
                    .Sum(s => s.Count / 2);
        return pairsCount;
    }
}