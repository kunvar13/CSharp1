using System;
using System.Collections.Generic;
using System.Text;

namespace myProject
{
    public class longestString
    {
        public static void Run()
        { 
        string myString = "11112";

        char cl = myString[0];
        char pl = myString[0];
        int counter = 1;
        int maxrun = 1;

            for (int i = 1; i<myString.Length; i++)
            {
               cl = myString[i];

                if (cl == pl)
                {
                    counter++;
                    
                }

                else
                {
                    counter = 1;
                    pl = cl;
                }

if (counter > maxrun)
{
    maxrun = counter;
}

               

            }
            Console.WriteLine(maxrun);
        }
        
    }

}