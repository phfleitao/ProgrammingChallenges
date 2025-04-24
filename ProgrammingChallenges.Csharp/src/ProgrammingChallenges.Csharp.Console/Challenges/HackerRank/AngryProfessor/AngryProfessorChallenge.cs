using System.Diagnostics.CodeAnalysis;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

[SuppressMessage("Maintainability", "S1481", Justification = "Keep challenge code as is even if not used")]
internal sealed class AngryProfessorChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.AngryProfessor.Identification, 
        HackerRankChallenges.AngryProfessor.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int t = Convert.ToInt32(Console.ReadLine()!.Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            List<int> a = Console.ReadLine()!.TrimEnd().Split(' ').Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            string result = AngryProfessor(k, a);

            Console.WriteLine(result);
        }
    }
    public static string AngryProfessor(int k, List<int> a)
    {
        return a.Count(t => t <= 0) >= k ? "NO" : "YES";
    }
}