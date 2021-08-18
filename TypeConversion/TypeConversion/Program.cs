using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;

            Console.WriteLine(value: i);

            int ii = 1;
            byte bb = (byte)ii;

            Console.WriteLine(value: bb);

        }
    }
}
