using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIICharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
