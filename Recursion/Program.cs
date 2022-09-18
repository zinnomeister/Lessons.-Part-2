namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trend(25);
                

            Console.ReadKey();
        }

        static void Trend(int i)
        {
           

            
            Console.WriteLine(i);

            if (i >= 100)
                return;

            i++;
            Trend(i);
        }
    }
}