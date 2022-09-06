using System;

namespace Overloads
{
    class Program
    {
        /// <summary>
        /// Sum of 2 numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Sum of 3 numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int result2 = Sum(2,4);
            Console.WriteLine(result2);

            int result3 = Sum(2,4,7);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}