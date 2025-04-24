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
        services.AddTransient<AVeryBigSumChallenge>();
        services.AddTransient<BetweenTwoSetsChallenge>();
        services.AddTransient<BillDivisionChallenge>();
        services.AddTransient<BirthdayCakeCandlesChallenge>();
        services.AddTransient<CatsAndMouseChallenge>();
        services.AddTransient<CompareTripletsChallenge>();
        services.AddTransient<CountingValleysChallenge>();
        services.AddTransient<DiagonalDifferenceChallenge>();
        services.AddTransient<EletronicShopChallenge>();
        services.AddTransient<MiniMaxSumChallenge>();
        services.AddTransient<PlusMinusChallenge>();
        services.AddTransient<SalesByMatchChallenge>();
        services.AddTransient<SimpleArraySumChallenge>();
        services.AddTransient<SolveMeFirstChallenge>();
        services.AddTransient<StaircaseChallenge>();

        return services;
    }
}