using System;

namespace CSharpFundamental
{
    public class LearnString
    {
        public void String2()
        {
            var name = "Mamun Shuvo ";
            Console.WriteLine("Name: " + name.Trim());
            Console.WriteLine("To Upper: " + name.Trim().ToUpper());
            Console.WriteLine("To Lower: " + name.Trim().ToLower());

            var index = name.IndexOf(" ");
            Console.WriteLine("First name: " + name.Substring(0, index));
            Console.WriteLine("Last name: " + name.Substring(index+1));

            var split = name.Split(' ');
            Console.WriteLine("First Name: " + split[0]);
            Console.WriteLine("Last Name: " + split[1]);

            Console.WriteLine("After Replace: " + name.Replace("Mamun", "Abdullah"));

            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");


        }
    }
}
