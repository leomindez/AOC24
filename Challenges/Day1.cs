using AdventOfCode.Common;

namespace AdventOfCode.Challenges
{
    internal class Day1(string path) : Solution<List<List<int>>, int>(path)
    {
        internal override List<List<int>> GetInput()
        {
            var readInput = new StreamReader(this.path);
            return readInput.ReadToEnd()
                .Split(("\r\n"))
                .Select(line => line.Split("   "))
                .Aggregate(new List<List<int>>() { new(), new() },
                            (acc, line) =>
                            {
                                acc[0].Add(int.Parse(line[0]));
                                acc[1].Add(int.Parse(line[1]));
                                return acc;
                            });
        }

        internal override int Solve()
        {   
            var input = GetInput();
            input[0].Sort();
            input[1].Sort();
            return input[0]
                        .Select((value, index) => new { value, index })
                        .Aggregate(0, (acc, next) => acc += int.Abs(next.value - input[1][next.index]));
        }
    }
}
