namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today);

            DayOfWeek dayOfWeek = DayOfWeek.Monday;
            Console.WriteLine((int)dayOfWeek);

            Console.WriteLine((DayOfWeek)4);

            DayOfWeek nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);

            int value = 5;
            if (Enum.IsDefined(typeof(DayOfWeek), value))
            {
                dayOfWeek = (DayOfWeek)value;
            }

            else
            {
                throw new Exception("Invalid DayOfWeek value!");
            }

            Console.WriteLine("New day: " + dayOfWeek);
            Console.ReadLine();
            Console.Clear();

            var values = Enum.GetValues(typeof(DayOfWeek));

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.Clear();

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                case DayOfWeek.Sunday:
                    break;
                default:
                    break;
            }

            Console.ReadLine();




        }

        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;
            return DayOfWeek.Monday;
        }

    }
}