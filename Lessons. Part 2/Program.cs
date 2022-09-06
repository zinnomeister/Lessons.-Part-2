using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Input symbols: ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Input quantity of symbols: ");
            uint symbolsCount = uint.Parse(Console.ReadLine());
            PrintConsole(symbol, 10);
            Console.ReadLine();
        }
        static void PrintConsole (string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}