using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class EletronicShopChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.EletronicShop.Identification, 
        HackerRankChallenges.EletronicShop.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        string[] bnm = Console.ReadLine()!.Split(' ');
        int b = Convert.ToInt32(bnm[0]);
        int n = Convert.ToInt32(bnm[1]);
        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine()!.Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
        int[] drives = Array.ConvertAll(Console.ReadLine()!.Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

        int moneySpent = GetMoneySpent(keyboards, drives, b);
        Console.WriteLine(moneySpent);
    }

    public static int GetMoneySpent(int[] keyboards, int[] drives, int b)
    {
        var mostExpensive = -1;
        foreach (var keyboard in keyboards)
        {
            foreach (var drive in drives)
            {
                if (keyboard + drive <= b && keyboard + drive > mostExpensive)
                {
                    mostExpensive = keyboard + drive;
                }
            }
        }
        return mostExpensive;
    }
}