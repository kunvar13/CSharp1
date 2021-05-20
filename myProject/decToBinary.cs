using System;
using System.Collections.Generic;
using System.Text;

namespace myProject
{
    public class decToBinary
    {
        public static void Run()
        {
            string value = Console.ReadLine();
        Console.WriteLine(value);
            int decnum = Convert.ToInt32(value);

        string binaryString = ConvertDecToBin(decnum);
        Console.WriteLine("This is the Result " + binaryString);
        }

    static string ConvertDecToBin(int num)
    {
        {
            int decnum = 15;
            string Result = "";
            int remind;
            int i;

            while (decnum > 0)
            {
                remind = decnum % 2;
                decnum = decnum / 2;
                Result += Convert.ToString(remind);
                //Console.WriteLine();
                //Console.WriteLine();


            }
            //Console.WriteLine("This is the result " + Result);

            string reversResult = "";
            for (i = Result.Length; i > 0; i--)
            {
                reversResult += Result[i - 1];

            }
            // Console.WriteLine("This is the Actual Result " + reversResult);
            return reversResult;
        }
    }

}
}
