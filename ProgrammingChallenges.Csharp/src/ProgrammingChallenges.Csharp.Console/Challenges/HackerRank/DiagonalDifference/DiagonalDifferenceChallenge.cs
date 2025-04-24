using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

internal sealed class DiagonalDifferenceChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.DiagonalDifference.Identification, 
        HackerRankChallenges.DiagonalDifference.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<List<int>> arr = [];

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine()!.TrimEnd().Split(' ').AsEnumerable().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = DiagonalDifference(arr);

        Console.WriteLine(result);
    }

    public static int DiagonalDifference(List<List<int>> arr)
    {
        int somaDiagonalPrincipal = 0;
        int somaDiagonalSecundaria = 0;

        for (int linha = 0; linha < arr.Count; linha++)
        {
            for (int coluna = 0; coluna < arr.Count; coluna++)
            {
                if (linha == coluna)
                {
                    somaDiagonalPrincipal += arr[linha][coluna];
                }

                if (linha + coluna == arr.Count - 1)
                {
                    somaDiagonalSecundaria += arr[linha][coluna];
                }
            }
        }

        return Math.Abs(somaDiagonalPrincipal - somaDiagonalSecundaria);
    }
}