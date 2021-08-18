using System;
using System.Runtime.InteropServices;
using CSharpFundamental.Math;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            var mamun = new Person();
            mamun.FirstName = "Mamun";
            mamun.LastName = "Shuvo";
            mamun.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
        
    }
}
