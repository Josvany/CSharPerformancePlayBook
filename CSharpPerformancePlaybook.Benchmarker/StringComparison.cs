namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;

    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(BenchmarkDotNet.Mathematics.NumeralSystem.Arabic)]
    public class StringComparison
    {
        string testString = "TEST";

        [Benchmark()]
        public void EqualityComparison()
        {
            var compare = testString == "TEST";
        }

        [Benchmark()]
        public void EqualsComparison()
        {
            var compare = testString.Equals("TEST");
        }

        [Benchmark()]
        public void StringCompareComparison()
        {
            var compare = string.Compare(testString, "TEST", true);
        }

        [Benchmark()]
        public void StringLegthComparison()
        {
            var compare = testString.Length == "TEST".Length;
        }
    }
}
