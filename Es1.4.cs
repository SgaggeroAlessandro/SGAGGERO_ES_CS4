using System;

namespace Es1array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            int n;
            bool diversi = true;

            do
            {
                Console.WriteLine("Scrivi quanti numeri vuoi inserire");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            num = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserisci un numero");
                int.TryParse(Console.ReadLine(), out num[i]);
            }
            for (int i = 0; i < n && diversi; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (num[i] == num[j])
                    {
                        diversi = false;
                        break;
                    }
                }
            }

            if (diversi == true)
            {
                Console.WriteLine("Risultato finale : 1");
            }
            else
            {
                Console.WriteLine("Risultato finale: 0");
            }
        }
    }
}