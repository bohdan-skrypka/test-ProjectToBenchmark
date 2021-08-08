using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace ProjectToBenchmark.Benchmark
{
    [MemoryDiagnoser]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net461)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net462)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net47)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net471)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net472)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net48)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp20)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp21)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp22)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp30)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(runtimeMoniker: RuntimeMoniker.NetCoreApp31)]
    [KeepBenchmarkFiles]
    public class AlgorithmToBenchmark
    {
        [Benchmark]
        public void ClassTobenchmark()
        {
            Program.ListWithClass();
        }

        [Benchmark]
        public void StructTobenchmark()
        {
            Program.ListWithStruct();
        }

        [Benchmark]
        public void GrowableArrayTobenchmarkWithClass()
        {
            Program.GrowableArrayWithClass();
        }

        [Benchmark]
        public void GrowableArrayTobenchmarkWithStruct()
        {
            Program.GrowableArrayWithStruct();
        }
    }
}