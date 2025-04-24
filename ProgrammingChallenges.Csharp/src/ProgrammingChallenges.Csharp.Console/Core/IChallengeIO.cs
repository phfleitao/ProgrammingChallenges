namespace ProgrammingChallenges.Csharp.Console.Core;

internal interface IChallengeIO : IDisposable
{
    string? ReadLine();
    void WriteLine(object? value);
    void Write(object? value);
}