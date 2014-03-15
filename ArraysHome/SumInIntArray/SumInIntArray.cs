using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInIntArray
{
    class SumInIntArray
    {
        static void Main(string[] args)
        {
            //int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            //int S = int.Parse(Console.ReadLine());
            //int start = 0;
            //int sum = 0;
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    sum += array[i];
            //    start = i;
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        sum += array[j];
            //        if (sum == S)
            //        {
            //            for (int k = start; k <= j; k++)
            //            {
            //                Console.Write(array[k] + " ");
            //            }
            //            return;
            //        }
            //    }
            //    sum = 0;
            //}
            //Console.WriteLine("The sum is not present in the array.");





            //int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            //int s = 11;
            //int currentSum = 0;
            //int startElement = 0;
            //int printStart = 0;
            //int printEnd = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    currentSum += array[i];
            //    if(currentSum == s)
            //    {
            //        printStart = startElement;
            //        printEnd = i;
            //        break;
            //    }
            //    if(i == array.Length - 1)
            //    {
            //        currentSum = 0;
            //        startElement++;
            //        if(startElement == array.Length)
            //        {
            //            break;
            //        }
            //        i = startElement - 1;
            //    }
            //}
            //if(s != currentSum)
            //{
            //    Console.WriteLine("No such sum in array");
            //    return;
            //}
            //for (int i = printStart; i <= printEnd; i++)
            //{
            //    Console.Write("{0} ", array[i]);
            //}




            //Console.Write("Enter N: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Enter S: ");
            //int s = int.Parse(Console.ReadLine());
            //int[] number = new int[n];
            //int currentSum = 0;
            //int startPosition = 0;
            //int endPosition = 0;
            //bool isThereSuchSum = false;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter element value: ");
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < number.Length; i++)
            //{
            //    currentSum += number[i];
            //    for (int j = i + 1; j < number.Length; j++)
            //    {
            //        currentSum += number[j];
            //        if(currentSum == s)
            //        {
            //            isThereSuchSum = true;
            //            startPosition = i;
            //            endPosition = j;
            //        }
            //    }
            //}
            //if(isThereSuchSum == false)
            //{
            //    Console.WriteLine("The sum is not present in this array!");
            //}
            //if (isThereSuchSum == true)
            //{
            //    for (int i = startPosition; i <= endPosition; i++)
            //    {
            //        Console.Write("{0}", number[i]);
            //    }
            //}



        }
    }
}