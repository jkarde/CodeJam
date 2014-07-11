using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Codejam
{
    class BinaryCoder
    {
        public String[] Decode(string test)
        {

            int[] array = new int[test.Length];

            array = test.Select(element => element - '0').ToArray();
            int [] p1 = new int[test.Length+1];
            int lenth1 = p1.Length;
            int length = test.Length;
            int[] p2 = new int[test.Length + 1];
            p1[0] = array[0];
            p2[0] = array[0];
            int pos = 0;
            int pos2 = 0;


           

            int lenth = p2.Length;

            
            string s1 = "";
            string s2 = "";



            if (test.Length > 1)
            {
                p1[0] = 0;

                for (int i = 0; i < test.Length; i++)
                {

                    if ((i - 1) == -1)
                    {
                        p1[i + 1] = array[i] + p1[i];
                    }
                    else
                    {

                        if (pos >= p1.Length - 1)
                        {
                            break;

                        }
                        else
                        {
                            if (p1[i + 1] <= test.Length)
                            {
                                p1[i + 1] = array[i] - (p1[i - 1] + p1[i]);
                                pos++;

                            }
                        }
                    }
                }



            }
            else {

                if (p1[0] == 0)
                    s1 += "0";
                else
                    s1 += "NONE";


            }


            if (test.Length > 1)
            {
                p2[0] = 1;
                for (int i = 0; i < test.Length; i++)
                {

                    if ((i - 1) == -1)
                    {
                        p2[i + 1] = array[i] - p2[i];
                    }
                    else
                    {

                        if (pos2 >= p2.Length - 2)
                        {
                            break;

                        }
                        else
                        {
                            if (p1[i + 1] < test.Length)
                            {
                                p2[i + 1] = array[i] - (p2[i - 1] + p2[i]);
                                pos2++;

                            }
                        }


                    }

                }
            }
            else {
                if (p1[0] == 1)
                    s2 += "1";
                else
                    s2 += "NONE";
            }

           int pos1 =0;
            int pos3 = 1;

            int [] array1 = new int [test.Length];
            int[] array2 = new int[test.Length];

           if (pos1 == 0 && s1=="")
           {

               for (int i = 0; i < test.Length ; i++)
               {
                   array1[i ] = p1[i];

               }

           } if (pos3 == 1&&s2=="") 
           {
               for (int i = 0; i < p2.Length-1; i++)
               {
                   array2[i] = p2[i];

               }
           }
            int array1last=0;
            int array2last=0;
            int lastelement1=0;
            int lastelement2=0;
            int array3last=0;
            int array4last=0;
           if (length > 1)
           {
               if (s1 == "" && s2 == "")
               {
                   lastelement1 = array[length - 1];
                   array1last = array1[length - 2];
                   array2last = array1[length - 1];


                   lastelement2 = array[length - 1];
                   array3last = array2[length - 2];
                   array4last = array2[length - 1];
               }
           }
           else {

               if (s1 == "" && s2 == "")
               {

                   lastelement1 = array[0];
                   array1last = array1[0];
                   array2last = array1[0];

                   lastelement2 = array[0];
                   array3last = array2[0];
                   array4last = array2[0];
               }
           }
            string [] returnstring1 = new string[2];
            

            

            bool flag1 = true;
            bool flag2 = true;

            if (array1last + array2last == lastelement1)
            {
                for (int i = 0; i < p1.Length; i++)
                {
                    if (p1[i] <= -1 && s1 == "")
                    {
                        s1 = "NONE";
                        flag1 = false;
                        break;

                    }else if (p1[i] >= 2 && s1 == "")
                        {
                            s1 = "NONE";
                            flag1 = false;
                            break;

                        }else {

                            flag1 = true;


                    }
                }
            }
            else {
                s1 = "NONE";

            
            }


            if (array3last + array4last == lastelement2)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    if (array2[i] <= -1 && s2 == "")
                    {
                        s2 = "NONE";
                        flag2 = false;
                        break;

                    }
                    else if (array2[i] >= 2 && s2 == "")
                    {
                        s2 = "NONE";
                        flag2 = false;

                        break;

                    }
                    else
                    {
                        flag2 = true;



                    }


                }
            }
            else {
                s2 = "NONE";

            }
            if(length > 1)
            {
                if (flag1 == true&&s1=="")
                {
                    for (int i = 0; i < array1.Length; i++)
                    {
                        s1 = s1 + array1[i];


                    }

                }
            }
            if (length > 1)
            {
                if (flag2 == true&&s2=="")
                {
                    for (int i = 0; i < array2.Length; i++)
                    {
                        s2 = s2 + array2[i];


                    }
                }
            }

            returnstring1[0] = s1;
            returnstring1[1] = s2;



            return returnstring1;


        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            BinaryCoder coder = new BinaryCoder();
            do
            {
                String[] validationOp = coder.Decode(input);
                Console.WriteLine("{0},{1}", validationOp[0], validationOp[1]);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}