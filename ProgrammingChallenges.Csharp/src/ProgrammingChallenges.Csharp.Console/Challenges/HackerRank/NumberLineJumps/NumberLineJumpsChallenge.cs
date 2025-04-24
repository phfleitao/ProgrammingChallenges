using System.IO;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

internal sealed class NumberLineJumpsChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.NumberLineJumps.Identification, 
        HackerRankChallenges.NumberLineJumps.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);
        int v1 = Convert.ToInt32(firstMultipleInput[1]);
        int x2 = Convert.ToInt32(firstMultipleInput[2]);
        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }

    public static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        if (x2 > x1 && v2 >= v1)
        {
            return "NO";
        }

        if (x1 > x2 && v1 >= v2)
        {
            return "NO";
        }

        var p = (x2 - x1) / (v1 - v2);

        if (x1 + (v1 * p) == x2 + (v2 * p))
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }
}