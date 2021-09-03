using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamental
{
    public class Array2
    {
        public void Arrray2()
        {
            var numbers = new int[6] {3, 6, 8, 5, 4, 8};

            //Length
            var length = numbers.Length;

            Console.WriteLine(length);

            //IndexOF
            int indexOf = Array.IndexOf(numbers, 4);
            Console.WriteLine(indexOf);

            //Copy
            var numbers2 = new int[3];
            Array.Copy(numbers, numbers2, 3);

            Console.WriteLine("After Copy: ");
            foreach (var i in numbers2)
            {
                Console.WriteLine(i);
            }

            //Sort
            Array.Sort(numbers);
            Console.WriteLine("After Sort: ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse
            Array.Reverse(numbers2);
            Console.WriteLine("After Reverse: ");
            foreach (var n in numbers2)
            {
                Console.WriteLine(n);
            }
        }

    }
}
