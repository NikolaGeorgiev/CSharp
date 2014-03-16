using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCopyRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            int symbol = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < symbol; k++)
                {
                    Console.Write("@");
                }
                symbol += 2;
                num--;
                Console.WriteLine();
            }
        }
    }
}
