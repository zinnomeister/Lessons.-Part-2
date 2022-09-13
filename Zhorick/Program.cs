using System;

namespace Zhorick
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers (input, than press Enter):\n");
            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Number{i + 1}:\t" + numbers[i] + "\n");
            }
            List<int> firstPartList = numbers.ToList().GetRange(0, 3);
            List<int> secondPartList = numbers.ToList().GetRange(3, 3);

            if (firstPartList.Sum() == secondPartList.Sum())
                Console.WriteLine("\nYou won!");
            else
                Console.WriteLine("\nTry again!");

            Console.ReadKey();
        }
    }
}