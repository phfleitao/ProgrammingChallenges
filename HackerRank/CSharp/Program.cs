using System;
using System.Collections.Generic;
using HackerRank.CSharp.Problems;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var problems = GetProblems();

            string problemName = "SolveMeFirst"; //Definir nome do problema para executar apenas 1
            if(!string.IsNullOrEmpty(problemName)){
                problems[problemName].Run();
                return;
            }

            foreach (var problem in problems)
            {
                problem.Value.Run();
            }
        }

        static Dictionary<string, IProblem> GetProblems(){
            var problems = new Dictionary<string, IProblem>();

            problems.Add("SolveMeFirst", new SolveMeFirst());
            problems.Add("CompareTriplets", new CompareTriplets());
            problems.Add("BillDivision", new BillDivision());
            

            return problems;
        }
    }
}
