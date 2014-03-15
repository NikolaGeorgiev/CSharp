using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {

        //static int[] arrayMajorant(int[] array)
        //{
        //    int numberOfDifferentElements = 0;
        //    int[][] lengthOfElement = new int[array.Length][];
        //    for (int i = 0, length = array.Length; i < length; i++)
        //    {
        //        bool dontExist = true;
        //        for (int j = 0; j < numberOfDifferentElements; j++)
        //        {
        //            if(array[i] == lengthOfElement[j][0])
        //            {
        //                lengthOfElement[j][1]++;
        //                dontExist = false;
        //            }
        //        }

        //        if(dontExist)
        //        {
        //            lengthOfElement[numberOfDifferentElements] = new int[] { array[i], 1 };
        //            numberOfDifferentElements++;
        //        }
        //    }

        //    int biggestIndex = 0;
        //    for (int i = 0; i < numberOfDifferentElements; i++)
        //    {
        //        if(lengthOfElement[biggestIndex][1] < lengthOfElement[i][1])
        //        {
        //            biggestIndex = i;
        //        }
        //    }
        //    return lengthOfElement[biggestIndex];
        //}

        //static int[] arrayMajorantDictionary(int[] array)
        //{
        //    Dictionary<int, int> lengthOfElements = new Dictionary<int, int>();
        //    for (int i = 0, length = array.Length; i < length; i++)
        //    {
        //        if(lengthOfElements.ContainsKey(array[i]))
        //        {
        //            lengthOfElements[array[i]]++;
        //        }
        //        else
        //        {
        //            lengthOfElements.Add(array[i], 1);
        //        }
        //    }
        //    int maxKey = array[0];
        //    foreach (var number in lengthOfElements)
        //    {
        //        if(number.Value > lengthOfElements[maxKey])
        //        {
        //            maxKey = number.Key;
        //        }
        //    }
        //    return new int[] { maxKey, lengthOfElements[maxKey] };
        //}

        static void Main(string[] args)
        {
            //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //int[] majorant = arrayMajorant(array);
            //Console.WriteLine("{0} {1} times", majorant[0], majorant[1]);



            //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //Dictionary<int, int> elementsInArray = new Dictionary<int, int>();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if(elementsInArray.ContainsKey(array[i]))
            //    {
            //        elementsInArray[array[i]] += 1;
            //    }
            //    else
            //    {
            //        elementsInArray.Add(array[i], 1);
            //    }
            //}
            //int number = elementsInArray.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            //int count = elementsInArray.Max(x => x.Value);
            //Console.WriteLine("{0} {1} times", number, count);


            //int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //int[] checking = new int[0];
            //Array.Sort(arr);
            //int freqNum = arr[0];
            //if(arr[arr.Length - 1] < arr.Length)
            //{
            //    checking = new int[arr.Length];
            //}
            //else if(arr[arr.Length - 1] > arr.Length)
            //{
            //    checking = new int[arr[arr.Length - 1] + 1];
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    checking[arr[i]]++;
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if(freqNum < checking[i])
            //    {
            //        freqNum = checking[i];
            //    }
            //    if(checking[i] != 0)
            //    {
            //        Console.WriteLine("{0} - 1", i, checking[i]);
            //    }
            //}
            //Console.WriteLine("The most frequent number is : {1}, appeared {0} times.", freqNum, Array.IndexOf
            //    (checking, freqNum));



            //Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //dictionary.Add("cat", 2);
            //dictionary.Add("dog", 1);
            //dictionary.Add("llama", 0);
            //dictionary.Add("iguana", -1);




            //Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //dictionary.Add("people", 1);
            //dictionary.Add("windows", 5);

            //if(dictionary.ContainsKey("apple"))
            //{
            //    int value = dictionary["apple"];
            //    Console.WriteLine(value);
            //}

            //if(!dictionary.ContainsKey("acorn"))
            //{
            //    Console.WriteLine(false);
            //}



            //Dictionary<string, int> d = new Dictionary<string, int>()
            //{
            //    {"cat", 2},
            //    {"dog", 1},
            //    {"llama", 0},
            //    {"iguana", -1}
            //};

            //foreach (KeyValuePair<string, int> pair in d)
            //{
            //    Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            //}
            //foreach (var pair in d)
            //{
            //    Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            //}



            //var d = new Dictionary<string, int>();
            //d.Add("key", 0);
            //if(d.ContainsKey("key"))
            //{
            //    d["key"]++;
            //}


            //var d = new Dictionary<string, int>();
            //d.Add("key", 0);
            //if(d.ContainsKey("key"))
            //{
            //    d["k"] = d["key"] + 1;
            //}


            int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            Dictionary<int, int> mostFrequent = new Dictionary<int, int>();
            int bestElement = 0;
            int bestFrequency = int.MinValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                int tempValue;
                if (mostFrequent.TryGetValue(myArray[i], out tempValue))
                {
                    mostFrequent[myArray[i]] = tempValue + 1;
                }
                else
                {
                    mostFrequent.Add(myArray[i], 1);
                }
            }

            foreach (var item in mostFrequent)
            {
                if(item.Value > bestFrequency)
                {
                    bestElement = item.Key;
                    bestFrequency = item.Value;
                }
            }
            Console.WriteLine("The number {0} shows {1} times", bestElement, bestFrequency);
        }
    }
}
