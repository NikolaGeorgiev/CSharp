using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxIncreasingSequence
{
    class MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            //int[] array = { 3, 2, 3, 4, 5, 6, 7, 8, 2, 2, 4, 5, 6, 7 };
            //int maxSequence = 0;
            //int sequence = 1;
            //string sequenceNumber = "";
            //string maxSequenceNumber = "";
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    if(array[i] < array[i + 1])
            //    {
            //        sequence++;
            //        sequenceNumber += array[i] + " ";
            //    }
            //    else
            //    {
            //        if(maxSequence < sequence)
            //        {
            //            maxSequence = sequence;
            //            sequenceNumber += array[i] + " ";
            //            maxSequenceNumber = sequenceNumber;
            //        }
            //        sequence = 1;
            //        sequenceNumber = "";
            //    }
            //}

            //if(maxSequence < sequence)
            //{
            //    sequenceNumber += array[array.Length - 1];
            //    maxSequenceNumber = sequenceNumber;
            //}
            //Console.WriteLine(maxSequenceNumber);



            //Console.Write("Array length: ");
            //int arrayLength = int.Parse(Console.ReadLine());
            //int[] array = new int[arrayLength];

            //for (int i = 0; i < arrayLength; i++)
            //{
            //    Console.Write("Element [{0}] = ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int counter = 1;
            //int maxCounter = 1;
            //int index = 0;
            //int startIndex = 0;

            //for (int i = 1; i < arrayLength; i++)
            //{
            //    if(array[i] > array[i - 1])
            //    {
            //        counter++;
            //        if(counter > maxCounter)
            //        {
            //            maxCounter = counter;
            //            startIndex = index;
            //        }
            //    }
            //    else
            //    {
            //        counter = 1;
            //        index = i;
            //    }
            //}
            //int endIndex = (startIndex + maxCounter) - 1;
            //Console.WriteLine("Maximal sequence of increasing elements:");

            //for (int i = startIndex; i <= endIndex; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();


            //int[] array = new int[10];
            //int counter = 1;
            //int count = 0;
            //int firstNumber = 0;

            //for (int index = 0; index < 10; index++)
            //{
            //    array[index] = int.Parse(Console.ReadLine());
            //}

            //for (int index = 0; index < 9; index++)
            //{
            //    if(array[index] + 1 == array[index + 1])
            //    {
            //        counter++;
            //    }
            //    else
            //    {
            //        count = 1;
            //    }

            //    if(count < counter)
            //    {
            //        count = counter;
            //        firstNumber = array[index] + 1;
            //    }
            //}

            //for (int i = count - 1; i >= 0; i--)
            //{
            //    Console.Write((firstNumber - i) + ", ");   
            //}



            int[] myArray = { 0, 1, 2, 3, 4, 2, 3, 4, 5, 6, 7, 8, 30, 2, 3 };
            int len = 1;
            int bestLen = 0;
            int endIndex = 0;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if(myArray[i] < myArray[i+1])
                {
                    len++;
                }
                else
                {
                    if(len > bestLen)
                    {
                        bestLen = len;
                        endIndex = i;
                    }
                    len = 1;
                }
            }
            if(len > bestLen)
            {
                bestLen = len;
                endIndex = myArray.Length - 1;
            }
            len = 1;
            Console.WriteLine("The longest element of increasing sequence is:");
            Console.Write("{");
            for (int i = endIndex - bestLen + 1; i < endIndex; i++)
            {
                Console.Write("{0}", myArray[i]);
            }
            Console.WriteLine("}");
        }
    }
}
