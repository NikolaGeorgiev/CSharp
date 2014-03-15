using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAlg
{
    class BinarySearchAlg
      {
    //    static int BinarySearch(int[] array, int key)
    //    {
    //        Array.Sort(array);
    //        int iMax = array.Length - 1;
    //        int iMin = 0;
    //        while(iMax >= iMin)
    //        {
    //            int iMidpoint = (iMin + iMax) / 2;
    //            if(array[iMidpoint] < key)
    //            {
    //                iMin = iMidpoint + 1;
    //            }
    //            else if(array[iMidpoint] > key)
    //            {
    //                iMax = iMidpoint - 1;
    //            }
    //            else
    //            {
    //                return iMidpoint;
    //            }
    //        }
    //        return -1;
        //}

        static void Main()
        {
            //int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //int searchedNumber = int.Parse(Console.ReadLine());
            //int startSearch = 0;
            //int endSearch = array.Length - 1;
            //int middle;
            //while(startSearch <= endSearch)
            //{
            //    middle = (startSearch + endSearch) / 2;
            //    if(array[middle] == searchedNumber)
            //    {
            //        Console.WriteLine("Index is: {0}.", middle);
            //        break;
            //    }
            //    if(array[middle] < searchedNumber)
            //    {
            //        startSearch = middle + 1;
            //    }
            //    if(array[middle] > searchedNumber)
            //    {
            //        endSearch = middle - 1;
            //    }
            //}





            //int[] myArray = { 4, 3, 1, 4, 2, 5, 8, 21, 13, 180 };
            //int key = 8;
            //Console.WriteLine(BinarySearch(myArray, key));





            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            int x = 34;

            for (int l = 0, r = arr.Length - 1; l <= r; )
            {
                int m = l + (r - l) / 2;
                if (arr[m] < x)
                {
                    l = m + 1;
                }
                else if (arr[m] > x)
                {
                    r = m - 1;
                }
                else
                {
                    Console.WriteLine(m);
                    return;
                }
            }
        }
    }
}
