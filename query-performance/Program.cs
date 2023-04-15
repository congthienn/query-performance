using BenchmarkDotNet.Running;
using QueryPerformance;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<EFCompiledQueryBenchmark>();
    }
}