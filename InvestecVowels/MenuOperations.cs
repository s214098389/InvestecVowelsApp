using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestecVowels
{
    public sealed class MenuOperations: Vowel
    {
        private static MenuOperations _instance;
        private static object _lockThis = new object();
        string sentense = string.Empty;
        private MenuOperations() { }
        public static MenuOperations GetInstance()
        {
            lock(_lockThis)
            {
                if (_instance == null)
                    _instance = new MenuOperations();
            }
            return _instance;
        }
        public void DisplayMenu(string sentense)
        {
            this.sentense = sentense;

            string messsage = "Enter which operations to do on the supplied text, \n" + 
                "‘1’ for a duplicate character check, \n" + 
                "‘2’ to count the number of vowels, \n" + 
                "‘3’ to check if there are more vowels or non vowels, \n" +
                "or any combination of ‘1’, ‘2’ and ‘3’ to perform multiple checks: ";
            Console.WriteLine();

            Console.Write(messsage);
            string input = Console.ReadLine();

            char[] options = input.ToCharArray();

            foreach(char value in options)
            {
                if (value == '1')
                    Console.WriteLine(DuplicateCheck(sentense)); 
                else if (value == '2')
                    Console.WriteLine(CountVowel(sentense));
                else if (value == '3')
                    Console.WriteLine(OutputVowel(sentense));
            }

            Console.WriteLine();
        }
    }
}
