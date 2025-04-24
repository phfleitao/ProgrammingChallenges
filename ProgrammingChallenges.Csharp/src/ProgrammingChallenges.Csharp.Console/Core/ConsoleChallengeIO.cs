namespace ProgrammingChallenges.Csharp.Console.Core;

internal sealed class ConsoleChallengeIO : IChallengeIO
{
    public string? ReadLine() => System.Console.ReadLine();
    public void WriteLine(object? value) => System.Console.WriteLine(value);
    public void Write(object? value) => System.Console.Write(value);
}