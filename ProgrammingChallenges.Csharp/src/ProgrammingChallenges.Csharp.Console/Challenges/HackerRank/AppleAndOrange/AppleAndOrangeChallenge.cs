using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class AppleAndOrangeChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.AppleAndOrange.Identification, 
        HackerRankChallenges.AppleAndOrange.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');
        int s = Convert.ToInt32(firstMultipleInput[0]);
        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');
        int a = Convert.ToInt32(secondMultipleInput[0]);
        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');
        int m = Convert.ToInt32(thirdMultipleInput[0]);
        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine()!.TrimEnd().Split(' ').Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();
        List<int> oranges = Console.ReadLine()!.TrimEnd().Split(' ').Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        CountApplesAndOranges(s, t, a, b, apples, oranges);
    }

    public void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var applesInProperty = apples.Count(d => a + d >= s && a + d <= t);
        var orangesInProperty = oranges.Count(d => b + d >= s && b + d <= t);

        Console.WriteLine(applesInProperty);
        Console.WriteLine(orangesInProperty);
    }
}