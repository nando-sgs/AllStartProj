using System;

namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "ALEX", "MARIA", "BOB" };

            for (int i = 0;i< vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("----------------------------");

            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
