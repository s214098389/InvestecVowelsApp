using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestecVowels
{
    interface IVowel
    {
        string DuplicateCheck(string sentense);
        string CountVowel(string sentense);
        string OutputVowel(string sentense);
    }
}
