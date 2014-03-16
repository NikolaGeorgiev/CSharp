using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetycompareFloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 5.01f;

            Console.WriteLine(num < 5e-6);
        }
    }
}
