using System;

namespace CSharpFundamental
{
    public class ArrayCs
    {
        public void Array()
        {
             var numbers = new int[3] {1,2,3};

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flag = new bool[3];
            flag[1] = true;

            Console.WriteLine(flag[0]);
            Console.WriteLine(flag[1]);
            Console.WriteLine(flag[2]);

            var names = new string[3] {"Abdullah", "Mamun", "Shuvo"};

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}
