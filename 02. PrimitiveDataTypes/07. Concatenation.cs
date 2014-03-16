using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Niki";
            string lName = "Georgiev";
            object fullName = fName + " " + lName;
            string allName = (string)fullName;
            Console.WriteLine(allName);
        }
    }
}
