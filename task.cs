using System;
using System.Collections.Generic;

namespace Arrays
{
    internal partial class Program
    {
        public partial class ListExample {
            public class task {

                public void m3()
                {
                    Console.WriteLine("Enter Name:");
                    var name = Console.ReadLine();
                    var index = new List<int>();

                    var array = new char[name.Length];
                    for (var i = name.Length; i > 0; i--)
                        array[name.Length - i] = name[i - 1];

                    Console.WriteLine("Reversed Name:");
                    var reversed = new string(array);
                    Console.WriteLine(reversed);




                }
            
            }
        }
    }
}
