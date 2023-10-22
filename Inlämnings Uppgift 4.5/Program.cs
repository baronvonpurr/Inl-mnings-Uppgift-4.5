using System;

namespace Uppgift4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            Console.WriteLine("Skriv in ett heltal");
            string tal = Console.ReadLine();

            for (int i = 0; i < tal.Length; i++)
            {
                string tecken = tal[i].ToString();
                int siffra = int.Parse(tecken) + 1;
                if (siffra == 10)
                {
                    siffra = 0;
                }
                svar = svar + siffra;
            }
            Console.WriteLine(svar);
            Console.ReadKey();
        }
    }
}