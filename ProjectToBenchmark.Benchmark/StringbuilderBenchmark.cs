using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Collections.Generic;
using System.Text;

namespace ProjectToBenchmark.Benchmark
{
    [KeepBenchmarkFiles(true),
     MemoryDiagnoser,
     SimpleJob(RuntimeMoniker.NetCoreApp31, -1, -1, -1, -1, null, false)]
    public class StringbuilderBenchmark
    {
        [Params(10, 100, 1000, 10_000)]
        public static int N;

        public static string str = "jhjjkakjkj asdjasjkasjkkj jajiiieie hjjjjs jjjjjvnnvbb " +
            "kkdsfjsddsfosdofsdjkjlxjlk ll ldsldl lorotiiyi ollgl l" +
            "lliiiyiykfkjgjll;;km;''lkdskfksji49030" +
            "sdflksdkdsk kdsfk lfloo4959 kfdl l;df 599olfdl dfk 9fd9r999  odof fl df9994o fdo 9fd9 o4]" +
            "b hhshsh uuwuui iiahh kkakshh hgh gfgfg gasjj gjjgj";

        public static string ConcatString(string unsortedString)
        {
            List<int> list = new List<int>(N);
            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }

            list.Sort();

            var str = "";
            foreach (var digit in list)
            {
                str += digit + " ";
            }

            return str;
        }

        public static string StringBuilder(string unsortedString)
        {
            List<int> list = new List<int>(N);
            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }

            list.Sort();

            StringBuilder builder = new StringBuilder(capacity: list.Count);
            foreach (var digit in list)
            {
                builder.Append(digit);
            }

            return builder.ToString();
        }

        [Benchmark]
        public void StringBuilderToBenchmark()
        {
            var t = StringBuilder(str);
        }

        [Benchmark(Baseline = true)]
        public void StringConcatToBenchmark()
        {
            var t = ConcatString(str);
        }
    }
}