using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "IDE0060", Justification = "Keep challenge code as is even if not used")]
internal sealed class DivisibleSumPairsChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.DivisibleSumPairs.Identification, 
        HackerRankChallenges.DivisibleSumPairs.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> ar = Console.ReadLine()!.TrimEnd().Split(' ').Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = DivisibleSumPairs(n, k, ar);

        Console.WriteLine(result);
    }

    public static int DivisibleSumPairs(int n, int k, List<int> ar)
    {
        var counter = 0;
        for (int i = 0; i < ar.Count - 1; i++)
        {
            for (int j = i + 1; j < ar.Count; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}