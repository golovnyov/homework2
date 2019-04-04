using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        private const int InsertionCount = 1000000;
        private const int Sparseness = 100;

        static void Main(string[] args)
        {

            BenchmarkRunner.Run<Program>();

            Console.ReadLine();
        }

        [Benchmark]
        public void RunPlainIntHashInsertion()
        {
            var customDataStructure = new CustomDataStructure(x => { return x; }, InsertionCount, Sparseness);

            for (int i = 0; i <= (InsertionCount * Sparseness) - Sparseness; i+=100)
            {
                customDataStructure[i] = i;
            }
        }

        [Benchmark]
        public void RunComplex1HashInsertion()
        {
            var customDataStructure = new CustomDataStructure(x => { return ((x >> 16) ^ x) * 0x45d9f3b; }, InsertionCount, Sparseness);

            for (int i = 0; i <= (InsertionCount * Sparseness) - Sparseness; i += 100)
            {
                customDataStructure[i] = i;
            }
        }

        [Benchmark]
        public void RunComplex2HashInsertion()
        {
            var customDataStructure = new CustomDataStructure(x => { return 101 * ((x >> 24) + 101 * ((x >> 16) + 101 * (x >> 8))) + x; }, InsertionCount, Sparseness);

            for (int i = 0; i <= (InsertionCount * Sparseness) - Sparseness; i += 100)
            {
                customDataStructure[i] = i;
            }
        }

        [Benchmark]
        public void RunBadHashInsertion()
        {
            var randomizer = new Random();

            var customDataStructure = new CustomDataStructure(x => { return randomizer.Next(0, 10000); }, InsertionCount, Sparseness);

            for (int i = 0; i <= (InsertionCount * Sparseness) - Sparseness; i += 100)
            {
                customDataStructure[i] = i;
            }
        }

        [Benchmark]
        public void RunWithoutGapInsertion()
        {
            var randomizer = new Random();

            var customDataStructure = new CustomDataStructure(null, InsertionCount, Sparseness);

            for (int i = 0; i < InsertionCount; i++)
            {
                customDataStructure[i] = i;
            }
        }
    }
}
