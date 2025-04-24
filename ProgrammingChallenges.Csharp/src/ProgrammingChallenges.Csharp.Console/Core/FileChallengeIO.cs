namespace ProgrammingChallenges.Csharp.Console.Core;

internal sealed class FileChallengeIO(string inputFilePath, string outputFilePath) : IChallengeIO
{
    private readonly StreamReader _reader = new StreamReader(inputFilePath);
    private readonly StreamWriter _writer = new StreamWriter(outputFilePath);

    public string? ReadLine() => _reader.ReadLine();

    public void WriteLine(object? value) => _writer.WriteLine(value?.ToString());

    public void Write(object? value) => _writer.Write(value?.ToString());

    public void Dispose()
    {
        _reader.Dispose();
        _writer.Flush();
        _writer.Dispose();
    }
}