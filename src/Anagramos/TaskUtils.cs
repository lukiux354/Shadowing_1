using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Anagramos
{
    static class TaskUtils
    {
        public static Dictionary<string,int> MakeDictionaryByAssigningPrimesToLetters()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("i", 2);
            dict.Add("a", 3);
            dict.Add("s", 5);
            dict.Add("o", 7);
            dict.Add("r", 11);
            dict.Add("e", 13);
            dict.Add("t", 17);
            dict.Add("n", 19);
            dict.Add("u", 23);
            dict.Add("k", 29);
            dict.Add("m", 31);
            dict.Add("l", 37);
            dict.Add("p", 41);
            dict.Add("v", 43);
            dict.Add("d", 47);
            dict.Add("j", 53);
            dict.Add("g", 59);
            dict.Add("ė", 61);
            dict.Add("b", 67);
            dict.Add("y", 71);
            dict.Add("ų", 73);
            dict.Add("š", 79);
            dict.Add("ž", 83);
            dict.Add("c", 89);
            dict.Add("ą", 97);
            dict.Add("į", 101);
            dict.Add("-", 103);
            dict.Add("ū", 107);
            dict.Add("f", 109);
            dict.Add("z", 113);
            dict.Add("h", 127);
            dict.Add("ę", 131);
            dict.Add("0", 137);
            dict.Add("1", 139);
            dict.Add("2", 149);
            dict.Add("3", 151);
            dict.Add("4", 157);
            dict.Add("5", 163);
            dict.Add("6", 167);
            dict.Add("7", 173);
            dict.Add("8", 179);
            dict.Add("9", 181);
            dict.Add("č", 191);
            dict.Add(".", 193);
            dict.Add("'", 197);
            dict.Add(" ", 199);
            dict.Add("x", 211);
            dict.Add("w", 223);
            dict.Add("q", 227);
            dict.Add("ź", 229);
            dict.Add("°", 233);
            dict.Add("+", 239);
            dict.Add("Ī".ToLower(), 241);
            dict.Add("ā", 251);
            dict.Add("Ł".ToLower(), 257);
            dict.Add("ķ", 263);
            return dict;
        }
        public static long CalculateIDsByAssignedPrimes(Dictionary<string, int> primes, string word)
        {
            long calculatedID = 1;
            foreach(char letter in word.ToLower())
            {
                calculatedID = calculatedID * primes[letter.ToString()];
            }
            return calculatedID;
        }
        public static LithuanianWordsContainer FindAllAnagrams(Dictionary<string, int> dictionaryOfPrimes, string searchedWord, LithuanianWordsContainer allLithuanianWords)
        {
            LithuanianWordsContainer AllAnagrams = new LithuanianWordsContainer();
            for (int i = 0; i < allLithuanianWords.Count; i++)
            {
                if (TaskUtils.CalculateIDsByAssignedPrimes(dictionaryOfPrimes, searchedWord) == allLithuanianWords.Get(i).WordIDByPrimeNumbers && allLithuanianWords.Get(i).Word != searchedWord)
                {
                    AllAnagrams.Add(allLithuanianWords.Get(i));
                }
            }
            return AllAnagrams;
        }
        public static bool WordIsValid(string word)
        {
            int MinAnagramInputLength = int.Parse(ConfigurationManager.AppSettings.Get("MinAnagramInputLength"));
            if (word.Length >= MinAnagramInputLength)
            {
                return true;
            }
            return false;
        }
    }
}
