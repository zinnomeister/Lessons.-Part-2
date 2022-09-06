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

        static int Sum(List<int> data)
        {
            return data.Sum();
        }

        static void Main(string[] args)
        {
            int result2 = Sum(2, 4);
            Console.WriteLine(result2);

            int result3 = Sum(2, 4, 7);
            Console.WriteLine(result3);


            int result4 = Sum(new List<int>() { 10, 15, 5 });
            Console.WriteLine(result4);

            Console.ReadLine();
        }
    }
}