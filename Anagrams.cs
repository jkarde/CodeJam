using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class Anagrams
    {
        int GetMaximumSubset(string[] words)
        {
            //Your code goes here

            //string[] separators = { ","};
            
            string value = words[0];
            int []  num =  new int[10] ;
            int  arraycount = 0;
            int count = 0;
            //string [] wordsarray = value.Split(separators, StringSplitOptions.None);

            string firstvalue = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                char[] farray = words[i].ToCharArray();

                for (int j = i; j < words.Length; j++) 
                {

                    if (!words[i].Equals(words[j]))
                    {
                        char[] sarray = words[j].ToCharArray();

                    //to check is anagram or not

                    count  = check_anagram(farray, sarray);

                    if (count == 1)
                    {

                        arraycount = arraycount + 1;
                        break;

                    }
                                        
                  }
            
                }
                
             }

            //Returm Count of anagram
            return words.Length - arraycount;
        }

        public int check_anagram(char[] a, char[] b)
        {
            Int16[] first = new Int16[26];
            Int16[] second = new Int16[26];
            int c = 0;

            for (c = 0; c < a.Length; c++)
            {
                first[a[c] - 'a']++;
            }

            c = 0;

            for (c = 0; c < b.Length; c++)
            {
                second[b[c] - 'a']++;

            }

            for (c = 0; c < 26; c++)
            {
                if (first[c] != second[c])
                    return 0;
            }

            return 1;
        }
        

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Anagrams anagramSolver = new Anagrams();
            do
            {
                string[] words = input.Split(',');
                Console.WriteLine(anagramSolver.GetMaximumSubset(words));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}