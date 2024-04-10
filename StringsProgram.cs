using System;

namespace WorkingTest
{
    internal partial class Program
    {
        public partial class StringsProgram {
            public void m1()
            {
                var FullName = "Nimap Infotech";
                Console.WriteLine("Lower Case : "+FullName.ToLower());
                Console.WriteLine("Upper CAse : "+FullName.ToUpper());
                Console.WriteLine("Trim :'{0}'",FullName.Trim());
                

                //IndexOf()
                var index=FullName.IndexOf (' ');
                var firstName = FullName.Substring(0, index);
                var lastname = FullName.Substring(index + 1);
                Console.WriteLine("First Name: " + firstName );
                Console.WriteLine("Last Name : " + lastname);


                //Split()
                var names = FullName.Split(' ');
                 Console.WriteLine("First Name :- "+names[0]);
                Console.WriteLine("Last Name :- "+ names[1]);

                //Replace()
                Console.WriteLine("Replace :- "+(FullName.Replace("Nimap","Infotech")));

                //Check String is Present Or Not
                if (String.IsNullOrWhiteSpace(" "))
                    Console.WriteLine("Invald");

                var str = "45";

                 var by= Convert.ToByte(str);
                Console.WriteLine(by);


                float price = 29.95f;
                Console.WriteLine(price.ToString("C"));

            }
        
        }
    }
}
