namespace Null
{
    class Program
    {
        static void Main(string[] args)
        {
            Null();
            Console.Clear();
            Quantity();
        }

        static void Null()
        {
            string str = null;
            Console.WriteLine(str ?? "No data");
            Console.ReadKey();
        }

        static void Quantity()
        {
            string str = "qwehlb wareljfbnajwe awlje";
            Console.WriteLine("Quantity of symbols: " + str.Length);
            Console.ReadKey();

            string str2 = null;
            string result = str2 ?? "";
            Console.WriteLine("Quantity of symbols: " + result.Length);
            Console.ReadKey();

            string str3 = null;
            string result2 = str3 ?? string.Empty;
            Console.WriteLine("Quantity of symbols: " + result.Length);
            Console.ReadKey();

            string str4 = null;
            str4 ??= string.Empty;
            Console.WriteLine("Quantity of symbols: " + result.Length);
            Console.ReadKey();

            int[] newArray = {23,45,56 };
            newArray ??= new int[0];
            Console.WriteLine("Quantity of elements in array: " + newArray.Length);
            Console.ReadKey();

            int[] newArray2 = null;
            newArray2 ??= new int[0];
            Console.WriteLine("Quantity of elements in array: " + newArray2.Length);
            Console.ReadKey();

            int[] newArray3 = new int[18];
            Console.WriteLine("Quantity of elements in array: " + (newArray3?.Length ?? 0));
            Console.ReadKey();

            int[] newArray4 = null;
            Console.WriteLine("Quantity of elements in array: " + newArray4?.Length);
            Console.ReadKey();

            int[] newArray5 = null;
            Console.WriteLine("Quantity of elements in array: " + (newArray5?.Length ?? 0));
            Console.ReadKey();


        }
    }
}