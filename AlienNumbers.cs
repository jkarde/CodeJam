using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class AlienNumbers
    {
        public string getTargetNumber(string alien_number, string source_language, string target_language)
        {

            

            return "";   
            
        }
    
        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            AlienNumbers alienNumbers = new AlienNumbers();
            int cse = 1;
            do
            {
                var values = input.Split(' ');
                string validationOp = alienNumbers.getTargetNumber(values[0], values[1], values[2]);
                Console.WriteLine("Case #{0}: {1}", cse++, validationOp);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}