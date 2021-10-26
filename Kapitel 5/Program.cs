using System;

namespace Kapitel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] svenskaStäder = new string[3];

            svenskaStäder[0] = "Lidköping";
            svenskaStäder[1] = "Göteborg";
            Console.WriteLine("Skriv in en valfri stad");
            svenskaStäder[2] = Console.ReadLine();

            Console.WriteLine($"{svenskaStäder[0]}, {svenskaStäder[1]} och {svenskaStäder[2]}");
           

            Console.WriteLine("Skriv in antalet sporter du har testat");
            int anatlSporter = int.Parse(Console.ReadLine());
            string[] sporter = new string[anatlSporter];

            for (int i = 0; i < anatlSporter; i++)
            {
                Console.WriteLine($"Skriv in sport {i + 1} av {anatlSporter}");
                sporter[i] = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("här kommer alla sporter du har testat");

            for (int i = 0; i < anatlSporter; i++) 
            {
                Console.WriteLine(sporter[i]);
            }
            
            int[] tal = { 10, 2, 33, 69, -9898, 33, 16, 8 };

            int max = tal[0];

            for (int i = 1; i < tal.Length; i++)
            {
                if (tal[i] > max)
                {
                    max = tal[i];
                }
            }

            Console.WriteLine($"Det största talet är: {max}");
            



            5.6
            string[] länder = new string[5];
            Console.WriteLine("Skriv in 5 länder");

            for (int i = 0; i < länder.Length; i++)
            {
                Console.WriteLine($"Skriv in land {i + 1}");
                länder[i] = Console.ReadLine();
            }

            Console.WriteLine();

            foreach (string land in länder)
            {
                Console.WriteLine(land);
            }
           

            //5.7
            Console.WriteLine("hej");

            int[] tals = new int[5];

            tals[0] = 2;
            tals[1] = 7;
            tals[2] = 10;
            tals[3] = 1;
            tals[4] = 13;

            int summa = 0;

            foreach (int tal in tals)
            {
                summa += tal;
            }
            Console.WriteLine($"Summan av talen är: {summa}");
             
            //5.8
            Console.WriteLine("Skriv en mening");
            string mening = Console.ReadLine();

            string[] separeradMening = mening.Split(' ');

            foreach (string ord in separeradMening)
            {
                Console.WriteLine(ord);
            }
            */

            //5.9

            Console.WriteLine("Skriv olika tal och separera dessa med + emmellan varje");
            string användarensTal = Console.ReadLine();

            string[] separeradeTal = användarensTal.Split('+');

            int summa = 0;



        }
    }
}
