using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamental
{
    public class LearnStringbulder
    {
        public void Builder()
        {
            var builder = new StringBuilder();

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Hello World")
                .AppendLine()
                .Append('-', 10);

            Console.WriteLine(builder);
        }
    }
}
