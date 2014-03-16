using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int fNum = 5;
            int sNum = 10;
            int temp;

            Console.WriteLine("First num is: {0}" ,fNum);
            Console.WriteLine("Second num is: {0}", sNum);

            temp = fNum;
            fNum = sNum;
            sNum = temp;

            Console.WriteLine("First num is: {0}", fNum);
            Console.WriteLine("Second num is: {0}", sNum);
        }
    }
}
