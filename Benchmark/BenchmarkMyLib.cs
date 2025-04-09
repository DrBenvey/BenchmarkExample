using BenchmarkDotNet.Attributes;
using MyLib;

namespace Benchmark
{
    [MemoryDiagnoser]
    public class BenchmarkMyLib
    {
        [Params(1, 1000)]  // Size of the array
        public int N;
        private readonly string searchStr = "benvey";
        private string[]? _strings;

        [GlobalSetup]
        public void Setup()
        {
            _strings = new string[N];
            for (int i = 0; i < N; i++)
            {
                _strings[i] = RandomHelper.RandomLatinString(123);
            }
        }

        [Benchmark]
        public void IsIndexOdIsZeroInLoop()
        {
            foreach (string input in _strings!)
            {
                input.IsIndexOdIsZero(searchStr);
            }
        }

        [Benchmark]
        public void IsStartsWithInLoop()
        {
            foreach (string input in _strings!)
            {
                input.IsStartsWith(searchStr);
            }
        }
    }
}