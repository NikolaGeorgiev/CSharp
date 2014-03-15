using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellectionSortArrElement
{
    class SellectionSortArrElement
    {
        static void Main(string[] args)
        {
            //    int[] array = { -2, 1, -2, 5, 3, 3, 4, };
            //    int startingPosition = 0;
            //    while(startingPosition <= array.Length - 1)
            //    {
            //        int currentMinIndex = 0;
            //        int currentMin = int.MaxValue;
            //        for (int i = startingPosition; i < array.Length; i++)
            //        {
            //            if(array[i] < currentMin)
            //            {
            //                currentMin = array[i];
            //                currentMinIndex = i;
            //            }
            //        }
            //        int temp = array[startingPosition];
            //        array[startingPosition] = currentMin;
            //        array[currentMinIndex] = temp;
            //        startingPosition++;
            //    }
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.WriteLine("{0}: {1}", i, array[i]);
            //    }





            //int[] array = { 5, 7, 5, 9, 342, 65, 234, 64, 32 };
            //int positionEnd = array.Length - 1;
            //int temp;

            //for (int i = 0; i < positionEnd; i++)
            //{
            //    if(array[i] > array[i + 1])
            //    {
            //        temp = array[i];
            //        array[i] = array[i + 1];
            //        array[i + 1] = temp;

            //        if(i != 0)
            //        {
            //            if(array[i - 1] > array[i])
            //            {
            //                i -= 2;
            //            }
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //foreach (int num in array)
            //{
            //    Console.Write(num + ", ");
            //}


            //Console.Write("How much elements do you want to have the array: ");
            //int numberOfElements = int.Parse(Console.ReadLine());
            //int[] arrayOfNumbers = new int[numberOfElements];

            //for (int i = 0; i < numberOfElements; i++)
            //{
            //    arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            //}

            //int helpfulVariable = 0;

            //for (int i = 0; i < numberOfElements; i++)
            //{
            //    for (int j = i + 1; j < numberOfElements; j++)
            //    {
            //        if (arrayOfNumbers[j] < arrayOfNumbers[i])
            //        {
            //            helpfulVariable = arrayOfNumbers[j];
            //            arrayOfNumbers[j] = arrayOfNumbers[i];
            //            arrayOfNumbers[i] = helpfulVariable;
            //        }
            //    }
            //}
            //Console.WriteLine("The sorted array is: ");

            //for (int i = 0; i < numberOfElements; i++)
            //{
            //    Console.WriteLine(arrayOfNumbers[i]);
            //}


            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];

            for (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int helpArray;

            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    if(array[j] < array[i])
                    {
                        helpArray = array[j];
                        array[j] = array[i];
                        array[i] = helpArray;
                    }
                }
            }

            for (int i = 0; i < num; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
