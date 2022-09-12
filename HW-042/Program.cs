using System;

namespace HW_042
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startArray = { 2, 4, 6, 3, 6, 7, 4, 6 };

            Console.WriteLine("Input new quantity of elements:");
            int newQuantity = int.Parse(Console.ReadLine());

            Resize(ref startArray, newQuantity);
            PrintArray(ref startArray);
            Console.ReadLine();

            AddFirst(ref startArray);
            PrintArray(ref startArray);
            Console.ReadLine();

            AddLast(ref startArray);
            PrintArray(ref startArray);
            Console.ReadLine();

            AddArbitral(ref startArray, 55, 5);
            PrintArray(ref startArray);
            Console.ReadLine();

            DeleteFirst(ref startArray);
            PrintArray(ref startArray);
            Console.ReadLine();

            DeleteLast(ref startArray);
            PrintArray(ref startArray);
            Console.ReadLine();

            DeleteArbitral(ref startArray, 2);
            PrintArray(ref startArray);
            Console.ReadLine();

        }

        static void PrintArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i] + " |");
        }

        static void Resize(ref int[] array, int newQuantity)
        {
            int[] resizedArray = new int[newQuantity];

            for (int i = 0; i < array.Length && i < resizedArray.Length; i++)
                resizedArray[i] = array[i];

            array = resizedArray;
        }

        static void AddFirst(ref int[] array)
        {
            int[] addFirstArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
                addFirstArray[i + 1] = array[i];
            array = addFirstArray;
        }

        static void AddLast(ref int[] array)
        {
            int[] addLastArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
                addLastArray[i] = array[i];
            array = addLastArray;
        }

        static void AddArbitral(ref int[] array, int value, int index)
        {
            Console.WriteLine("AddArbitral");
            int[] withArbitralArray = new int[array.Length + 1];

            withArbitralArray[index] = value;
            for (int i = 0; i < index; i++)
                withArbitralArray[i] = array[i];
            for (int i = index; i < array.Length; i++)
                withArbitralArray[i + 1] = array[i];
            array = withArbitralArray;
        }

        static void DeleteFirst(ref int[] array)
        {
            int[] deleteFirstArray = new int[array.Length - 1];
            for (int i = 1; i < array.Length; i++)
                deleteFirstArray[i - 1] = array[i];

            array = deleteFirstArray;

        }

        static void DeleteLast(ref int[] array)
        {
            int[] deleteLastArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
                deleteLastArray[i] = array[i];

            array = deleteLastArray;
        }

        static void DeleteArbitral(ref int[] array, int index)
        {
            Console.WriteLine("DeleteArbitral");
            int[] deleteArbitralArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                deleteArbitralArray[i] = array[i];
            for (int i = index + 1; i < array.Length; i++)
                deleteArbitralArray[i - 1] = array[i];
            array = deleteArbitralArray;
        }
    }
}