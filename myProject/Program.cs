using System;

namespace myProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "229233788889862221";

            char cl = myString[0];
            char pl = myString[0];
            int counter = 1;
            int maxrun = 1;

            for (int i = 0; i < myString.Length; i++)
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


