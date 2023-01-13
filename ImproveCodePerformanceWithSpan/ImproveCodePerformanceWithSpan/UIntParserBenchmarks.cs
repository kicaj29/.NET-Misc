using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using ImproveCodePerformanceWithSpan;


BenchmarkRunner.Run<UIntParserBenchmarks>();

namespace ImproveCodePerformanceWithSpan
{

    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class UIntParserBenchmarks
    {
        // We want to avoid allocating arrays to fill during benchmarks
        // thus s_NbUInt pre-determines their length
        const int s_NbUInt = 4;
        const string s_CommaSeparatedUInt = "163,496,691,1729";

        uint[] m_ArrayToFill1 = new uint[s_NbUInt];
        [Benchmark(Baseline = true)]
        public void GetUIntArrayWithSplit()
        {
            GetUIntArrayWithStringSplit(s_CommaSeparatedUInt, m_ArrayToFill1);
        }

        uint[] m_ArrayToFill2 = new uint[s_NbUInt];
        [Benchmark]
        public void GetUIntArrayWithSpan()
        {
            GetUIntArrayWithSpan(s_CommaSeparatedUInt, m_ArrayToFill2);
        }

        uint[] m_ArrayToFill3 = new uint[s_NbUInt];
        [Benchmark]
        public void GetUIntArrayWithAstuteParsing()
        {
            GetUIntArrayWithAstuteParsing(s_CommaSeparatedUInt, m_ArrayToFill3);
        }

        static uint[] GetUIntArrayWithStringSplit(string commaSeparatedUInt, uint[] arrayToFill)
        {
            // Split() allocates an array and 4x strings
            string[] arrayOfString = commaSeparatedUInt.Split(',');
            var length = arrayOfString.Length;
            for (int i = 0; i < length; i++)
            {
                arrayToFill[i] = uint.Parse(arrayOfString[i]);
            }
            return arrayToFill;
        }

        static void GetUIntArrayWithSpan(string commaSeparatedUInt, uint[] arrayToFill)
        {
            // View the string as a span, so we can slice it in loop
            ReadOnlySpan<char> span = commaSeparatedUInt.AsSpan();
            int nextCommaIndex = 0;
            int insertValAtIndex = 0;
            bool isLastLoop = false;
            while (!isLastLoop)
            {
                int indexStart = nextCommaIndex;
                nextCommaIndex = commaSeparatedUInt.IndexOf(',', indexStart);

                isLastLoop = (nextCommaIndex == -1);
                if (isLastLoop)
                {
                    nextCommaIndex = commaSeparatedUInt.Length; // Parse last uint
                }

                // Get a slice of the string that contains the next uint...
                ReadOnlySpan<char> slice = span.Slice(indexStart, nextCommaIndex - indexStart);
                // ... and parse it
                uint valParsed = uint.Parse(slice);

                // Then insert valParsed in arrayToFill
                arrayToFill[insertValAtIndex] = valParsed;
                insertValAtIndex++;

                // Skip the comma for next iteration
                nextCommaIndex++;
            }
        }

        static void GetUIntArrayWithAstuteParsing(string commaSeparatedUInt, uint[] arrayToFill)
        {
            var length = commaSeparatedUInt.Length;
            int insertValAtIndex = 0;
            int valParsed = 0; // Don't use a uint to avoid casting in astute parsing formula
            for (int i = 0; i < length; i++)
            {
                char @char = commaSeparatedUInt[i];
                if (@char != ',')
                {
                    // Astute Parsing: Modify valParsed from the actual @char
                    valParsed = valParsed * 10 + (@char - '0');
                    continue;
                }
                // A comma is an opportunity to insert valParsed in arrayToFill
                arrayToFill[insertValAtIndex] = (uint)valParsed;
                insertValAtIndex++;
                valParsed = 0;
            }
            // Insert last valParsed
            arrayToFill[insertValAtIndex] = (uint)valParsed;
        }
    }
}
