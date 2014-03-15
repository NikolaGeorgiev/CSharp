using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NElementsInArray
{
    class NElementsInArray
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter N: ");
            //int N = int.Parse(Console.ReadLine());
            //int[] array = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("Enter array element {0} ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Enter K: ");
            //int K = int.Parse(Console.ReadLine());

            //int checkedNumbers = 0;
            //List<int> subsetNumbers = new List<int>();
            //int maxi = (int)Math.Pow(2, array.Length) - 1;
            //int maxSum = int.MinValue;
            //int[] maxSumArray = new int[K];

            //for (int i = 0; i <= maxi; i++)
            //{
            //    int currentSum = 0;

            //    for (int j = 1; j <= array.Length; j++)
            //    {
            //        if(((i >> (j - 1)) & 1) == 1)
            //        {
            //            currentSum += array[j - 1];
            //            checkedNumbers++;
            //            subsetNumbers.Add(array[j - 1]);
            //        }
            //    }

            //    if(checkedNumbers == K && currentSum > maxSum)
            //    {
            //        maxSum = currentSum;
            //        for (int k = 0; k < maxSumArray.Length; k++)
            //        {
            //            maxSumArray[k] = subsetNumbers[K];
            //        }
            //    }
            //    subsetNumbers.Clear();
            //    checkedNumbers = 0;
            //}

            //if(maxSum > int.MinValue)
            //{
            //    for (int i = 0; i < K; i++)
            //    {
            //        Console.Write(maxSumArray[i] + " ");
            //    }
            //}
            //else
            //{
            //    Console.Write("No such subset.");
            //}
            //Console.WriteLine();


            //int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //int sum = 0;

            //if(k > n)
            //{
            //    Console.WriteLine("N must be bigger than K!");
            //    return;
            //}

            //for (int index = 0; index < n; index++)
            //{
            //    array[index] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(array);

            //for (int index = n - 1; index >= n - k; index--)
            //{
            //    sum += array[index];
            //}
            //Console.WriteLine(sum);


            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int pos = 0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= n - k; i++)
            {
                for (int j = i; j < i + k; j++)
                {
                    sum += a[j];
                }
                if (sum > max)
                {
                    max = sum;
                    pos = i;
                }
                sum = 0;
            }
            for (int i = pos; i < pos + k; i++)
            {
                Console.Write(a[i] + " ");
            }
         }
    }
}
