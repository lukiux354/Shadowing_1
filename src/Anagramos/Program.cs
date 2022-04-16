using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;


namespace Anagramos
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> DictionaryOfPrimes = TaskUtils.MakeDictionaryByAssigningPrimesToLetters();
            LithuanianWordsContainer AllLithuanianWords = InOutUtils.ReadWordsFromFile(@"zodynas.txt", DictionaryOfPrimes);

            Console.WriteLine("Įveskite žodį, kurio anagramą/anagramas norite rasti : ");
            string searchedWord = Console.ReadLine();

            if(TaskUtils.WordIsValid(searchedWord))
            {
                LithuanianWordsContainer AllFoundAnagrams = TaskUtils.FindAllAnagrams(DictionaryOfPrimes, searchedWord, AllLithuanianWords);
                InOutUtils.OutputAllAnagrams(AllFoundAnagrams);
            }
            else
            {
                Console.WriteLine("Jūsų įvestas žodis yra per trumpas. Mažiausias leistinas žodžio ilgis : {0}", int.Parse(ConfigurationManager.AppSettings.Get("MinAnagramInputLength")));
            }
        }
    }
}
