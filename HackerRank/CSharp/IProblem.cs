namespace HackerRank.CSharp.Problems
{
    public interface IProblem
    {
        string Name { get; }
        string Url { get; }
        void Run();
    }
}