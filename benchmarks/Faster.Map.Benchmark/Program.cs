﻿using System.Runtime.InteropServices;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;

namespace Faster.Map.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            //  TypeLayout.PrintLayout<Entry<string, string>>();

            // //  TypeLayout.PrintLayout<MultiEntry<int, int>>();
           
            BenchmarkRunner.Run<AddAndResizeBenchmark>();

            // BenchmarkRunner.Run<GetBenchmark>();
            // 
            // BenchmarkRunner.Run<AddBenchmark>();
            // BenchmarkRunner.Run<GetBenchmark>();
            // BenchmarkRunner.Run<RemoveBenchmark>();
            // BenchmarkRunner.Run<UpdateBenchmark>();
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct InfoByte
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public byte Next { get; set; }

        //
        public int Hashcode;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public struct Entry<TKey, TValue>
    {
        /// <summary> 
        /// Gets or sets the hashcode.
        /// </summary>
        /// <value>
        /// The hashcode.
        /// </value>
        public int Hashcode { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public TKey Value { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public TValue Key { get; set; }

    }
}
