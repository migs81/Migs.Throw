// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Migs.Throw.Benchmarks;

_ = BenchmarkRunner.Run<ThrowBenchmarks>();

Console.WriteLine("Press any key...");
Console.ReadKey();
