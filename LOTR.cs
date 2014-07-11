using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace CodeJamProblems
{
    class LOTR
    {

        int GetMinimum(int[] replies)
        {
            //Your code goes here
            int sum = 0;

            var arrayValue = replies;
            int[] distinctValue= arrayValue.Distinct().ToArray();
            int count = distinctValue.Count();
            int paireValue;

            for( int i = 0; i< distinctValue.Length;i++)
            {
                int tempvalue = distinctValue[i];
                int[] FindArray = Array.FindAll(arrayValue, element => element == tempvalue);

                int findArrayLength = FindArray.Length;
                tempvalue = distinctValue[i];


                if (findArrayLength == 1)
                {
                    sum = sum +(tempvalue+ 1);


                }
                else {
                    if ((findArrayLength % (tempvalue + 1)) != 0)
                    {
                        paireValue = (int)((findArrayLength) / (tempvalue + 1)) + 1;

                    }
                    else
                    {
                        paireValue = (int)((findArrayLength)/(tempvalue+1));

                    }
                    
                    sum += paireValue * (tempvalue+1);

                }

            }


            return sum;
            
        }
        
        #region Testing code Do not change
        public static void Main(String[] args)
        {
            LOTR lotr = new LOTR();
            String input = Console.ReadLine();
            do
            {
                int[] replies = Array.ConvertAll<string, int>(input.Split(','), delegate(string s) { return Int32.Parse(s); });
                Console.WriteLine(lotr.GetMinimum(replies));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion

    }
}
