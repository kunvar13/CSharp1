using System;
using System.Collections.Generic;
using System.Text;

namespace myProject
{
    public class ageTicket
    {
        public static void Run()
        {
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 5)
            {
                Console.WriteLine("You got a free ticket");
            }

            if (age > 5 && age <= 14)
            {
                Console.WriteLine("Pleas pay 7.99 for your ticket");
            }

            if (age > 14 && age <= 65)
            {
                Console.WriteLine("Pleas pay 11.99 for your ticket");
            }
            else
            {
                Console.WriteLine("Pleas pay 9.99 for your ticket");
            }

        }
    }

}
