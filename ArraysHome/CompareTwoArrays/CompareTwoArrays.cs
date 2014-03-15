using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoArrays
{
    class CompareTwoArrays
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            //int[] fArray = new int[num];
            //int[] sArray = new int[num];
            //bool equal = true;

            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write("First array {0} element: ", i);
            //    fArray[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < sArray.Length; i++)
            //{
            //    Console.Write("Second array {0} element: ", i);
            //    sArray[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < sArray.Length; i++)
            //{
            //    if(fArray[i] != sArray[i])
            //    {
            //        equal = false;
            //        break;
            //    }
            //}
            //Console.WriteLine("Two array are equal {0}", equal);


            //int i = 0;
            //Console.WriteLine("Enter the length of the First array:");
            //string fLengthStr = Console.ReadLine();
            //int fLength = int.Parse(fLengthStr);
            //Console.WriteLine("Enter the length of the second array:");
            //string sLengthStr = Console.ReadLine();
            //int sLengh = int.Parse(sLengthStr);
            //if(fLength != sLengh)
            //{
            //    Console.WriteLine("The arrays are not equal");
            //    int[] First = new int[fLength];
            //    int[] Second = new int[fLength];
            //    bool Compare = true;
                
            //    while(i < fLength)
            //    {
            //        Console.WriteLine("Please enter the {0} number of first array", i + 1);
            //        string fNum = Console.ReadLine();
            //        First[i] = int.Parse(fNum);
            //        Console.WriteLine("Please enter the {0} number of second array", i + 1);
            //        string sNum = Console.ReadLine();
            //        Second[i] = int.Parse(sNum);
            //        Compare = (First[i] == Second[i]);
            //        if(Compare == false)
            //        {
            //            break;
            //            i++;
            //        }
            //        Console.WriteLine("The arrays are equal is {0}", Compare);
            //    }
            //}


            //Console.Write("Enter arrays length:");
            //int n = int.Parse(Console.ReadLine());
            //int[] arrayOne = new int[n];
            //int[] arrayTwo = new int[n];
            //Console.WriteLine("Enter the {0} elements for first array", n);

            //for (int i = 0; i < n; i++)
            //{
            //    arrayOne[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter the {0} element for second array", n);

            //for (int i = 0; i < n; i++)
            //{
            //    arrayTwo[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    if(arrayOne[i] == arrayTwo[i])
            //    {
            //        Console.WriteLine("{0} = {1}", arrayOne[i], arrayTwo[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} != {1}", arrayOne[i], arrayTwo[i]);
            //    }
            //}


            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[m];
            //bool equal = true;

            //if(m == n)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        arr1[i] = int.Parse(Console.ReadLine());
            //    }
            //    for (int i = 0; i < m; i++)
            //    {
            //        arr2[i] = int.Parse(Console.ReadLine());
            //    }
            //    for (int i = 0; i < n; i++)
            //    {
            //        if(arr1[i] != arr2[i])
            //        {
            //            equal = false;
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    equal = false;
            //}
            //Console.WriteLine("Are the arrays equal? {0}", equal);


            //Console.WriteLine("Enter the array length:");
            //int n = int.Parse(Console.ReadLine());
            //int[] firstArray = new int[n];
            //int[] secondArray = new int[n];
            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    Console.WriteLine("Enter element - {0} from the first array", i);
            //    firstArray[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    Console.WriteLine("Enter element - {0} from second array", i);
            //    secondArray[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(firstArray);
            //Array.Sort(secondArray);
            //bool areEqual = true;
            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    if(firstArray[i] != secondArray[i])
            //    {
            //        areEqual = false;
            //        break;
            //    }
            //}
            //Console.WriteLine("The two arrays are equal: {0}", areEqual);


            int numArray1;
            int numArray2;
            bool check = false;

            Console.Write("First array");
            check = int.TryParse(Console.ReadLine(), out numArray1);

            while(check == false | numArray1 <= 0)
            {
                if(check == true & numArray1 <= 0)
                {
                    Console.WriteLine("Number of elements must be at least 1!");
                    Console.Write("Enter the number of elements: ");
                }
                else
                {
                    Console.WriteLine("You didn't enter a number!");
                    Console.Write("Enter currently the number of elements: ");
                }
                check = int.TryParse(Console.ReadLine(), out numArray1);
            }
            check = false;
            int[] firstArr = new int[numArray1];
            int temp;

            Console.WriteLine("Enter elements of first array");
            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write("Enter element {0}: ", (i + 1));
                check = int.TryParse(Console.ReadLine(), out temp);
                while(check == false)
                {
                    Console.WriteLine("You didn't enter a number!");
                    Console.WriteLine("Enter element {0} correctly: ", (i + 1));
                    check = int.TryParse(Console.ReadLine(), out temp);
                }
                firstArr[i] = temp;
            }
            Console.WriteLine();
            check = false;
            Console.Write("Enter the number of elements of the second Array: ");
            check = int.TryParse(Console.ReadLine(), out numArray2);

            while(check == false | numArray2 <= 0)
            {
                if(check == true & numArray2 <= 0)
                {
                    Console.WriteLine("Number of elements must be at least 1!");
                    Console.Write("Enter the number of elements: ");
                }
                else
                {
                    Console.WriteLine("You didn't enter a number!");
                    Console.Write("Enter currently the number of elements: ");
                }
                check = int.TryParse(Console.ReadLine(), out numArray2);
            }
            check = false;
            int[] secondArr = new int[numArray2];

            Console.WriteLine("Enter elements of second array !");
            for (int i = 0; i < secondArr.Length; i++)
            {
                Console.Write("Enter element {0}: ", (i + 1));
                check = int.TryParse(Console.ReadLine(), out temp);
                while(check == false)
                {
                    Console.WriteLine("You didn't enter a number!");
                    Console.WriteLine("Enter element {0} correctrly: ", (i + 1));
                    check = int.TryParse(Console.ReadLine(), out temp);
                }
                secondArr[i] = temp;
            }
            Console.WriteLine();
            check = true;

            if(numArray1 != numArray2)
            {
                Console.WriteLine("The two arrays are not equal, they have different lengths!");
            }
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if(firstArr[i] != secondArr[i])
                    {
                        check = false;
                        break;
                    }
                }
                if(check == true)
                {
                    Console.WriteLine("The two arrays are equal!");
                }
                else
                {
                    Console.WriteLine("The two arrays are not equal!");
                }
            }
        }
    }
}
