using Microsoft.Extensions.DependencyInjection;
using ProgrammingChallenges.Csharp.Console;
using ProgrammingChallenges.Csharp.Console.Challenges.HackerRank;

// Dependency Injection Configuration
ServiceCollection services = new();
var serviceProvider = services
    .AddConsoleDependencies()
    .BuildServiceProvider();

// Resolve the challenge and run it, change the 'SolveMeFirstChallenge' when need to test other challenges
var challenge = serviceProvider.GetRequiredService<SolveMeFirstChallenge>();
challenge.Run();