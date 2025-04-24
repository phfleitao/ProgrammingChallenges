using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class MigratoryBirdsChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.MigratoryBirds.Identification, 
        HackerRankChallenges.MigratoryBirds.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int arrCount = Convert.ToInt32(Console.ReadLine()!.Trim());
        List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = MigratoryBirds(arr);
        Console.WriteLine(result);
    }

    public static int MigratoryBirds(List<int> arr)
    {
        var frequency = new int[5] { 0, 0, 0, 0, 0 };
        var GreaterFrequency = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            frequency[arr[i] - 1]++;
            if (frequency[arr[i] - 1] > GreaterFrequency)
            {
                GreaterFrequency = frequency[arr[i] - 1];
            }
        }
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] == GreaterFrequency)
            {
                return i + 1;
            }
        }
        return 0;
    }
}