
using System;

namespace Es1array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float s = 0;
            float[] v = new float[100];
            float n;
            bool c = false; //coppia trovata
            int cont = 0; //contatore numeri inseriti
            for (int i = 0; cont < 100 && s < 50; i++)
            {
                do
                {
                    Console.WriteLine("Inserisci un numero reale");

                } while (!float.TryParse(Console.ReadLine(), out v[i]));

                s += v[i];
                cont++;
            }
            n = v[0];//primo numero inserito dall'utente
            if (cont >= 3) 
            {
                for (int i = 0; i < cont && !c; i++) //va avanti fino a quando non scorre tutti i numeri inseriti o finchè non trova la coppia
                {
                    for (int j = i + 1; j < cont && !c; j++)//va avanti fino a quando non scorre tutti i numeri inseriti o finchè non trova la coppia, senza contare due volte la stessa coppia 
                    {
                        if ((v[j] != 0 && v[i] / (float)v[j] == n) || (v[i] != 0 && v[j] / (float)v[i] == n))
                        {
                            if (v[j] != 0 && v[j] / (float)v[i] == n)//per stampare correttamente la coppia di numeri
                            {
                                Console.WriteLine("Il rapporto di " + v[j] + " e " + v[i] + " è uguale al primo numero inserito dall'utente");
                                
                            }
                            else
                            {
                                Console.WriteLine("Il rapporto di " + v[i] + " e " + v[j] + " è uguale al primo numero inserito dall'utente");
                            }
                            c = true;
                            break;
                        }
                    }
                }
            }
            else //sono stati inseriti meno di 3 numeri
            {
                Console.WriteLine("Non ci sono abbastanza numeri per verificare se il rapporto di una coppia di numeri è uguale al primo numero inserito dall'utente");
            }
            if (c == false && cont >= 3) //nessuna coppia trovata
            {
                Console.WriteLine("Non esiste una coppia di numeri il cui rapporto è uguale al primo numero inserito dall'utente");
            }
        }
    }
}

