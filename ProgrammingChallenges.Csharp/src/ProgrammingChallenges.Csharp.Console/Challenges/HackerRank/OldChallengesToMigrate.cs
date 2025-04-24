using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

//DEPRECATED: New model created for problem solving
//TODO: Separate Problem Resoltutions in each class inside Problems Folder like BillDivision

[SuppressMessage("Maintainability", "IDE0060", Justification = "Keep challenge code as is even if not used")]
[SuppressMessage("Maintainability", "IDE1006", Justification = "Keep challenge code as is even if not used")]
[SuppressMessage("Maintainability", "IDE0057", Justification = "Keep challenge code as is even if not used")]
internal static class OldChallengesToMigrate
{
    public static int simpleArraySum(int[] ar)
    {
        int soma = 0;
        foreach (var valor in ar)
        {
            soma += valor;
        }

        return soma;
    }

    public static int diagonalDifference(List<List<int>> arr)
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

    public static void plusMinus(int[] arr)
    {
        int countPlus = 0; int countMinus = 0; int countZero = 0;

        foreach (var value in arr)
        {
            if (value > 0)
            {
                countPlus++;
            }
            else if (value < 0)
            {
                countMinus++;
            }
            else
            {
                countZero++;
            }
        }

        System.Console.WriteLine((countPlus / (double)arr.Length).ToString("0.000000", CultureInfo.InvariantCulture));
        System.Console.WriteLine((countMinus / (double)arr.Length).ToString("0.000000", CultureInfo.InvariantCulture));
        System.Console.WriteLine((countZero / (double)arr.Length).ToString("0.000000", CultureInfo.InvariantCulture));
    }

    public static void staircase(int n)
    {
        int printIndex = n - 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j >= printIndex)
                {
                    System.Console.Write("#");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine("");
            printIndex--;
        }
    }

    public static void miniMaxSum(int[] arr)
    {
        long max = 0;
        long min = 0;

        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1)
            {
                min += arr[i];
            }

            if (i > 0)
            {
                max += arr[i];
            }
        }

        System.Console.WriteLine($"{min} {max}");
    }

    public static int birthdayCakeCandles(List<int> candles)
    {
        candles.Sort();
        int tallest = candles[^1];
        int count = 0;
        for (int i = candles.Count - 1; i >= 0; i--)
        {
            if (candles[i] != tallest)
            {
                break;
            }

            count++;
        }
        return count;
    }

    public static string timeConversion(string s)
    {
        return DateTime.Parse(s).ToString("HH:mm:ss");
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

    public static List<int> gradingStudents(List<int> grades)
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

    public static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        var applesInProperty = apples.Count(d => a + d >= s && a + d <= t);
        var orangesInProperty = oranges.Count(d => b + d >= s && b + d <= t);

        System.Console.WriteLine(applesInProperty);
        System.Console.WriteLine(orangesInProperty);
    }

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (x2 > x1 && v2 >= v1)
        {
            return "NO";
        }

        if (x1 > x2 && v1 >= v2)
        {
            return "NO";
        }

        var p = (x2 - x1) / (v1 - v2);

        if (x1 + (v1 * p) == x2 + (v2 * p))
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }

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
}
