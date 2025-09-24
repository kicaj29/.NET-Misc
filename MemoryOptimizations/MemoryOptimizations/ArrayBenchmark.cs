using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MemoryOptimizations
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net80)]
    public class ArrayBenchmark
    {
        [Benchmark]
        public void NormalArray()
        {
            for (int a = 0; a < 10; a++)
            {
                var intArray = new int[1000];
                for (int i = 0; i < 1000; i++)
                {
                    intArray[i] = i;
                }
            }
        }

        [Benchmark]
        public void ArrayPool()
        {
            var shared = ArrayPool<int>.Shared;
            for (int a = 0; a < 10; a++)
            {
                var intArray = shared.Rent(1000);
                for (int i = 0; i < 1000; i++)
                {
                    intArray[i] = i;
                }
                shared.Return(intArray);
            }
        }
    }
}
