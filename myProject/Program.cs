using System;

namespace myProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 111;
            int per = Persistence(n);
            Console.WriteLine(per);

        }

        public static int Persistence(int n)
        {
            string m = Convert.ToString(n);
            Console.WriteLine("This is the string equivalent of n " + m);
            Console.WriteLine("This is the length of m " + m.Length);
            //int length = m.Length;
            //int mult = 11;
            int m2 = 1;
            int n2 = 1;
            
            for (int i = 0; i < m.Length; i++)
                {
                Console.WriteLine( "This is the element on each loop " + m[i]);    
                
                m2 = Convert.ToInt32(m[i]) * m2;

                Console.WriteLine("This is the multiplication m2 " + m2);
                //m2 = n2;

           }
                Console.WriteLine("This is the final multiplication" + m2);

            return m2;
        }

            

    }

}