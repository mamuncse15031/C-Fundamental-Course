using System;

namespace TypeConversion
{
    class Program
    {
        public static void Main()
        {
            //Implicit Conversion
            byte b = 1;
            int i = b;

            Console.WriteLine(value: i);

            //Explicit Conversion
            int ii = 1;
            byte bb = (byte)ii;

            Console.WriteLine(value: bb);

            //Compatible conversion
            string str = "1234";
            int a = Convert.ToInt32(str);

            Console.WriteLine(value: a);

            //Non-Compatible Conversion (Exception Handling)
            try
            {
                string strrr = "1000";
                byte c = Convert.ToByte(strrr);

                Console.WriteLine(c);
            }
            catch (Exception)
            {
                Console.WriteLine("The conversion is not possible!!!");
            }


            try
            {
                string st = "True";
                bool d = Convert.ToBoolean(st);

                Console.WriteLine(d);
            }
            catch (Exception)
            {
                Console.WriteLine("The conversion is not possible!!!");
            }
            

        }
    }
}
