using System;

namespace ExMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int[,] mat = new int[n1, n2];

            for(int i = 0;i < n1; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n2; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }
            int inv = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {

                    if (inv == mat[i, j])
                    {
                        int findl = j - 1;
                        int findr = j + 1;
                        Console.WriteLine("Position: " + i + " , "+ j);
                        if (findl >= 0)
                        {
                            Console.WriteLine("Left: " + mat[i, findl]);
                        }
                        if (findr < mat.GetLength(1))
                        {
                             Console.WriteLine("Right: " + mat[i, findr]);
                           }
       
                        int findu = i - 1;
                        int findd = i + 1;
                        if (findu >= 0)
                        {
                            Console.WriteLine("Up: "+ mat[findu, j]);
                        }
                        if(findd <= mat.Rank)
                        {
                            Console.WriteLine("Down: " + mat[findd, j]);
                        }
                        


                    }
                    
                 
                }
            }


        }
    }
}
