using Microsoft.Extensions.DependencyInjection;
using ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console;

internal static class ConsoleDependencyInjection
{
    public static IServiceCollection AddConsoleDependencies(this IServiceCollection services)
    {
        // Core Services
        services.AddTransient<IChallengeIO, ConsoleChallengeIO>();

        // HackerRank Challenges
        services.AddTransient<BetweenTwoSetsChallenge>();
        services.AddTransient<BillDivisionChallenge>();
        services.AddTransient<CatsAndMouseChallenge>();
        services.AddTransient<CompareTripletsChallenge>();
        services.AddTransient<CountingValleysChallenge>();
        services.AddTransient<EletronicShopChallenge>();
        services.AddTransient<SalesByMatchChallenge>();
        services.AddTransient<SolveMeFirstChallenge>();        

        return services;
    }
}