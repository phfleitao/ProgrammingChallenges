using Microsoft.Extensions.DependencyInjection;
using ProgrammingChallenges.Csharp.Console;
using ProgrammingChallenges.Csharp.Console.Challenges.HackerRank.SolveMeFirst;

// Dependency Injection Configuration
ServiceCollection services = new();
var serviceProvider = services
    .AddConsoleDependencies()
    .BuildServiceProvider();

// Resolve the challenge and run it
var challenge = serviceProvider.GetRequiredService<SolveMeFirstChallenge>();
challenge.Run();