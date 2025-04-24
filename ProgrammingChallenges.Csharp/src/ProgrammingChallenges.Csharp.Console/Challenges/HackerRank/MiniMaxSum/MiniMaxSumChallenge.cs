using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

internal sealed class MiniMaxSumChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.MiniMaxSum.Identification, 
        HackerRankChallenges.MiniMaxSum.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        MiniMaxSum(arr);
    }

    public void MiniMaxSum(List<int> arr)
    {
        long max = 0;
        long min = 0;

        arr.Sort();
        for (int i = 0; i < arr.Count; i++)
        {
            if (i < arr.Count - 1)
            {
                min += arr[i];
            }

            if (i > 0)
            {
                max += arr[i];
            }
        }

        Console.WriteLine($"{min} {max}");
    }
}