using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace Params
{
    internal class Program
    {
        static int Sum(params int[] parameters)
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }

        static void Test(params object[] parameters)
        {
            string message = "Type: {0}\t, Value: {1}";
            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType, item);
            }
        }

        static void Main(string[] args)
        {
            int result = Sum(25, 23, 456, 234, 34, -5);
            Console.WriteLine(result);
            Console.ReadKey();

            Console.Clear();

            Test("test", 5, 3.45, 't',true);
            Console.ReadKey();

        }
    }
}