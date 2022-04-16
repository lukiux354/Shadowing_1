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
            Console.WriteLine("Iveskite zodi, kurio anagrama norite rasti :");
            string SearchedWord = Console.ReadLine();
            for(int i = 0; i < AllLithuanianWords.Count; i++)
            {
                if (TaskUtils.CalculateIDsByAssignedPrimes(DictionaryOfPrimes, SearchedWord) == AllLithuanianWords.Get(i).WordIDByPrimeNumbers)
                {
                    Console.WriteLine(AllLithuanianWords.Get(i).Word);
                }
            }
        }
    }
}
