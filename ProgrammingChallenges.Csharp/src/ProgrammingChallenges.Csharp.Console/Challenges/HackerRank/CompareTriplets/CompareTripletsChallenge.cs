using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;
internal sealed class CompareTripletsChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.CompareTriplets.Identification, 
        HackerRankChallenges.CompareTriplets.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        List<int> a = Console.ReadLine()!.TrimEnd().Split(' ').AsEnumerable().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        List<int> b = Console.ReadLine()!.TrimEnd().Split(' ').AsEnumerable().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
        List<int> result = CompareTriplets(a, b);

        Console.WriteLine(string.Join(" ", result));
    }

    public static List<int> CompareTriplets(List<int> a, List<int> b)
    {
        var resultado = new List<int> { 0, 0 };
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                resultado[0]++;
            }

            if (b[i] > a[i])
            {
                resultado[1]++;
            }
        }
        return resultado;
    }
}