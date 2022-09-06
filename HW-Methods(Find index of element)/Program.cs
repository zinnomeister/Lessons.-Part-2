using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = getRandomArray(20, 25, 45);
            int result = IndexOf(testArray, 30);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        static int[] getRandomArray(uint length, int minValue, int maxValue)
        {
            int[] newArray = new int[length];
            Random random = new Random();
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = random.Next(minValue, maxValue);
            }
            return newArray;
        }
    }
}