using System;
using System.Collections.Generic;
using System.Text;

namespace EighthNov
{
    internal class DateAndTime1
    {
        DateTime dateTime = new DateTime();
        DateTime time = new DateTime(2000, 06, 05);
        DateTime dt1 = new DateTime(2022, 11, 8, 11, 49, 0);
        DateTime dt = new DateTime(2022, 11, 9);
        DateTime shortDate = new DateTime(2022, 06, 05, 5, 30, 0);






        public void datetimeeval() {
            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(time.ToString());
            Console.WriteLine("Complete date: " + dt1.ToString());
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
            Console.WriteLine();
            Console.WriteLine("Short Date: " + shortDate.ToString("d"));
            Console.WriteLine(shortDate.ToString("g"));
            Console.WriteLine(shortDate.ToString("G"));
            Console.WriteLine(shortDate.ToString("O"));
            Console.WriteLine(shortDate.ToString("f"));
            Console.WriteLine(shortDate.ToString("M"));

            Console.WriteLine();
            Console.WriteLine(shortDate.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(shortDate.ToString("dd/MM/yyyy mm:hh"));
            Console.WriteLine(shortDate.ToString("yyyy/dd/MM mm:HH"));
        }
    }
}