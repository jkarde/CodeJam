using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codejam
{
    class AlienNumbers
    {
        public string getTargetNumber(string alien_number, string source_language, string target_language)
        {
            //object created    
            FindAlienNumber source = new FindAlienNumber() { languagestring = source_language };
            FindAlienNumber target = new FindAlienNumber() { languagestring = target_language };

            int number = source.convertDecimal(alien_number);

            string targetstring = target.getTargetString(number);

            return targetstring;   
            
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

    public class FindAlienNumber
    { 
        

       public string languagestring { get; set; }

       public int convertDecimal(string inputstring) 
       {

           int num = 0;
           int multiplier = 1;

           inputstring
                       .Reverse()
                       .ToList()
                       .ForEach(x =>
                       {
                           num += languagestring.IndexOf(x) * multiplier;
                           multiplier *= languagestring.Length;
                       });

           return num;
       }

       public string getTargetString(int number) {

           int num = number;
           char[] targetvalue = languagestring.ToCharArray();
           int div = languagestring.Length;
           Stack<int> stack = new Stack<int>();
           int stackvalue = 0;
           string returnstring ="";



           do
           {
               stackvalue = num % div;
               num = num / div;
               stack.Push(stackvalue);

           } while (num != 0);

           foreach( int i in stack)
           {
               returnstring = returnstring + targetvalue[i];

           }

           return returnstring;

       }
    }
}
