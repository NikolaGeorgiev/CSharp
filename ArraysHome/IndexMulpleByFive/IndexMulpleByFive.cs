using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexMulpleByFive
{
    class IndexMulpleByFive
    {
        static void Main(string[] args)
        {
            //int[] array = new int[20];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i * 5;
            //    Console.WriteLine(array[i]);
            //}


            //int[] myArr = new int[20];
            //int n = 0;
            //while (n < myArr.Length)
            //{
            //    myArr[n] = n * 5;
            //    Console.WriteLine(myArr[n]);
            //    n++;
            //}


            int[] myArr = new int[20];
            int n = 0;
            foreach (int element in myArr)
            {
                myArr[n] = n * 5;
                Console.WriteLine(myArr[n]);
                n++;
            }
        }
    }
}
