using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CodeJamProblems
{
    class StandInLine
    {
        int[] Reconstruct(int[] left)
        {
            int[] final = left;
            //Your code goes here

            int[]  height = new int[left.Length];
            
            int temphight = 0;
            int templeft = 0;

            for (int i = 0; i < left.Length; i++) 
            {
                height[i] = i + 1;
    
            }




            

            for (int i = 0; i < left.Length; i++) 
            {
                int index1 = Array.IndexOf(left, height[i]);
                

               
                temphight = height[i];
                int j = 0;
                while (templeft > 0)
                {
                    
                    int count = 0;
                    
                    int abc = height[count];
                    int xyz = height[j+1];
                    int maxcount = 0;
                    while (temphight < height[j + 1])

                    {
                        
                        int thisnum = height[maxcount + 1];
                       

                        
                            maxcount++;
                        
                        while (thisnum < height[maxcount + 1])
                        {

                            thisnum = height[maxcount + 1];
                            

                            height[count + j] = thisnum;
                            height[maxcount + 1] = temphight;

                            

                            templeft--;
                            j++;

                        } maxcount++;


                    } 

                    templeft--;
                    maxcount--;

                
                }
                

            }

            return final;
        }


        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            StandInLine standInLine = new StandInLine();
            do
            {
                int[] left = Array.ConvertAll<string, int>(input.Split(','), delegate(string s) { return Int32.Parse(s); });
                Console.WriteLine(string.Join(",", Array.ConvertAll<int, string>(standInLine.Reconstruct(left), delegate(int s) { return s.ToString(); })));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
