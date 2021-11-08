using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestecVowels
{
    public abstract class Vowel : IVowel
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        public string CountVowel(string sentense)
        {
            Console.WriteLine();
            string message = string.Empty;
            int A_Count = 0, E_Count = 0, I_Count = 0, O_Count = 0, U_Count = 0;
            int sum = 0;
            char[] tmpCharacters = sentense.ToCharArray().Where(x => !String.IsNullOrEmpty(x.ToString())).ToArray();

            for (int i = 0; i < tmpCharacters.Length; i++)
            {
                for (int v = 0; v < vowels.Length; v++)
                {
                    if (tmpCharacters[i] == vowels[v])
                    {
                        if (tmpCharacters[i] == 'a')
                        {
                            A_Count++;
                            break;
                        }
                        else if (tmpCharacters[i] == 'e')
                        {
                            E_Count++;
                            break;
                        }
                        else if (tmpCharacters[i] == 'i')
                        {
                            I_Count++;
                            break;
                        }
                        else if (tmpCharacters[i] == 'o')
                        {
                            O_Count++;
                            break;
                        }
                        else if (tmpCharacters[i] == 'u')
                        {
                            U_Count++;
                            break;
                        }

                    }
                }
            }

            if (A_Count > 0)
                sum += 1;
            if (E_Count > 0)
                sum += 1;
            if(I_Count > 0)
                sum += 1;
            if(O_Count > 0)
                sum += 1;
            if(U_Count > 0)
                sum += 1;

            if (sum > 0)
                message = $"The number of vowels found is {sum}";
            else
                message = $"No vowels were found";

            return message;
        }

        public string DuplicateCheck(string sentense)
        {
            Console.WriteLine();
            string message = string.Empty;
            string duplicates = string.Empty;
            Dictionary<string, string> myList = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            char[] tmpCharacters = sentense.ToCharArray().Where(x => !String.IsNullOrEmpty(x.ToString())).ToArray();
            int noOfChars = 256;

            int[] count = new int[noOfChars];

            for (int i = 0; i < sentense.Length; i++)
            {
                count[sentense[i]]++;
            }

            for (int i = 0; i < noOfChars; i++)
            {
                if (count[i] > 1)
                {
                    if (Convert.ToString((Char)i) != "")
                        myList.Add(Convert.ToString((Char)i), Convert.ToString(count[i]));
                }
                    
            }


            foreach(char check in tmpCharacters)
            {
                if (myList.ContainsKey(check.ToString()))
                {
                    duplicates += check;
                    myList.Remove(check.ToString());
                }
                    
            }

            duplicates = duplicates.Replace(" ", string.Empty);

            if(duplicates != string.Empty)
                message = $"Found the following duplicates {duplicates}";
            else
                message = $"No duplicate values were found";
            return message;

        }

        public string OutputVowel(string sentense)
        {
            Console.WriteLine();
            string message = string.Empty;
            int vowelCount = 0, nonVowelCount = 0;
            char[] tmpCharacters = sentense.ToLower().ToCharArray().Where(x => !String.IsNullOrEmpty(x.ToString())).ToArray();

            for (int i = 0; i < tmpCharacters.Length; i++)
            {
                if(tmpCharacters[i] != ' ')
                    if (vowels.Contains(tmpCharacters[i]))
                        vowelCount++;
                    else
                        nonVowelCount++;
            }

            if (vowelCount > nonVowelCount)
                message = $"The text has more vowels than non vowels";
            else if (nonVowelCount > vowelCount)
                message = $"The text has more non vowels than vowels";
            else
                message = $"The text has an equal amount of vowels";

            return message;
        }
    }
}
