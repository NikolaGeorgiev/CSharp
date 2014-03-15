using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            bool[] arr = new bool[(int)1E7 + 1];


            for (int i = 2; i * i <= arr.Length; i++)
                if (!arr[i])
                    for (int j = i * i; j < arr.Length; j += i) arr[j] = true;


            for (int i = 2; i < arr.Length; i++) if (!arr[i]) Console.WriteLine(i);

        }
    }
}
