using System.Data;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

internal sealed class OnesAndTwosChallenge(IChallengeIO challengeIO) : Challenge(
        HackerRankChallenges.OnesAndTwos.Identification, 
        HackerRankChallenges.OnesAndTwos.Description)
{
    private readonly IChallengeIO Console = challengeIO;

    public override void Run()
    {
        int t = Convert.ToInt32(Console.ReadLine()!.Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

            int a = Convert.ToInt32(firstMultipleInput[0]);
            int b = Convert.ToInt32(firstMultipleInput[1]);

            int result = OnesAndTwos(a, b);

            Console.WriteLine(result);
        }
    }

    //TODO: Falha no submit para numeros muito altos ... é preciso otimizar. Uma alternativa seria remover o uso do Datatable para computar as expressions
    public static int OnesAndTwos(int a, int b)
    {
        var compositions = new List<List<long>>();
        var expressions = new Dictionary<string, long>();
        var va = Enumerable.Repeat((long)1, a).ToArray();
        var vb = Enumerable.Repeat((long)2, b).ToArray();

        if (a == 0 && b == 0)
        {
            return 0;
        }

        //somente a
        for (int i = 0; i < a; i++)
        {
            var composition = va.Take(i + 1).ToList();
            compositions.Add(composition);
        }

        //somente b
        for (int i = 0; i < b; i++)
        {
            var composition = vb.Take(i + 1).ToList();
            compositions.Add(composition);
        }

        //a e b
        for (int i = 0; i < a; i++)
        {
            var compositionA = va.Take(i + 1).ToList();
            for (int j = 0; j < b; j++)
            {
                var composition = new List<long>();
                composition.AddRange(compositionA);
                composition.AddRange(vb.Take(j + 1).ToList());

                compositions.Add(composition);
            }
        }

        foreach (var composition in compositions)
        {
            var signalIndex = -1;
            var expression = string.Empty;

            if (composition.Count == 1)
            {
                expressions.Add(composition[0].ToString(), Convert.ToInt32(composition[0].ToString()));
            }
            else
            {
                //+
                for (int i = 0; i < composition.Count - 1; i++)
                {
                    for (int j = 0; j < composition.Count; j++)
                    {
                        expression += composition[j].ToString();
                        if (i > 0 && j <= signalIndex)
                        {
                            expression += "*";
                        }
                        else
                        {
                            expression += "+";
                        }
                    }

                    signalIndex++;
                    expression = expression[..^1];
                    using (var dataTable = new DataTable()) // Ensure DataTable is disposed
                    {
                        expressions.Add(expression, Convert.ToInt64(dataTable.Compute(expression, null)));
                    }
                    expression = string.Empty;
                }

                signalIndex = -1;
                expression = string.Empty;
                //*
                for (int i = 0; i < composition.Count - 1; i++)
                {
                    for (int j = 0; j < composition.Count; j++)
                    {
                        expression += composition[j].ToString();
                        if (i > 0 && j <= signalIndex)
                        {
                            expression += "+";
                        }
                        else
                        {
                            expression += "*";
                        }
                    }

                    signalIndex++;
                    expression = expression[..^1];
                    using (var dataTable = new DataTable()) // Ensure DataTable is disposed
                    {
                        expressions.Add(expression, Convert.ToInt64(dataTable.Compute(expression, null)));
                    }
                    expression = string.Empty;
                }
            }
        }

        return expressions.Values.Distinct().Count();
    }
}