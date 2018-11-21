using System;
using System.Collections.Generic;
using System.Linq;
using WordWide.Model;

namespace WordWide.UI.Data
{
    public class WordDataService : IWordDataService
    {
        public IEnumerable<Word> GetAll() {
            yield return new Word{ EnglishWord = "one", TranslateWord = "jeden",Progress = 0.1};
            yield return new Word{ EnglishWord = "two", TranslateWord = "dwa",Progress = 0.2};
            yield return new Word{ EnglishWord = "three", TranslateWord = "trzy",Progress = 0.3};
            yield return new Word{ EnglishWord = "four", TranslateWord = "cztery",Progress = 0.4};
            yield return new Word{ EnglishWord = "five", TranslateWord = "pięć",Progress = 0.1};
        }
    }


}
