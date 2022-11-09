using System;
using System.Collections.Generic;
using System.Text;

namespace EighthNov
{
    internal class DateAndTime
    {
        DateTime dt = new DateTime(); //creating the date and time object
                                      //defualt value of date and time 
                                      //maximum value of data and time 31-12-9999 11:59:59

        DateTime dt1 = new DateTime(2000, 12, 15);//assigning year,month,day
        DateTime dt2 = new DateTime(2000, 12, 15, 12, 20, 01);//assigning with year ,month,day,hour,min,sec
        DateTime dt3 = new DateTime(2000, 12, 15, 12, 20, 01, DateTimeKind.Utc);

        DateTime current = DateTime.Now; //current date and time
        DateTime Today = DateTime.Today;

        DateTime current1 = DateTime.UtcNow;

        DateTime dt4 = new DateTime(2000, 10, 5, 5, 0, 0);
        DateTime dt5 = new DateTime(2000, 10, 5, 5, 0, 0);



        public void Inspect() {
            Console.WriteLine(this.dt);
            Console.WriteLine(this.dt1);
            Console.WriteLine(this.dt2);
            Console.WriteLine(this.dt3);

            Console.WriteLine(this.current);
            Console.WriteLine(this.current1);

            Console.WriteLine(this.Today);

            //Ticks:is date and time expressed in the non zero seconds
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);

            Console.WriteLine(this.current1 - this.current); //not be in negative it should throw an exception

            Console.WriteLine(this.dt5 - this.dt4);





        }
    }
}
