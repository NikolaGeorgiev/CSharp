using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxSum
{
    class FindMaxSum
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the array's length:");
            //int length = int.Parse(Console.ReadLine());

            //int[] array = new int[length];
            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write("Array[{0}]= ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int maxSoFar = array[0];
            //int maxEndingHere = array[0];
            //int begin = 0;
            //int beginTemp = 0;
            //int end = 0;

            //for (int i = 1; i < length; i++)
            //{
            //    if (maxEndingHere < 0)
            //    {
            //        maxEndingHere = array[i];
            //        beginTemp = i;
            //    }
            //    else
            //    {
            //        maxEndingHere += array[i];
            //    }

            //    if(maxEndingHere >= maxSoFar)
            //    {
            //        maxSoFar = maxEndingHere;
            //        begin = beginTemp;
            //        end = i;
            //    }
            //}

            //Console.WriteLine("The maximal sum is {0}", maxSoFar);
            //Console.WriteLine("The maximal subarray is:");
            //for (int i = begin; i <= end; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}


            //int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            //int maxSum = 0;
            //int currentSum = 0;
            //int startIndex = 0;
            //int endIndex = 1;

            //for (int i = 0, j = 0; i < arr.Length; i++)
            //{
            //    if(arr[j] <= 0)
            //    {
            //        j++;
            //    }
            //    else if(currentSum + arr[i] > maxSum)
            //    {
            //        currentSum += arr[i];
            //        maxSum = currentSum;
            //        startIndex = j;
            //        endIndex = i;
            //    }
            //    else if((i < arr.Length - 1) && (arr[i] + arr[i + 1] > 0))
            //    {
            //        currentSum += arr[i];
            //    }
            //    else
            //    {
            //        currentSum = 0;
            //        i = j;
            //        j++;
            //    }
            //}

            //Console.WriteLine(maxSum);
            //for (int i = startIndex; i <= endIndex; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}



            //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            //int arrayLength = array.Length;

            //int biggestSum = array[0];
            //string elementForBigSum = Convert.ToString(array[0]);
            //int sum = array[0];
            //string elementsForSum = array[0] + " ";

            //for (int j = 1; j < arrayLength; j++)
            //{
            //    sum += array[j];
            //    elementsForSum += array[j] + " ";

            //    if(sum > biggestSum)
            //    {
            //        biggestSum = sum;
            //        elementForBigSum = elementsForSum;
            //    }
            //    if(sum < 0)
            //    {
            //        elementsForSum = "";
            //    }
            //}
            //Console.WriteLine("The biggest sum is: {0}", biggestSum);
            //Console.WriteLine("The biggest sequece is: {0}", elementForBigSum);



            Console.WriteLine("Please insert 'N' integer number: ");
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int[] maxSequeceArray = new int[N];

            Console.WriteLine("Insert N elements in array: ");

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int maxSum = 0;
            int initialIndex = 0;
            int finalIndex = 0;

            for (int j = 0; j < N; j++)
            {
                for (int i = j; i < N; i++)
                {
                    sum += numbers[i];
                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        initialIndex = j;
                        finalIndex = i;
                    }
                }
                sum = 0;
            }
            Console.WriteLine(maxSum);

            for (int i = initialIndex; i <= finalIndex; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
