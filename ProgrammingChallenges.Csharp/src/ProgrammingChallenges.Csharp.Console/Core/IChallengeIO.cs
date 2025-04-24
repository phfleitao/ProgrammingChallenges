namespace ProgrammingChallenges.Csharp.Console.Core;

internal interface IChallengeIO
{
    string? ReadLine();
    void WriteLine(object? value);
    void Write(object? value);
}