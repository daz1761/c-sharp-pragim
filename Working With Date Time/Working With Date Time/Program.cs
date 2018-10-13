using System;

namespace Working_With_Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            Console.WriteLine(myValue.AddDays(3).ToShortDateString());  // add 3 days to the current date 11/8/18
            Console.WriteLine(myValue.AddHours(3).ToShortTimeString()); // add 3 hours to the current time
            Console.WriteLine(myValue.Month.ToString());

            DateTime birthday = new DateTime(1977, 1, 27);

            Console.WriteLine(birthday.ToString() );

            DateTime ellenBday = DateTime.Parse("5/6/78");
            TimeSpan myAge = DateTime.Now.Subtract(birthday);

            Console.WriteLine(myAge.TotalDays.ToString()); // return the amount of days that have passed since I was born! 15168

            Console.ReadLine();
        }
    }
}
