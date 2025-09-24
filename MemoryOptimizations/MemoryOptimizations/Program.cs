// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using MemoryOptimizations;

Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<ArrayBenchmark>();