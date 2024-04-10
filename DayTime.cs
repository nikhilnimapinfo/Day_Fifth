using System;

namespace Day_Time_Program
{
    internal partial class Program
    {
        public class DayTime {

            public void m1()
            {
                var daytime = new DateTime(2015,1,1);
                var now = DateTime.Now;
                var today = DateTime.Today;

                Console.WriteLine("Hour : "+now.Hour);
                Console.WriteLine("Minute : "+now.Minute);
                Console.WriteLine("Today : "+today);
                Console.WriteLine("------------------------------------------------------------");

                var tomarrow = now.AddDays(1);
                var yesterday = now.AddDays(-1);

                Console.WriteLine(now.ToLongDateString());
                Console.WriteLine(now.ToShortDateString());
                Console.WriteLine(now.ToLongTimeString());
                Console.WriteLine(now.ToShortTimeString());

                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine(now.ToString());
                Console.WriteLine(now.ToString("yyyy-mm-dd  hh-mm"));

                Console.WriteLine("Tomarrow Date Time : "+tomarrow);
                Console.WriteLine("Yesterday Date Time :"+yesterday);
          

            }
        }
    }
}
