using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class BirthdayCakeCandlesChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.BirthdayCakeCandles.Identification, 
        HackerRankChallenges.BirthdayCakeCandles.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int candlesCount = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> candles = Console.ReadLine()!.TrimEnd().Split(' ').Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = BirthdayCakeCandles(candles);

        Console.WriteLine(result);
    }

    public static int BirthdayCakeCandles(List<int> candles)
    {
        candles.Sort();
        int tallest = candles[^1];
        int count = 0;
        for (int i = candles.Count - 1; i >= 0; i--)
        {
            if (candles[i] != tallest)
            {
                break;
            }

            count++;
        }
        return count;
    }
}