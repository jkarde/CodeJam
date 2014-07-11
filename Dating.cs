using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System;




namespace CodeJamProblems
{
    class Dating
    {
        String Dates(String circle, int k)
        {
            string Outputstring = string.Empty;
            //Your code goes here
            int length = circle.Length;
            char[] value = circle.ToCharArray();


            List<char> isUpper = new List<char>();
            List<char> isLower = new List<char>();
            for (int i = 0; i < length; i++)
            {
                if (char.IsUpper(value[i]))
                {
                    //isUpper[upper++] = value[i];
                    isUpper.Add(value[i]);

                }
                else
                {
                    isLower.Add(value[i]);

                }

            }

            isUpper.Sort();
            isLower.Sort();
            int uindex = 0;
            int lindex = 0;
            int start = (k - 1) % length;
            

            if (isUpper.Count != 0 && isLower.Count != 0)
            {

                while (Pairs(isUpper, isLower))
                {
                    if (start == -1)
                    {
                        start = 1;

                    }

                    if (char.IsUpper(value[start]))
                    {

                        Outputstring += value[start];
                        if (isLower.Count != 0)
                        {
                            Outputstring += isLower[lindex];
                        }
                        Outputstring += " ";

                        //Console.WriteLine(Outputstring);
                        length = value.Length;

                        char nextStart = value[(start + 1) % length];

                        while (length > 0)
                        {
                            start = (start + k - 1) % length;
                            length--;
                        }

                        for (int i = 0; i < isUpper.Count; i++)
                        {
                            char c = isUpper[start];
                            isUpper.Remove(c);
                            break;

                        }
                        value = value.Where(val => val != value[start]).ToArray();



                        length--;

                        start = Array.IndexOf(value, nextStart);

                        if (isLower.Count != 0)
                        {
                            if (char.Equals(nextStart, isLower[lindex]))
                            {
                                nextStart = value[(start + 1) % length];

                            }
                        }

                        if (isLower.Count != 0)
                        {
                            value = value.Where(val => val != isLower[lindex]).ToArray();
                        }

                        for (int i = 0; i < isLower.Count; i++)
                        {
                            char c = isLower[lindex];
                            isLower.Remove(c);
                            break;

                        }

                        length--;

                        start = Array.IndexOf(value, nextStart);

                    }
                    else
                    {
                        Outputstring += value[start];
                        if (isUpper.Count != 0)
                        {
                            Outputstring += isUpper[lindex];
                        }

                        Outputstring += " ";

                        //Console.WriteLine(Outputstring);
                        length = value.Length;

                        char nextStart = value[(start + 1) % length];

                        for (int i = 0; i < isLower.Count; i++)
                        {
                            char c = value[start];
                            isLower.Remove(c);

                        }

                        value = value.Where(val => val != value[start]).ToArray();

                        while (length > 0)
                        {
                            start = (start + k - 1) % length;
                            length--;
                        }
                        
                        for (int i = 0; i < isUpper.Count; i++)
                        {
                            char c = value[start];
                            isUpper.Remove(c);

                        }

                        length--;

                        start = Array.IndexOf(value, nextStart);

                    }

                    while (length > 0)
                    {
                        start = (start + k - 1) % length;
                        length--;
                    }
                }


            }
            else if (isLower.Count != 0)
            {


                //code else
                while (Pairs(isUpper, isLower))
                {
                    if (char.IsUpper(value[start]))
                    {

                        Outputstring += value[start];
                        if (isLower.Count != 0)
                        {
                            Outputstring += isLower[lindex];
                        }
                        Outputstring += " ";

                        //Console.WriteLine(Outputstring);
                        length = value.Length;

                        char nextStart = value[(start + 1) % length];

                        for (int i = 0; i < isUpper.Count; i++)
                        {
                            char c = isUpper[start];
                            isUpper.Remove(c);
                            break;

                        }
                        value = value.Where(val => val != value[start]).ToArray();



                        length--;

                        start = Array.IndexOf(value, nextStart);

                        if (isLower.Count != 0)
                        {
                            if (char.Equals(nextStart, isLower[lindex]))
                            {
                                nextStart = value[(start + 1) % length];

                            }
                        }

                        if (isLower.Count != 0)
                        {
                            value = value.Where(val => val != isLower[lindex]).ToArray();
                        }

                        for (int i = 0; i < isLower.Count; i++)
                        {
                            char c = isLower[lindex];
                            isLower.Remove(c);
                            break;

                        }

                        length--;

                        start = Array.IndexOf(value, nextStart);

                    }
                    else
                    {
                        Outputstring += value[start];
                        if (isUpper.Count != 0)
                        {
                            Outputstring += isUpper[lindex];
                        }

                        Outputstring += " ";

                        //Console.WriteLine(Outputstring);
                        length = value.Length;

                        char nextStart = value[(start + 1) % length];

                        for (int i = 0; i < isLower.Count; i++)
                        {
                            char c = value[start];
                            isLower.Remove(c);

                        }

                        value = value.Where(val => val != value[start]).ToArray();

                        for (int i = 0; i < isUpper.Count; i++)
                        {
                            char c = value[start];
                            isUpper.Remove(c);

                        }

                        length--;

                        start = Array.IndexOf(value, nextStart);

                    }

                    while (length > 0)
                    {
                        start = (start + k - 1) % length;
                        length--;
                    }


                }
                //end



            }
            else
            {

                if (isLower.Count != 0)
                {
                    string s = new string(value);
                    Outputstring = s;

                    //Console.WriteLine(s);
                }
                else
                {
                    string s = new string(value);
                    Outputstring = s;
                }
            }
            return Outputstring.Trim(' ');


        }

        private bool Pairs(List<char> upper, List<char> lower)
        {
            if (upper.Count != 0)
                if (upper.Count != 0)
                    return true;

            return false;


        }


        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Dating dating = new Dating();

            do
            {
                string[] values = input.Split(',');
                Console.WriteLine(dating.Dates(values[0], Int32.Parse(values[1])));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
