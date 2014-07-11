using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CodeJamProblems
{
    class Pool
    {
        int RackMoves(int[] triangle)
        {
            //Your code goes here
            int sum = 0;

            int[] location1 = { 0, 3 , 5 , 7 , 9 , 10 , 12};
            int[] location2 = { 1, 2 , 6 , 8 , 11 , 13 ,14  };
            
            int solidcount =0;
            int stripcount =0;


            if (triangle[4] != 8) {
                sum++;

            }

            for (int i = 0; i < location1.Length; i++) 
            {
                if (triangle[location1[i]] < 8)
                    solidcount++;

            }

            if (solidcount > 3)
                solidcount =   7-solidcount;



            for (int i = 0; i < location2.Length; i++) 
            {
                if (triangle[location2[i]] > 8)
                    stripcount++;

            }
            if (stripcount > 3)
                stripcount = 7 - stripcount;

            sum = sum + (stripcount + solidcount) / 2;

            return sum;

        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            Pool pool = new Pool();
            String input = Console.ReadLine();
            do
            {
                int[] triangle = Array.ConvertAll<string, int>(input.Split(','), delegate(string s) { return Int32.Parse(s); });
                Console.WriteLine(pool.RackMoves(triangle));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion

    }
}
