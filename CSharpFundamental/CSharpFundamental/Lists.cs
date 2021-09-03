using System;
using System.Collections.Generic;

namespace CSharpFundamental
{
    public class Lists
    {
        public void Listss()
        {
            var numbers = new List<int>() {1, 3, 5, 6, 7};
            numbers.Add(1);
            numbers.AddRange(new int[3] {2,4,9});

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Count: " + numbers.Count);

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
