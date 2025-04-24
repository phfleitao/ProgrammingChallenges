using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class BetweenTwoSetsChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.BetweenTwoSets.Identification, 
        HackerRankChallenges.BetweenTwoSets.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').AsEnumerable().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        List<int> brr = Console.ReadLine()!.TrimEnd().Split(' ').AsEnumerable().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = GetTotalX(arr, brr);
        Console.WriteLine(total);
    }

    private static int GetTotalX(List<int> a, List<int> b)
    {
        IEnumerable<int> fullList = a.Concat(b);
        IEnumerable<int> enumerable = fullList.ToList();
        var max = enumerable.Max();
        var min = enumerable.Min();
        var result = 0;

        for (int i = max; i >= min; i--)
        {
            if (a.All(x => i % x == 0) && b.All(x => x % i == 0))
            {
                result++;
            }
        }

        return result;
    }
}