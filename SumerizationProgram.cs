using System;
using System.Collections.Generic;

namespace WorkingTest
{
    internal partial class Program
    {
        public partial class StringsProgram {
            public class SumerizationProgram {
                public void m2()
                {
                    var sentence = "This is Going to be a really really really really really really long text";
                    const int maxlength = 20;


                    if (sentence.Length < maxlength)
                    {
                        Console.WriteLine(sentence);
                    }
                    else {
                        var words = sentence.Split(' ');
                        var totalCharacture = 0;
                        var summeryWords = new List<string>();

                        foreach (var item in words)
                        {

                            summeryWords.Add(item);
                            totalCharacture += item.Length + 1;
                            if (totalCharacture > maxlength)
                                break;
                        }
                        var summary = String.Join(" ",summeryWords)+"......";
                        Console.WriteLine(summary);
                    }

                }

               
            
            
            }
        
        }
    }
}
