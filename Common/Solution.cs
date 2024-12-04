namespace AdventOfCode.Common
{
    internal abstract class Solution<I,O>(string path)
    {
        internal readonly string path = path;

        internal abstract I GetInput();
        internal abstract O Solve();
    }
}
