using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffString
{
    class Program
    {
        static void Main(string[] args)
        {
            string strQuot = "The \"use\" of quotations causes difficulties.";
            string strEt = @"""The ""use"" of quotations causes difficulties.""";
            Console.WriteLine(strQuot + "\n" + strEt);
        }
    }
}
