using System;

namespace AulaMatriz{

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[,] mat = new int[num, num];

            for (int i = 0;i < num; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j=0;j < num; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
                

            }
            Console.WriteLine("Main Diagonal: ");
            for (int i = 0;i<num; i++)
            {
                Console.WriteLine(mat[i,i] + " ");
            }
           
        }
    }

} 