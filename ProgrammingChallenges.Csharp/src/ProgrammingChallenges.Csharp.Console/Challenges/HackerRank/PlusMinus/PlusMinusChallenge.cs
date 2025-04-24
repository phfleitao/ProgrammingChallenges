using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class PlusMinusChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.PlusMinus.Identification, 
        HackerRankChallenges.PlusMinus.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        PlusMinus(arr);
    }

    public void PlusMinus(List<int> arr)
    {
        int countPlus = 0;
        int countMinus = 0;
        int countZero = 0;

        foreach (var value in arr)
        {
            if (value > 0)
            {
                countPlus++;
            }
            else if (value < 0)
            {
                countMinus++;
            }
            else
            {
                countZero++;
            }
        }

        Console.WriteLine((countPlus / (double)arr.Count).ToString("0.000000", CultureInfo.InvariantCulture));
        Console.WriteLine((countMinus / (double)arr.Count).ToString("0.000000", CultureInfo.InvariantCulture));
        Console.WriteLine((countZero / (double)arr.Count).ToString("0.000000", CultureInfo.InvariantCulture));
    }
}