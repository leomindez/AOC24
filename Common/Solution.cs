namespace AdventOfCode.Common
{
    internal abstract class Solution<I>(string path)
    {
        internal readonly string path = path;

        internal abstract I GetInput();
        internal abstract void Solve();
    }
}
