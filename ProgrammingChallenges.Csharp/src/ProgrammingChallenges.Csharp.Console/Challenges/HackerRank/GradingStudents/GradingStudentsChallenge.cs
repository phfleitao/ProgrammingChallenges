using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

internal sealed class GradingStudentsChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.GradingStudents.Identification, 
        HackerRankChallenges.GradingStudents.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int gradesCount = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> grades = [];

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine()!.Trim());
            grades.Add(gradesItem);
        }

        List<int> result = GradingStudents(grades);

        Console.WriteLine(string.Join("\n", result));
    }

    public static List<int> GradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            var nextMultipleOf5 = grades[i] + (5 - (grades[i] % 5));

            //rules
            if (grades[i] >= 38 && nextMultipleOf5 - grades[i] < 3)
            {
                grades[i] = nextMultipleOf5;
            }
        }

        return grades;
    }
}