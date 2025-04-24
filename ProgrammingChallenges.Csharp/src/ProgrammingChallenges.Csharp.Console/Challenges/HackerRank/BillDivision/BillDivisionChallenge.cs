using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class BillDivisionChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.BillDivision.Identification, 
        HackerRankChallenges.BillDivision.Description)
{
    private readonly IChallengeIO Console = challengeIO;
    public override void Run()
    {
        string[] nk = Console.ReadLine()!.TrimEnd().Split(' ');
        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);

        List<int> bill = Console.ReadLine()!.TrimEnd().Split(' ')
            .AsEnumerable()
            .Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine()!.Trim());
        BonAppetit(bill, k, b);
    }

    public void BonAppetit(List<int> bill, int k, int b)
    {
        var charged = b;
        var actual = (bill.Sum() - bill[k]) / 2;

        if (charged - actual == 0)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine((charged - actual).ToString());
        }
    }
}