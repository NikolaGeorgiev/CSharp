using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfStrings
{
    class ArrayOfStrings
    {
        //static List<int> QuickSort(List<int> array)
        //{
        //    if(array.Count <= 1)
        //    {
        //        return array;
        //    }

        //    int pivot = array[array.Count / 2];
        //    List<int> less = new List<int>();
        //    List<int> greater = new List<int>();

        //    for (int i = 0; i < array.Count; i++)
        //    {
        //        if(i != (array.Count / 2))
        //        {
        //            if(array[i] <= pivot)
        //            {
        //                less.Add(array[i]);
        //            }
        //            else
        //            {
        //                greater.Add(array[i]);
        //            }
        //        }
        //    }
        //    return ConcatenateArrays(QuickSort(less), pivot, QuickSort(greater));
        //}

        //private static List<int> ConcatenateArrays(List<int> less, int pivot, List<int> greater)
        //{
        //    List<int> result = new List<int>();

        //    for (int i = 0; i < less.Count; i++)
        //    {
        //        result.Add(less[i]);
        //    }
        //    result.Add(pivot);

        //    for (int i = 0; i < greater.Count; i++)
        //    {
        //        result.Add(greater[i]);
        //    }
        //    return result;
        //}

        //private static void PrintList(List<int> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.Write(list[i] + " ");
        //    }
        //    Console.WriteLine();
        //}

        static void Main(string[] args)
        {
            //List<int> arrayOfIntegers = new List<int>() { 1, 5, 7, 8, 9, 3, 5, 6, 7 };
            //List<int> sortedArray = QuickSort(arrayOfIntegers);

            //PrintList(sortedArray);




            string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" };

            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            QuickSort(unsorted, 0, unsorted.Length - 1);

            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
            Console.WriteLine();
        }

        public static void QuickSort(string[] elements, int left, int right)
        {
            int i = left, j = right;
            string middle = elements[(left + right) / 2];

            while(i <= j)
            {
                while(elements[i].CompareTo(middle) < 0)
                {
                    i++;
                }
                while(elements[j].CompareTo(middle) > 0)
                {
                    j--;
                }

                if(i <= j)
                {
                    string tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
                    i++;
                    j--;
                }
            }

            if(left < j)
            {
                QuickSort(elements, left, j);
            }

            if(i < right)
            {
                QuickSort(elements, i, right);
            }
        }
    }
}
