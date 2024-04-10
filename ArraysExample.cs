using System;
using System.Runtime.InteropServices;

namespace Arrays
{
    internal partial class Program
    {
        public class ArraysExample
        {

            public void m1()
            {
                var arr = new int[] { 3,7,9,2,14,6};

                //Length
                Console.WriteLine(arr.Length);

                //IndexOf()
                var index=Array.IndexOf(arr, 9);
                Console.WriteLine("Index Of 9 is :- " + index);

                //Clear()
                Array.Clear(arr,0,2);
                Console.WriteLine("Effect Of Clear");
                foreach (var i in arr)
                    Console.WriteLine(i);

                //Copy()
                int[] another = new int[3];
                Array.Copy(arr,another,3);
                Console.WriteLine("Effect Of Copy()");
                foreach (var i in another)
                    Console.WriteLine(i);

                //Sort()
               Array.Sort(arr);
                Console.WriteLine("Effect of Sort ()");
                foreach (var i in arr)
                    Console.WriteLine(i);

                //Reverse()
                Array.Reverse(arr);
                Console.WriteLine("Effect Of REverse()");
                foreach (var i in arr)
                    Console.WriteLine(i);

            }
        

        }
    }
}
