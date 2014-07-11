using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJamProblems
{
    class FriendScore
    {
        public int HighestScore(string[] friends)
        {
            int lenth = friends.Length;
                        
            int count = 0;
            
            int max = 0;

           

            for (int i = 0; i < lenth; i++)
            {
                count = 0;
               

                for (int j = 0; j < lenth; )
                {
                   
                    
                    if(i==j)
                    {
                        if (j < lenth-1)
                        {
                            j++;
                        }
                    }
                    if(friends[i][j] == 'Y')
                    {
                        count++;

                    }

                       for (int k = 0; k < lenth; k++)
                            {
                                if (friends[i][k] == 'Y' && friends[k][j] == 'Y')
                                {


                                    count++;



                                }


                            }

                       j++;


                }
                if (count > max)
                {
                    max = count;


                }
            }
           

            return max;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            FriendScore friendScore = new FriendScore();
            do
            {
                string[] values = input.Split(',');
                int validationOp = friendScore.HighestScore(values);
                Console.WriteLine(validationOp);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
