using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;
internal sealed class CatsAndMouseChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.CatsAndMouse.Identification, 
        HackerRankChallenges.CatsAndMouse.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] xyz = Console.ReadLine()!.Split(' ');

            int x = Convert.ToInt32(xyz[0]);
            int y = Convert.ToInt32(xyz[1]);
            int z = Convert.ToInt32(xyz[2]);

            string result = CatAndMouse(x, y, z);

            Console.WriteLine(result);
        }
    }

    public static string CatAndMouse(int x, int y, int z)
    {
        var passosGatoA = Math.Abs(x - z);
        var passosGatoB = Math.Abs(y - z);

        if (passosGatoA < passosGatoB)
        {
            return "Cat A";
        }

        if (passosGatoB < passosGatoA)
        {
            return "Cat B";
        }

        return "Mouse C";
    }
}