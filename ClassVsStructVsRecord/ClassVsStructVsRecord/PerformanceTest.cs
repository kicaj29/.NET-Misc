using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStructVsRecord
{
    internal class PerformanceTest
    {
        const int iterationsCount = 1_000_000;

        public void RunTest()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--Performance test---");

            Stopwatch sw = new Stopwatch();
            sw.Restart();
            MeasureClass();
            Console.WriteLine($"MeasureClass: {sw.Elapsed.TotalMilliseconds}[ms]");

            sw.Restart();
            MeasureRecordClass();
            Console.WriteLine($"MeasureRecordClass: {sw.Elapsed.TotalMilliseconds}[ms]");

            sw.Restart();
            MeasureStruct();
            Console.WriteLine($"MeasureStruct: {sw.Elapsed.TotalMilliseconds}[ms]");

            sw.Restart();
            MeasureRecordStruct();
            Console.WriteLine($"MeasureRecordStruct: {sw.Elapsed.TotalMilliseconds}[ms]");
        }

        internal bool MeasureClass()
        {
            // access array elements
            var list = new PersonAsClass[iterationsCount];
            for (int i = 0; i < iterationsCount; i++)
            {
                list[i] = new PersonAsClass("Jacek", new DateOnly(2000, 10, 22));
            }
            return true;
        }

        internal bool MeasureRecordClass()
        {
            // access array elements
            var list = new PersonAsRecordClass[iterationsCount];
            for (int i = 0; i < iterationsCount; i++)
            {
                list[i] = new PersonAsRecordClass("Jacek", new DateOnly(2000, 10, 22));
            }
            return true;
        }

        internal bool MeasureStruct()
        {
            // access array elements
            var list = new PersonAsStruct[iterationsCount];
            for (int i = 0; i < iterationsCount; i++)
            {
                list[i] = new PersonAsStruct("Jacek", new DateOnly(2000, 10, 22));
            }
            return true;
        }

        internal bool MeasureRecordStruct()
        {
            // access array elements
            var list = new PersonAsRecordStruct[iterationsCount];
            for (int i = 0; i < iterationsCount; i++)
            {
                list[i] = new PersonAsRecordStruct("Jacek", new DateOnly(2000, 10, 22));
            }
            return true;
        }
    }
}
