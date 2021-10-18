using System;

namespace IfElseDaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var dia = DateTime.Now.DayOfWeek;

            if (dia == DayOfWeek.Sunday)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Today is: {DayOfWeek.Sunday}");
                Console.WriteLine("--------------------");
            }
            else if (dia == DayOfWeek.Monday)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Today is: {DayOfWeek.Monday}");
                Console.WriteLine("--------------------");
            }
            else if (dia == DayOfWeek.Tuesday)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Today is: {DayOfWeek.Tuesday}");
                Console.WriteLine("--------------------");
            }
            else if (dia == DayOfWeek.Wednesday)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Today is: {DayOfWeek.Wednesday}");
                Console.WriteLine("--------------------");
            }
            else if (dia == DayOfWeek.Thursday)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Today is: {DayOfWeek.Thursday}");
                Console.WriteLine("--------------------");
            }
            else if (dia == DayOfWeek.Friday)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Today is: {DayOfWeek.Friday}");
                Console.WriteLine("--------------------");
            }
            else if (dia == DayOfWeek.Saturday)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Today is: {DayOfWeek.Saturday}");
                Console.WriteLine("--------------------");
            }
        }
    }
}
