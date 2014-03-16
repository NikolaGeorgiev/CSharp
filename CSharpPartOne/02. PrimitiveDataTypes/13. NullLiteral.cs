using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            double? number = null;
            Console.WriteLine("Double null type = ({0})", number);
            Console.WriteLine("Int null type = ({0})", num);
            int notNull = 5;
            Console.WriteLine("Int num = {0}", notNull);
            Console.WriteLine("Sum of Int double NULL literals and int value is = " + num + notNull + number);
        }
    }
}
