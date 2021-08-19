using System;

namespace CSharpFundamental
{
    public class Stringg
    {
        public void Strinngg()
        {
            var firstName = "Mamun";
            var lastName = "Shuvo";

            var fullName = "My full name is " + firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My full name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var numbers = new string[4] {"Abdullah", "Al", "Mamun", "Shuvo"};
            var formattedNumbers = string.Join(" ",numbers);
            Console.WriteLine(formattedNumbers+"\n");

            var text1 = "Hi John\nLook at these paths\nc:\\first\\second\nc:\\third\\fourth";
            Console.WriteLine(text1+"\n");
            var text2 = @"Hi John
Look at these paths
c:\first\second
c:\third\fourth";
            Console.WriteLine(text2);

        }
    }
}
