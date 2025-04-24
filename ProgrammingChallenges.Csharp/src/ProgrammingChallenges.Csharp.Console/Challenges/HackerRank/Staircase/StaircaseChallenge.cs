using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

internal sealed class StaircaseChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.Staircase.Identification, 
        HackerRankChallenges.Staircase.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());
        Staircase(n);
    }

    public void Staircase(int n)
    {
        int printIndex = n - 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j >= printIndex)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
            printIndex--;
        }
    }
}