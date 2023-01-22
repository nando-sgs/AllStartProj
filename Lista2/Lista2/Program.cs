using System;

namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Fernando");
            list.Add("Mariana");
            list.Add("Laura");
            list.Add("M.Raiane");
            list.Insert(2,"Fernanda");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"List Count: {list.Count}");

            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine($"First M: {s1}");

            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine($"Last M: {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine($"First Position: {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine($"Last Position: {pos2}");

            List<string> list2 = list.FindAll(x => x.Length == 8);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.Remove("Maria");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine();
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
       
    }
}