using System.Text;

namespace ProgrammingChallenges.Csharp.Console.Core;

internal sealed class TestChallengeIO : IChallengeIO
{
    private readonly Queue<string?> _inputs = new();
    private readonly StringBuilder _output = new();

    public string Output => _output.ToString().Trim('\r', '\n');
    public string? ReadLine() => _inputs.Count > 0 ? _inputs.Dequeue() : null;
    public void WriteLine(object? value) => _output.AppendLine(value?.ToString());
    public void AddInputs(params string?[] inputs)
    {
        foreach (var input in inputs)
        {
            _inputs.Enqueue(input);
        }
    }
}