using System;
using System.Collections.Generic;

namespace Arrays
{
    internal partial class Program
    {
        public partial class ListExample {
            public void m2()
            {
                var numbers = new List<int>() { 1,2,3,4};
                numbers.Add(1);
                numbers.AddRange(new int[3] { 5,6,7}) ;

                foreach (int i in numbers)
                    Console.Write(i+","); // 1,2,3,4,1,5,6,7
                    
                    Console.WriteLine( );
               Console.WriteLine("Index of 1 is : "+ numbers.IndexOf(1)); // 0
                Console.WriteLine("Last Index Of 1 is : "+numbers.LastIndexOf(1)); //4

                Console.WriteLine("Count : "+ numbers.Count);

               numbers.Remove(2);
                foreach (int i in numbers)
                    Console.Write( i + ","); //1,3,4,1,5,6,7

                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");

                for(var i=0;i<numbers.Count;i++)
                {
                    if (numbers[i] == 1)
                        numbers.Remove(numbers[i]);
                }

                foreach (var number in numbers)
                    Console.WriteLine(number); // 3,4,5,6,7


                numbers.Clear();
                Console.WriteLine("Numbers Count :-  "+numbers.Count); // 0
                
            
            }
        }
    }
}
