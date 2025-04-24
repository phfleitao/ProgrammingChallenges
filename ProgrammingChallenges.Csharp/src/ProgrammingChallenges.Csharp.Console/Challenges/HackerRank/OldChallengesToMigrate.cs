using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

//DEPRECATED: New model created for problem solving
//TODO: Separate Problem Resoltutions in each class inside Problems Folder like BillDivision

[SuppressMessage("Maintainability", "IDE0060", Justification = "Keep challenge code as is even if not used")]
[SuppressMessage("Maintainability", "IDE1006", Justification = "Keep challenge code as is even if not used")]
[SuppressMessage("Maintainability", "IDE0057", Justification = "Keep challenge code as is even if not used")]
internal static class OldChallengesToMigrate
{
    public static int migratoryBirds(List<int> arr)
    {
        var frequency = new int[5] { 0, 0, 0, 0, 0 };
        var GreaterFrequency = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            frequency[arr[i] - 1]++;
            if (frequency[arr[i] - 1] > GreaterFrequency)
            {
                GreaterFrequency = frequency[arr[i] - 1];
            }
        }
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] == GreaterFrequency)
            {
                return i + 1;
            }
        }
        return 0;
    }

    public static int divisibleSumPairs(int n, int k, int[] ar)
    {
        var counter = 0;
        for (int i = 0; i < ar.Length-1; i++)
        {
            for (int j = i+1; j < ar.Length; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    counter++;
                }
            }                
        }

        return counter;
    }

    public static string angryProfessor(int k, int[] a)
    {
        return a.Count(t => t <= 0) >= k ? "NO" : "YES";
    }

    //Falha no submit para numeros muito altos ... é preciso otimizar
    public static int OnesAndTwos(int a, int b)
    {
        var composicoes = new List<List<long>>();
        var expressoes = new Dictionary<string, long>();
        var va = Enumerable.Repeat((long)1, a).ToArray();
        var vb = Enumerable.Repeat((long)2, b).ToArray();

        if (a == 0 && b == 0)
        {
            return 0;
        }

        //somente a
        for (int i = 0; i < a; i++)
        {
            var composicao = va.Take(i + 1).ToList();
            composicoes.Add(composicao);
        }

        //somente b
        for (int i = 0; i < b; i++)
        {
            var composicao = vb.Take(i + 1).ToList();
            composicoes.Add(composicao);
        }

        //a e b
        for (int i = 0; i < a; i++)
        {
            var composicaoA = va.Take(i + 1).ToList();
            for (int j = 0; j < b; j++)
            {
                var composicao = new List<long>();
                composicao.AddRange(composicaoA);
                composicao.AddRange(vb.Take(j + 1).ToList());

                composicoes.Add(composicao);
            }
        }

        foreach (var composicao in composicoes)
        {
            var indiceSinal = -1;
            var expressao = string.Empty;

            if (composicao.Count == 1)
            {
                expressoes.Add(composicao[0].ToString(), Convert.ToInt32(composicao[0].ToString()));
            }
            else
            {
                //+
                for (int i = 0; i < composicao.Count - 1; i++)
                {
                    for (int j = 0; j < composicao.Count; j++)
                    {
                        expressao += composicao[j].ToString();
                        if (i > 0 && j <= indiceSinal)
                        {
                            expressao += "*";
                        }
                        else
                        {
                            expressao += "+";
                        }
                    }

                    indiceSinal++;
                    expressao = expressao.Remove(expressao.Length - 1, 1);
                    using (var dataTable = new DataTable()) // Ensure DataTable is disposed
                    {
                        expressoes.Add(expressao, Convert.ToInt64(dataTable.Compute(expressao, null)));
                    }
                    expressao = string.Empty;
                }

                indiceSinal = -1;
                expressao = string.Empty;
                //*
                for (int i = 0; i < composicao.Count - 1; i++)
                {
                    for (int j = 0; j < composicao.Count; j++)
                    {
                        expressao += composicao[j].ToString();
                        if (i > 0 && j <= indiceSinal)
                        {
                            expressao += "+";
                        }
                        else
                        {
                            expressao += "*";
                        }
                    }

                    indiceSinal++;
                    expressao = expressao.Remove(expressao.Length - 1, 1);
                    using (var dataTable = new DataTable()) // Ensure DataTable is disposed
                    {
                        expressoes.Add(expressao, Convert.ToInt64(dataTable.Compute(expressao, null)));
                    }
                    expressao = string.Empty;
                }
            }
        }

        return expressoes.Values.Distinct().Count();
    }

}
