using Microsoft.Extensions.DependencyInjection;
using ProgrammingChallenges.Csharp.Console.Challenges.HackerRank.SolveMeFirst;
using ProgrammingChallenges.Csharp.Console.Core;

namespace ProgrammingChallenges.Csharp.Console;

internal static class ConsoleDependencyInjection
{
    public static IServiceCollection AddConsoleDependencies(this IServiceCollection services)
    {
        // Core Services
        services.AddTransient<IChallengeIO, ConsoleChallengeIO>();
        
        // HackerRank Challenges
        services.AddTransient<SolveMeFirstChallenge>();
        
        return services;
    }
}