using System;

namespace HW_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5, 6 };
            PrintByRecursion(Array);
            Console.ReadLine();

            int result = SumOfElements(Array);
            Console.WriteLine("Sum of elements: " + result);
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Input integer: ");
            int input = int.Parse(Console.ReadLine());
            int result2 = SumInInteger(input);
            Console.WriteLine("Sum of elements: " + result2);
            Console.ReadLine();

            int result3 = SumInIntegerShort(input);
            Console.WriteLine("Sum of elements (short method): " + result3);
            Console.ReadLine();

        }

        static void PrintByRecursion(int[] a, int i = 0)
        {
            if (i < a.Length)
            {
                Console.WriteLine(a[i]);
                PrintByRecursion(a, i + 1);
            }
        }

        static int SumOfElements(int[] array, int i = 0)
        {
            if (i >= array.Length)
                return 0;

            //int result = SumOfElements(array, i + 1);

            //return array[i] + result;

            return array[i] + SumOfElements(array, i + 1);

        }

        static int SumInInteger(int input)
        {
            if (input < 10)
                return input;

            int digit = input % 10;
            int nextValue = input / 10;
            return digit + SumInInteger(nextValue);
        }

        static int SumInIntegerShort(int input)
        {
            if (input < 10)
                return input;
            return input % 10 + SumInIntegerShort(input/10);
        }
    }
}