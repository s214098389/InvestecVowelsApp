using System;

namespace InvestecVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Investec Vowels Assessment";

            string sentense;
            Console.Write("Enter text to be analysed: ");
            sentense = Console.ReadLine();

            MenuOperations.GetInstance().DisplayMenu(sentense);

            Console.ReadLine();
        }
    }
}
