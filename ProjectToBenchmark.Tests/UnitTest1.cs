using System;
using Xunit;
using ProjectToBenchmark;
using BenchmarkDotNet.Attributes;

namespace ProjectToBenchmark.Tests
{
    [MemoryDiagnoser]
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program.Main();
        }
    }
}
