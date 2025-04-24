using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank.BetweenTwoSets;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class BetweenTwoSetsChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.BetweenTwoSets.Identification, 
        HackerRankChallenges.BetweenTwoSets.Description, 
        challengeIO)
{
    public override void Run()
    {
        var nm = ChallengeIO.ReadLine();
        
        List<int>? arr = ChallengeIO
            .ReadLine()?.ToString()?.TrimEnd().Split(' ').AsEnumerable()
            .Select(arrTemp => Convert.ToInt32(arrTemp, CultureInfo.InvariantCulture)).ToList();
        
        List<int>? brr = ChallengeIO
            .ReadLine()?.ToString()?.TrimEnd().Split(' ').AsEnumerable()
            .Select(brrTemp => Convert.ToInt32(brrTemp, CultureInfo.InvariantCulture)).ToList();

        if (arr == null || brr == null)
        {
            return;
        }

        int total = GetTotalX(arr, brr);
        ChallengeIO.WriteLine(total);
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