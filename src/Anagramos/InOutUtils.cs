using System.IO;
using System.Collections.Generic;

namespace Anagramos
{
    static class InOutUtils
    {
        public static LithuanianWordsContainer ReadWordsFromFile(string fileName, Dictionary<string,int> letterToPrimeDictionary)
        {
            LithuanianWordsContainer NewContainer = new LithuanianWordsContainer();
            string[] lines = File.ReadAllLines(fileName);
            foreach(string line in lines)
            {
                string[] parts = line.Split('	');
                string baseWord = parts[0].Trim();
                string wordType = parts[1].Trim();
                string word = parts[2].Trim();
                int howCommon = int.Parse(parts[3].Trim());
                long wordIDByPrimeNumbers = TaskUtils.CalculateIDsByAssignedPrimes(letterToPrimeDictionary, word);
                NewContainer.Add(new LithuanianWords(baseWord, wordType, word, howCommon, wordIDByPrimeNumbers));
            }
            return NewContainer;
        }
        public static void OutputAllAnagrams(LithuanianWordsContainer anagrams)
        {
            bool noneFound = true;
            System.Console.WriteLine("\nĮvesto žodžio anagrama / anagramos : ");
            for (int i = 0; i < anagrams.Count; i++)
            {
                System.Console.WriteLine(anagrams.Get(i).Word);
                noneFound = false;
            }
            if(noneFound)
            {
                System.Console.WriteLine("\nĮvestam žodžiui nerasta jokių anagramų.");
            }
            System.Console.WriteLine("\n\n");
        }

    }
}
