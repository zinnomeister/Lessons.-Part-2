using System;
using System.Diagnostics;

namespace Benchmark
{
    class Program
    {

        struct Point
        {
            public int x;
            public int y;
            public int z;
            public decimal X;
            public decimal Y;
            public decimal Z;

        }

        static void SlowMoreMemory(Point value)
        { 
        
        }
        static void FastLessMemory(in Point value)
        { 
        
        }
        static void Main(string[] args)
        {
            Point point = new Point();

            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < int.MaxValue; i++)
            {
                SlowMoreMemory(point);
            }
            stopwatch.Stop();
            Console.WriteLine($"SlowMoreMemory{stopwatch.ElapsedMilliseconds}");

            stopwatch.Restart();
            for (int i = 0; i < int.MaxValue; i++)
            {
                FastLessMemory(point);
            }
            stopwatch.Stop();
            Console.WriteLine($"FastLessMemory{stopwatch.ElapsedMilliseconds}");



            Console.ReadLine();
        }
    }
}