using System;

namespace Es1array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[30];

            Random r = new Random();
            
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = r.Next(0, 101);
                Console.Write(v[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Coppie trovate:");
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (i != j && v[i] == 2 * v[j])
                    {
                        Console.WriteLine(v[i] + " " + v[j]);
                    }

                }
            }
        }
    }
}