﻿namespace Boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////tant que
            ////imprimer les nombres 1 à 10
            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine($"{++i}");
            //    if (i == 5)
            //    {
            //        //sortir de la boucle
            //        //break;
            //        //passer à l'itération suivante
            //        continue;
            //    }
            //    Console.WriteLine($"{i}");


            //}

            ////do while
            //double num1 = 3;
            //double num2 = 8;
            //Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            //do
            //{
            //    num1++;
            //} while (num1 != num2);
            //Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            //Console.WriteLine($"num1 est égal à {num1}");

            //for
            //string[] noms = { "Jean", "Paul", "Jacques", "Pierre" };
            string[] noms = new string[4];
            for (int i = 0; i <= noms.Length - 1; i++)
            {
                noms[i] = Console.ReadLine();
            }

            for (int i = 0; i < noms.Length; i++)
            {
                Console.WriteLine(noms[i]);
            }

            Console.ReadLine();
        }
    }
}
