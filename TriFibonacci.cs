//chages made
using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class TriFibonacci
    {
        public int Complete(int[] test)
        {
           
           //this chagnes has been made
           //code start
            int answer = 0;

            int index1 = Array.IndexOf(test, -1);

            if (index1 >= 3)
            {
                int i = index1;

                
                   test[i] = test[i - 1] + test[i - 2] + test[i - 3];
    
                   int isfab = checktriFibonacci(test, index1);

                   if (checktriFibonacci(test, index1) == -1)
                   {
                       answer = -1;

                   }else if(test[i] <=0)
                    {
                        answer = -1;

                   }
                   else
                    {
                        answer = test[i];

                   }

            }
            else if ( index1 <3){

                int i = index1;
                    test[index1] = test[3] - (test[0] + test[1] + test[2] + 1);

                    int isfab = checktriFibonacci(test, index1);

                    if (checktriFibonacci(test, index1) == -1)
                    {
                        answer = -1;

                    }
                    else if (test[i] <= 0)
                    {
                        answer = -1;

                    }
                    else
                    {
                        answer = test[i];

                    }

            }

            return answer;
        }

        public int checktriFibonacci(int[] test,int index)
        {
           
            for (int i = 3; i < test.Length-1; i++)
            {
                int value = test[i - 1] + test[i - 2] + test[i - 3];

                if (test[i] != value )
                    return -1;
            }   
            return 1;

        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TriFibonacci triFibonacci = new TriFibonacci();
            do
            {
                string[] values = input.Split(',');
                int[] numbers = Array.ConvertAll<string, int>(values, delegate(string s) { return Int32.Parse(s); });
                int result = triFibonacci.Complete(numbers);
                Console.WriteLine(result);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
