using System;
using System.Text;

namespace WorkingTest
{
    internal partial class Program
    {
        public partial class StringsProgram
        {
            public class StringBulderProgram
            {

                public void m3()
                {
                    var bulder = new StringBuilder("Hello World");
                    //bulder.Append('-', 20);
                    //bulder.AppendLine();
                    //bulder.Append("HEADER");
                    //bulder.AppendLine();
                    //bulder.Append('-', 20);
                    //bulder.Replace('-', '+');
                    //bulder.Remove(0, 10);
                    //bulder.Insert(0, "-", 10);

                    bulder.Append('-', 20)
                   . AppendLine()
                    .Append("HEADER")
                    .AppendLine()
                    .Append('-', 20)
                    .Replace('-', '+')
                   .Remove(0, 10)
                   .Insert(0, "-", 10);



                    Console.WriteLine(bulder);
                    Console.WriteLine("First Characture : " + bulder[10]);

                }
            }

        }
    }
}
