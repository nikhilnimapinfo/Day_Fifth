using System;

namespace Day_Time_Program
{
    internal partial class Program
    {
        public class TimeSpanProgram {

            public void m2() 
            {
                // Creating 
                var timespan = new TimeSpan(1,2,3);
                var timespan1 = new TimeSpan(1, 0, 0);

                Console.WriteLine(timespan);
                Console.WriteLine(timespan1);

                var start = DateTime.Now;
                var end = DateTime.Now.AddMinutes(2);
                var duration = end - start;
                Console.WriteLine("Duration : "+duration);

                // Properties
                Console.WriteLine("Minutes : "+ timespan.Minutes);
                Console.WriteLine("Total Minutes : "+ timespan.TotalMinutes);

                //Add
                Console.WriteLine("Add Example : " +timespan.Add(TimeSpan.FromMinutes(8)));
                Console.WriteLine("Substract Example : " +timespan.Subtract(TimeSpan.FromMinutes(8)));


                // ToString
                Console.WriteLine("ToString : " + timespan.ToString());

                //Parse
                Console.WriteLine("Parse : "+ TimeSpan.Parse("01:02:03"));
                            
            }
        }
    }
}
