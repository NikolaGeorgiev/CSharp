using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Byte min and max:" + byte.MinValue + " " + byte.MaxValue);
            Console.WriteLine("Sbyte min and max:" + sbyte.MinValue + " " + sbyte.MaxValue);
            Console.WriteLine("Short min and max:" + short.MinValue + " " + short.MaxValue);
            Console.WriteLine("Ushort min and max:" + ushort.MinValue + " " + ushort.MaxValue);
            Console.WriteLine("Int min and max:" + int.MinValue + " " + int.MaxValue);
            Console.WriteLine("Uint min and max:" + uint.MinValue + " " + uint.MaxValue);
            Console.WriteLine("Long min and max:" + long.MinValue + " " + long.MaxValue);
            Console.WriteLine("Float min and max:" + float.MinValue + " " + float.MaxValue);
            Console.WriteLine("Double min and max:" + double.MinValue + " " + double.MaxValue);
            Console.WriteLine("Decimal min and max:" + decimal.MinValue + " " + decimal.MaxValue);
        }
    }
}
