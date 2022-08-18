using BenchmarkDotNet.Attributes;

namespace CSharpPerformancePlaybook.Benchmarker
{
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(BenchmarkDotNet.Mathematics.NumeralSystem.Arabic)]
    public class Loops
    {

        //string[] names = { "Chris", "Bob", "Mark", "Sam", "Cindy" };


        public List<string> Names
        {
            get
            {
                return Resourses.Resource1._1000firstnames.Split('\n').ToList();
            }
        }

        [Benchmark]
        public void ForLoop()
        {
            var names = Names;
            for (int i = 0; i < names.Count; i++)
            {
                var x = names[i];
            }
        }

        [Benchmark]
        public void ForEachLoop()
        {
            var names = Names;
            foreach (var item in names)
            {
                var x = item;
            }
        }
    }
}
