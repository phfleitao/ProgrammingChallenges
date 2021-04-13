namespace HackerRank
{
    public interface IProblem
    {
        string Name { get; }
        string Url { get; }
        void Run();
    }
}