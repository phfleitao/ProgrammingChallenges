using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;
internal sealed class CountingValleysChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.CountingValleys.Identification, 
        HackerRankChallenges.CountingValleys.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int steps = Convert.ToInt32(Console.ReadLine()!.Trim());

        string path = Console.ReadLine()!;

        int result = CountingValleys(steps, path);

        Console.WriteLine(result);
    }

    public static int CountingValleys(int steps, string path)
    {
        int level = 0;
        int valleyCounter = 0;
        bool isBelowTheSea = false;

        for (var step = 0; step < steps; step++)
        {
            var letter = path[step];

            if (letter == 'D')
            {
                level--;
                isBelowTheSea = level < 0;
            }

            if (letter == 'U')
            {
                level++;
            }

            if (level == 0)
            {
                if (isBelowTheSea)
                {
                    valleyCounter++;
                }

                isBelowTheSea = false;
            }
        }

        return valleyCounter;
    }
}