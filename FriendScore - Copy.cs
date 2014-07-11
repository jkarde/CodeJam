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
            string[] arrayvalue = friends;
            char[][] twodimansional = new char[lenth][];
            int count = 0;
            int len = 0;
            int max = 0;

            for (int i = 0; i < twodimansional.Length; i++) 
            {
                twodimansional[i] = arrayvalue[i].ToCharArray();

            }
            for (int i = 0; i < lenth ; i++)
            {
                count = 0;

                for (int j = 0; j < lenth ; j++) 
                {
                    //&& twodimansional[i][j] == 'Y'
                    if (twodimansional[i][j] == twodimansional[0][0] && twodimansional[i][j] == 'Y')
                    {
                        count--;
                        

                    }
                    else 
                    {
                        if (twodimansional[i][j] == 'Y')
                        {
                            for (int k = 0; k < twodimansional.Length; k++)
                            {
                                if (twodimansional[i][k] == 'Y' && twodimansional[k][j] == 'Y')
                                {


                                    count++;



                                }


                            }
                        }
                    }

                }
                if (count > max) 
                {
                    max = count;
                    

                }
            }
            Console.WriteLine(count);

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
