using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlphabet
{
    class ArrayAlphabet
    {
        static void Main(string[] args)
        {
            //char[] letters = new char[26];
            //for (int i = 0; i < letters.Length; i++)
            //{
            //    letters[i] = (char)(i + 65);
            //}

            //string word = Console.ReadLine();

            //for (int i = 0; i < word.Length; i++)
            //{
            //    for (int j = 0; j < letters.Length; j++)
            //    {
            //        if (word[i] == letters[j])
            //        {
            //            Console.WriteLine(j);
            //        }
            //    }
            //}





            //int[] letterIndexes = new int[53];
            //for (int i = 1; i < letterIndexes.Length / 2 + 1; i++)
            //{
            //    letterIndexes[i] = ('a' - 1) + i;
            //}
            //for (int i = letterIndexes.Length / 2 + 1, k = 0; i < letterIndexes.Length;k++, i++)
            //{
            //    letterIndexes[i] = 'A' + k;
            //}

            //string testWord = "TSYZ";
            //for (int i = 0; i < testWord.Length; i++)
            //{
            //    for (int j = 0; j < letterIndexes.Length; j++)
            //    {
            //        if(testWord[i] == letterIndexes[j])
            //        {
            //            Console.WriteLine("Letter {0} has index: {1}", testWord[i], j);
            //            break;
            //        }
            //    }
            //}




            //char[] arr = new char[26];
            //string word = (Console.ReadLine().ToLower());

            //for (int i = 0; i < 26; i++)
            //{
            //    arr[i] = Convert.ToChar('a' + i);
            //}
            //for (int j = 0; j < word.Length; j++)
            //{
            //    Console.WriteLine("{0} [{1}]", word[j], word[j] - 'a');
            //}



            char[] alphabet = new char[27];
            int initializationOfArray = 65;

            for (int i = 1; i < 27; i++)
            {
                alphabet[i] = (char)initializationOfArray;
                initializationOfArray++;
            }

            Console.WriteLine("Please enter a word with capital letters:");
            string enteredWord = Console.ReadLine().ToUpper();
            foreach (char letter in enteredWord)
            {
                for (int i = 1; i < 27; i++)
                {
                    if(alphabet[i] == letter)
                    {
                        Console.WriteLine("The index of the letter {0} is {1}", letter, i);
                        break;
                    }
                }
            }
        }
    }
}
