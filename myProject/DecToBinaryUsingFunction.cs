using System;
using System.Collections.Generic;
using System.Text;

namespace myProject
{
    public class DecToBinaryUsingFunction

    {
        public static void Run()
        {
            Console.WriteLine("please enter the value");
            string value = Console.ReadLine();
            Console.WriteLine(value);
            int decnum = Convert.ToInt32(value);

            string binaryString = ConvertDecToBin(decnum);
            Console.WriteLine("This is the Result " + binaryString);
        }

        static string ConvertDecToBin(int decnum)
        {
            {
                //int decnum;
                //num = decnum;
                string Result = "";
                int remind;
                //int i;

                while (decnum > 0)
                {
                    remind = decnum % 2;
                    decnum = decnum / 2;
                    Result += Convert.ToString(remind);

                }
                Console.WriteLine("Result is " + Result);
                return reversString(Result);

                static string reversString(string Result)
                {
                    string reversResult1 = "";
                    int i;
                    for (i = Result.Length; i > 0; i--)
                    {
                        reversResult1 += Result[i - 1];

                    }
                    Console.WriteLine("The reverseresult1 is " + reversResult1);
                    return reversResult1;
                }
                //Console.WriteLine("The reverseResult is " + reversResult);
                //return reversResult;
            }
        }
    }
}

