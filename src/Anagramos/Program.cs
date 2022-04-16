using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> DictionaryOfPrimes = TaskUtils.MakeDictionaryByAssigningPrimesToLetters();
            LithuanianWordsContainer AllLithuanianWords = InOutUtils.ReadWordsFromFile(@"zodynas.txt", DictionaryOfPrimes);
            Console.WriteLine("Įveskite žodį, kurio anagramą/anagramas norite rasti : ");
            string SearchedWord = Console.ReadLine();
            LithuanianWordsContainer AllFoundAnagrams = TaskUtils.FindAllAnagrams(DictionaryOfPrimes, SearchedWord, AllLithuanianWords);
            InOutUtils.OutputAllAnagrams(AllFoundAnagrams);
        }
    }
}
