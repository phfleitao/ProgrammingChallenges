namespace ProgrammingChallenges.Csharp.Console.Core;

internal abstract class Challenge(string identifier, string description, IChallengeIO challengeIO)
{
    protected readonly IChallengeIO ChallengeIO = challengeIO;
    
    public string Identifier { get; init; } = identifier;
    public string Description { get; init; } = description;
    public abstract void Run();
}