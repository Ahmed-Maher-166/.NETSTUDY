namespace EnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            //    Console.WriteLine(day);
            foreach (var day in Enum.GetNames<WeekDays>())
                Console.WriteLine(day);
            string? input;
            bool ISEnum = false;
            Season Season = Season.Spring;
           while (!ISEnum)
            {
                Console.WriteLine("Enter your Season:");
                 input = Console.ReadLine();
                ISEnum = Enum.TryParse<Season>(input, true, out Season);
            }
            string Result = Season switch
            {
                Season.Spring => "From March to May",
                Season.Summer => "From June to August",
                Season.Autumn => "From September to November",
                Season.Winter => "From December to February",
                _ => "Unknown season"
            };
            Colors Colors = Colors.Blue;
            Console.WriteLine(Result);
            ISEnum = false;
            while (!ISEnum)
            {
                Console.WriteLine("Enter your Color:");
                input = Console.ReadLine();
                ISEnum = Enum.TryParse<Colors>(input, true, out  Colors);
            }
           
             Result = Colors switch
            {
                Colors.Blue or Colors.Red or Colors.Green => " is Primary Color",
                _ => "is not Primary Color"
            };
            Console.WriteLine($"Colors is {Result}");
        }
    }
}
