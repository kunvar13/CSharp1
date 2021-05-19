using System;

namespace myProject
{
    class Program
    {
        static void Main(string[] args)
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
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /* string myString = "11112";

            char cl = myString[0];
            char pl = myString[0];
            int counter = 1;
            int maxrun = 1;

            for (int i = 1; i < myString.Length; i++)
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

                if (counter>maxrun)
                {
                    maxrun = counter;
                }

               

            }
            Console.WriteLine(maxrun);
        }
        
    }

}







            /*{
            for(int i=0; i<= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + "Fizz Buzz");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + "Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + "Buzz");
                }
                else
                { Console.WriteLine(i); }

            }

            }

            
        }*/
    //}


