namespace Draft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int.TryParse(str, out int result);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}