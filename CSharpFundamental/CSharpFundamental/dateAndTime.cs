using System;

namespace CSharpFundamental
{
    public class DateAndTime
    {
        public void TimeDate()
        {
            var now = DateTime.Now;
            var today = DateTime.Today;
/*            Console.WriteLine(now);
            Console.WriteLine(today);*/
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(today.ToString("yyyy MMMM dd")); //format Specifier

        }
    }
}
